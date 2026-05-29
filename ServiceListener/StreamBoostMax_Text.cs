using Newtonsoft.Json.Linq;
using System;
using System.Net.WebSockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace DonateMonitor.ServiceListener
{
    internal class StreamBoostMax_Text : IServiceListener
    {
        private const string WS_BASE = "wss://www.streamboostmax.com/ws/donations";
        private static readonly Regex _tokenFromUrl =
            new Regex(@"/notification-box/v\d+/([A-Za-z0-9_\-]+)", RegexOptions.IgnoreCase);

        private ClientWebSocket _ws;
        private readonly SemaphoreSlim _sendLock = new SemaphoreSlim(1, 1);

        public async Task StartAsync(Monitor monitor, CancellationToken token)
        {
            int attempt = 0;
            while (!token.IsCancellationRequested)
            {
                try
                {
                    attempt++;
                    await RunOnceAsync(monitor, token).ConfigureAwait(false);
                    attempt = 0;
                }
                catch (OperationCanceledException) when (token.IsCancellationRequested)
                {
                    break;
                }
                catch (Exception ex)
                {
                    monitor.AddLog($"StreamBoostMax(訊息) 連線失敗: {ex.Message}");
                    Global.WriteErrorLog($"[StreamBoostMax_Text] {ex}");
                }

                monitor.SetActiveStreamBoostMax_Text(false);

                if (token.IsCancellationRequested) break;

                var delay = ComputeBackoff(attempt);
                try { await Task.Delay(delay, token).ConfigureAwait(false); }
                catch (OperationCanceledException) { break; }
            }

            await StopAsync().ConfigureAwait(false);
        }

        public async Task StopAsync()
        {
            var ws = _ws;
            _ws = null;
            if (ws != null)
            {
                try
                {
                    if (ws.State == WebSocketState.Open)
                        await ws.CloseAsync(WebSocketCloseStatus.NormalClosure, "shutdown", CancellationToken.None).ConfigureAwait(false);
                }
                catch { }
                try { ws.Dispose(); } catch { }
            }
        }

        private async Task RunOnceAsync(Monitor monitor, CancellationToken ct)
        {
            var token = ExtractToken(Global.StreamBoostMax_Text_OverlayUrl);
            if (string.IsNullOrEmpty(token))
                throw new InvalidOperationException("無法從網址解析 StreamBoostMax token");

            var uri = new Uri($"{WS_BASE}?resource_uuid={Uri.EscapeDataString(token)}");

            _ws = new ClientWebSocket();
            _ws.Options.KeepAliveInterval = TimeSpan.FromSeconds(30);

            await _ws.ConnectAsync(uri, ct).ConfigureAwait(false);

            monitor.SetActiveStreamBoostMax_Text(true);
            monitor.AddLog("與 StreamBoostMax(訊息) 伺服器連線成功");

            var buf = new byte[16 * 1024];
            var msg = new StringBuilder();

            while (_ws.State == WebSocketState.Open && !ct.IsCancellationRequested)
            {
                msg.Clear();
                WebSocketReceiveResult result;
                do
                {
                    result = await _ws.ReceiveAsync(new ArraySegment<byte>(buf), ct).ConfigureAwait(false);
                    if (result.MessageType == WebSocketMessageType.Close)
                    {
                        try { await _ws.CloseAsync(WebSocketCloseStatus.NormalClosure, "bye", ct).ConfigureAwait(false); } catch { }
                        return;
                    }
                    msg.Append(Encoding.UTF8.GetString(buf, 0, result.Count));
                } while (!result.EndOfMessage);

                var raw = msg.ToString();
#if DEBUG
                Console.WriteLine($"[StreamBoostMax_Text] {raw}");
#endif
                try { Global.WriteDebugLog($"[StreamBoostMax_Text] {raw}"); } catch { }

                HandleMessage(monitor, raw);
            }
        }

        private void HandleMessage(Monitor monitor, string raw)
        {
            JObject obj;
            try { obj = JObject.Parse(raw); }
            catch (Exception ex)
            {
                Global.WriteErrorLog($"[StreamBoostMax_Text] JSON parse failed: {ex.Message}");
                return;
            }

            var type = obj.Value<string>("type");

            if (string.Equals(type, "ping", StringComparison.OrdinalIgnoreCase))
            {
                _ = SendJsonAsync(new JObject
                {
                    ["type"] = "pong",
                    ["timestamp"] = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss.fffZ")
                });
                return;
            }

            if (string.Equals(type, "donationEvent", StringComparison.OrdinalIgnoreCase))
            {
                var eventId = obj.Value<string>("eventId");
                var donationId = obj.Value<string>("donationId") ?? eventId;

                if (!string.IsNullOrEmpty(eventId))
                {
                    _ = SendJsonAsync(new JObject
                    {
                        ["type"] = "ack",
                        ["eventId"] = eventId,
                        ["timestamp"] = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss.fffZ")
                    });
                }

                // 伺服器在收到 playbackStatus=completed 之前會把後續斗內留在佇列中，
                // 必須回覆 playing → completed 才會收到下一筆事件。
                _ = NotifyPlaybackCompletedAsync(donationId);

                var donationType = obj.Value<string>("donationType");
                if (!string.Equals(donationType, "text-donate", StringComparison.OrdinalIgnoreCase))
                {
                    // 目前僅處理文字斗內，其他型別忽略
                    return;
                }

                var donorName = obj.Value<string>("donorName") ?? "";
                var donorDisplayName = obj.Value<string>("donorDisplayName") ?? donorName;
                var amount = obj.Value<string>("amount") ?? "0";
                var currency = obj.Value<string>("currency") ?? "TWD";
                var message = obj.Value<string>("message") ?? "";

                Task.Run(() =>
                {
                    try
                    {
                        monitor.AppendLogFromStreamBoostMax_Text(donorName, donorDisplayName, amount, currency, message);
                    }
                    catch (Exception ex)
                    {
                        Global.WriteErrorLog($"[StreamBoostMax_Text] AppendLog error: {ex}");
                    }
                });
            }
        }

        private async Task NotifyPlaybackCompletedAsync(string donationId)
        {
            if (string.IsNullOrEmpty(donationId)) return;
            try
            {
                await SendPlaybackStatusAsync(donationId, "playing").ConfigureAwait(false);
                await Task.Delay(200).ConfigureAwait(false);
                await SendPlaybackStatusAsync(donationId, "completed").ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                Global.WriteErrorLog($"[StreamBoostMax_Text] NotifyPlayback error: {ex.Message}");
            }
        }

        private Task SendPlaybackStatusAsync(string donationId, string status)
        {
            return SendJsonAsync(new JObject
            {
                ["type"] = "playbackStatus",
                ["donationId"] = donationId,
                ["status"] = status,
                ["timestamp"] = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss.fffZ")
            });
        }

        private async Task SendJsonAsync(JObject obj)
        {
            var ws = _ws;
            if (ws == null || ws.State != WebSocketState.Open) return;

            var bytes = Encoding.UTF8.GetBytes(obj.ToString(Newtonsoft.Json.Formatting.None));
            await _sendLock.WaitAsync().ConfigureAwait(false);
            try
            {
                await ws.SendAsync(new ArraySegment<byte>(bytes), WebSocketMessageType.Text, true, CancellationToken.None).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                Global.WriteErrorLog($"[StreamBoostMax_Text] Send error: {ex.Message}");
            }
            finally
            {
                _sendLock.Release();
            }
        }

        private static string ExtractToken(string url)
        {
            if (string.IsNullOrEmpty(url)) return null;
            var trimmed = url.Trim();

            var m = _tokenFromUrl.Match(trimmed);
            if (m.Success) return m.Groups[1].Value;

            // 退路：若使用者直接貼 token，沒有 URL，視為純 token
            if (!trimmed.Contains("/") && !trimmed.Contains(" "))
                return trimmed;

            // 退路：取最後一段 path
            try
            {
                var uri = new Uri(trimmed);
                var segs = uri.AbsolutePath.TrimEnd('/').Split('/');
                if (segs.Length > 0)
                {
                    var last = segs[segs.Length - 1];
                    if (!string.IsNullOrEmpty(last)) return last;
                }
            }
            catch { }
            return null;
        }

        private static TimeSpan ComputeBackoff(int attempt)
        {
            var pow = Math.Min(attempt, 5);
            var seconds = Math.Min(30, (int)Math.Pow(2, pow));
            var jitter = new Random().Next(0, 500);
            return TimeSpan.FromSeconds(seconds) + TimeSpan.FromMilliseconds(jitter);
        }
    }
}
