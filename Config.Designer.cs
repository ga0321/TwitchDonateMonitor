namespace DonateMonitor
{
    partial class Config
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.RBt_ObsOutputMode_Single = new System.Windows.Forms.RadioButton();
            this.RBt_ObsOutputMode_NextLine = new System.Windows.Forms.RadioButton();
            this.Cb_EnableSubOutput = new System.Windows.Forms.CheckBox();
            this.Cb_EnableResubOutput = new System.Windows.Forms.CheckBox();
            this.Cb_EnableStartupCheckOldData = new System.Windows.Forms.CheckBox();
            this.label_MinBitsAmount = new System.Windows.Forms.Label();
            this.Nud_MinBitsAmount = new System.Windows.Forms.NumericUpDown();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtPreview_StreamBoostMax_Video = new System.Windows.Forms.Button();
            this.Tb_Msg_StreamBoostMax_Video_Msg = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.BtPreview_StreamBoostMax_Text = new System.Windows.Forms.Button();
            this.Tb_Msg_StreamBoostMax_Text_Msg = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.BtPreview_SoundAlerts = new System.Windows.Forms.Button();
            this.Tb_Msg_SoundAlerts_Msg = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.BtPreview_Streamlabs_Resub = new System.Windows.Forms.Button();
            this.Tb_Msg_Streamlabs_Resub_Msg = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.BtPreview_Streamlabs_Sub = new System.Windows.Forms.Button();
            this.Tb_Msg_Streamlabs_Sub_Msg = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.BtPreview_HiveBee = new System.Windows.Forms.Button();
            this.Tb_Msg_HiveBee_Msg = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.BtPreview_Streamlabs_Bits = new System.Windows.Forms.Button();
            this.BtPreview_Streamlabs_SubGift = new System.Windows.Forms.Button();
            this.BtPreview_Streamlabs_Paypal = new System.Windows.Forms.Button();
            this.BtPreview_OPay = new System.Windows.Forms.Button();
            this.BtPreview_ECPay = new System.Windows.Forms.Button();
            this.Tb_Msg_Streamlabs_Bits_Msg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Tb_Msg_Streamlabs_SubGift_Msg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Tb_Msg_Streamlabs_Paypal_Msg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Tb_Msg_OPay_Msg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Tb_Msg_ECPay_Msg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Bt_Save = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Tb_Msg_Custom_Sub_Tier3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Tb_Msg_Custom_Sub_Tier2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Tb_Msg_Custom_Sub_Tier1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Tb_Msg_Custom_Bits = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Tb_Msg_Custom_Sub_Gift = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Tb_Msg_Custom_Anon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BtReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_MinBitsAmount)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans TC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "OBS檔案輸出模式：";
            //
            // RBt_ObsOutputMode_Single
            //
            this.RBt_ObsOutputMode_Single.AutoSize = true;
            this.RBt_ObsOutputMode_Single.Font = new System.Drawing.Font("Noto Sans TC", 14F);
            this.RBt_ObsOutputMode_Single.Location = new System.Drawing.Point(319, 24);
            this.RBt_ObsOutputMode_Single.Name = "RBt_ObsOutputMode_Single";
            this.RBt_ObsOutputMode_Single.Size = new System.Drawing.Size(377, 44);
            this.RBt_ObsOutputMode_Single.TabIndex = 2;
            this.RBt_ObsOutputMode_Single.TabStop = true;
            this.RBt_ObsOutputMode_Single.Text = "單行模式 (A: 100T B: 100T)";
            this.RBt_ObsOutputMode_Single.UseVisualStyleBackColor = true;
            //
            // RBt_ObsOutputMode_NextLine
            //
            this.RBt_ObsOutputMode_NextLine.AutoSize = true;
            this.RBt_ObsOutputMode_NextLine.Font = new System.Drawing.Font("Noto Sans TC", 14F);
            this.RBt_ObsOutputMode_NextLine.Location = new System.Drawing.Point(207, 24);
            this.RBt_ObsOutputMode_NextLine.Name = "RBt_ObsOutputMode_NextLine";
            this.RBt_ObsOutputMode_NextLine.Size = new System.Drawing.Size(154, 44);
            this.RBt_ObsOutputMode_NextLine.TabIndex = 1;
            this.RBt_ObsOutputMode_NextLine.TabStop = true;
            this.RBt_ObsOutputMode_NextLine.Text = "換行模式";
            this.RBt_ObsOutputMode_NextLine.UseVisualStyleBackColor = true;
            //
            // Cb_EnableSubOutput
            //
            this.Cb_EnableSubOutput.AutoSize = true;
            this.Cb_EnableSubOutput.Checked = true;
            this.Cb_EnableSubOutput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Cb_EnableSubOutput.Font = new System.Drawing.Font("Noto Sans TC", 14F);
            this.Cb_EnableSubOutput.Location = new System.Drawing.Point(24, 61);
            this.Cb_EnableSubOutput.Name = "Cb_EnableSubOutput";
            this.Cb_EnableSubOutput.Size = new System.Drawing.Size(183, 44);
            this.Cb_EnableSubOutput.TabIndex = 3;
            this.Cb_EnableSubOutput.Text = "輸出新訂閱";
            this.Cb_EnableSubOutput.UseVisualStyleBackColor = true;
            //
            // Cb_EnableResubOutput
            //
            this.Cb_EnableResubOutput.AutoSize = true;
            this.Cb_EnableResubOutput.Checked = true;
            this.Cb_EnableResubOutput.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Cb_EnableResubOutput.Font = new System.Drawing.Font("Noto Sans TC", 14F);
            this.Cb_EnableResubOutput.Location = new System.Drawing.Point(180, 61);
            this.Cb_EnableResubOutput.Name = "Cb_EnableResubOutput";
            this.Cb_EnableResubOutput.Size = new System.Drawing.Size(155, 44);
            this.Cb_EnableResubOutput.TabIndex = 4;
            this.Cb_EnableResubOutput.Text = "輸出續訂";
            this.Cb_EnableResubOutput.UseVisualStyleBackColor = true;
            //
            // Cb_EnableStartupCheckOldData
            //
            this.Cb_EnableStartupCheckOldData.AutoSize = true;
            this.Cb_EnableStartupCheckOldData.Checked = true;
            this.Cb_EnableStartupCheckOldData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Cb_EnableStartupCheckOldData.Font = new System.Drawing.Font("Noto Sans TC", 14F);
            this.Cb_EnableStartupCheckOldData.Location = new System.Drawing.Point(315, 61);
            this.Cb_EnableStartupCheckOldData.Name = "Cb_EnableStartupCheckOldData";
            this.Cb_EnableStartupCheckOldData.Size = new System.Drawing.Size(267, 44);
            this.Cb_EnableStartupCheckOldData.TabIndex = 5;
            this.Cb_EnableStartupCheckOldData.Text = "啟動時檢查舊資料";
            this.Cb_EnableStartupCheckOldData.UseVisualStyleBackColor = true;
            //
            // label_MinBitsAmount
            //
            this.label_MinBitsAmount.AutoSize = true;
            this.label_MinBitsAmount.Font = new System.Drawing.Font("Noto Sans TC", 14F);
            this.label_MinBitsAmount.Location = new System.Drawing.Point(24, 112);
            this.label_MinBitsAmount.Name = "label_MinBitsAmount";
            this.label_MinBitsAmount.Size = new System.Drawing.Size(359, 40);
            this.label_MinBitsAmount.TabIndex = 6;
            this.label_MinBitsAmount.Text = "小奇點達到才顯示於 OBS：";
            //
            // Nud_MinBitsAmount
            //
            this.Nud_MinBitsAmount.Font = new System.Drawing.Font("Noto Sans TC", 14F);
            this.Nud_MinBitsAmount.Location = new System.Drawing.Point(268, 109);
            this.Nud_MinBitsAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Nud_MinBitsAmount.Name = "Nud_MinBitsAmount";
            this.Nud_MinBitsAmount.Size = new System.Drawing.Size(140, 48);
            this.Nud_MinBitsAmount.TabIndex = 7;
            //
            // tabControl1
            //
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Noto Sans TC", 12F);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(699, 600);
            this.tabControl1.TabIndex = 0;
            //
            // tabPage1
            //
            this.tabPage1.Controls.Add(this.label_MinBitsAmount);
            this.tabPage1.Controls.Add(this.Nud_MinBitsAmount);
            this.tabPage1.Controls.Add(this.Cb_EnableStartupCheckOldData);
            this.tabPage1.Controls.Add(this.Cb_EnableResubOutput);
            this.tabPage1.Controls.Add(this.Cb_EnableSubOutput);
            this.tabPage1.Controls.Add(this.RBt_ObsOutputMode_Single);
            this.tabPage1.Controls.Add(this.RBt_ObsOutputMode_NextLine);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(691, 560);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "普通設定";
            this.tabPage1.UseVisualStyleBackColor = true;
            //
            // tabPage2
            //
            this.tabPage2.Controls.Add(this.BtPreview_StreamBoostMax_Video);
            this.tabPage2.Controls.Add(this.Tb_Msg_StreamBoostMax_Video_Msg);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.BtPreview_StreamBoostMax_Text);
            this.tabPage2.Controls.Add(this.Tb_Msg_StreamBoostMax_Text_Msg);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.BtPreview_SoundAlerts);
            this.tabPage2.Controls.Add(this.Tb_Msg_SoundAlerts_Msg);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.BtPreview_Streamlabs_Resub);
            this.tabPage2.Controls.Add(this.Tb_Msg_Streamlabs_Resub_Msg);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.BtPreview_Streamlabs_Sub);
            this.tabPage2.Controls.Add(this.Tb_Msg_Streamlabs_Sub_Msg);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.BtPreview_HiveBee);
            this.tabPage2.Controls.Add(this.Tb_Msg_HiveBee_Msg);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.BtPreview_Streamlabs_Bits);
            this.tabPage2.Controls.Add(this.BtPreview_Streamlabs_SubGift);
            this.tabPage2.Controls.Add(this.BtPreview_Streamlabs_Paypal);
            this.tabPage2.Controls.Add(this.BtPreview_OPay);
            this.tabPage2.Controls.Add(this.BtPreview_ECPay);
            this.tabPage2.Controls.Add(this.Tb_Msg_Streamlabs_Bits_Msg);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.Tb_Msg_Streamlabs_SubGift_Msg);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.Tb_Msg_Streamlabs_Paypal_Msg);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.Tb_Msg_OPay_Msg);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.Tb_Msg_ECPay_Msg);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(691, 560);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "OBS 輸出設定";
            this.tabPage2.UseVisualStyleBackColor = true;
            //
            // BtPreview_StreamBoostMax_Video
            //
            this.BtPreview_StreamBoostMax_Video.Font = new System.Drawing.Font("Noto Sans TC", 12F);
            this.BtPreview_StreamBoostMax_Video.Location = new System.Drawing.Point(631, 462);
            this.BtPreview_StreamBoostMax_Video.Name = "BtPreview_StreamBoostMax_Video";
            this.BtPreview_StreamBoostMax_Video.Size = new System.Drawing.Size(62, 35);
            this.BtPreview_StreamBoostMax_Video.TabIndex = 35;
            this.BtPreview_StreamBoostMax_Video.Text = "預覽";
            this.BtPreview_StreamBoostMax_Video.UseVisualStyleBackColor = true;
            this.BtPreview_StreamBoostMax_Video.Click += new System.EventHandler(this.BtPreview_StreamBoostMax_Video_Click);
            //
            // Tb_Msg_StreamBoostMax_Video_Msg
            //
            this.Tb_Msg_StreamBoostMax_Video_Msg.Font = new System.Drawing.Font("Noto Sans TC", 14F);
            this.Tb_Msg_StreamBoostMax_Video_Msg.Location = new System.Drawing.Point(174, 462);
            this.Tb_Msg_StreamBoostMax_Video_Msg.Name = "Tb_Msg_StreamBoostMax_Video_Msg";
            this.Tb_Msg_StreamBoostMax_Video_Msg.Size = new System.Drawing.Size(451, 48);
            this.Tb_Msg_StreamBoostMax_Video_Msg.TabIndex = 34;
            //
            // label18
            //
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Noto Sans TC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label18.Location = new System.Drawing.Point(3, 472);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(263, 26);
            this.label18.TabIndex = 33;
            this.label18.Text = "StreamBoostMax(影片) 輸出：";
            //
            // BtPreview_StreamBoostMax_Text
            //
            this.BtPreview_StreamBoostMax_Text.Font = new System.Drawing.Font("Noto Sans TC", 12F);
            this.BtPreview_StreamBoostMax_Text.Location = new System.Drawing.Point(631, 420);
            this.BtPreview_StreamBoostMax_Text.Name = "BtPreview_StreamBoostMax_Text";
            this.BtPreview_StreamBoostMax_Text.Size = new System.Drawing.Size(62, 35);
            this.BtPreview_StreamBoostMax_Text.TabIndex = 32;
            this.BtPreview_StreamBoostMax_Text.Text = "預覽";
            this.BtPreview_StreamBoostMax_Text.UseVisualStyleBackColor = true;
            this.BtPreview_StreamBoostMax_Text.Click += new System.EventHandler(this.BtPreview_StreamBoostMax_Text_Click);
            //
            // Tb_Msg_StreamBoostMax_Text_Msg
            //
            this.Tb_Msg_StreamBoostMax_Text_Msg.Font = new System.Drawing.Font("Noto Sans TC", 14F);
            this.Tb_Msg_StreamBoostMax_Text_Msg.Location = new System.Drawing.Point(174, 420);
            this.Tb_Msg_StreamBoostMax_Text_Msg.Name = "Tb_Msg_StreamBoostMax_Text_Msg";
            this.Tb_Msg_StreamBoostMax_Text_Msg.Size = new System.Drawing.Size(451, 48);
            this.Tb_Msg_StreamBoostMax_Text_Msg.TabIndex = 31;
            //
            // label17
            //
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Noto Sans TC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label17.Location = new System.Drawing.Point(3, 430);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(263, 26);
            this.label17.TabIndex = 30;
            this.label17.Text = "StreamBoostMax(訊息) 輸出：";
            //
            // BtPreview_SoundAlerts
            //
            this.BtPreview_SoundAlerts.Font = new System.Drawing.Font("Noto Sans TC", 12F);
            this.BtPreview_SoundAlerts.Location = new System.Drawing.Point(631, 379);
            this.BtPreview_SoundAlerts.Name = "BtPreview_SoundAlerts";
            this.BtPreview_SoundAlerts.Size = new System.Drawing.Size(62, 35);
            this.BtPreview_SoundAlerts.TabIndex = 29;
            this.BtPreview_SoundAlerts.Text = "預覽";
            this.BtPreview_SoundAlerts.UseVisualStyleBackColor = true;
            this.BtPreview_SoundAlerts.Click += new System.EventHandler(this.BtPreview_SoundAlerts_Click);
            //
            // Tb_Msg_SoundAlerts_Msg
            //
            this.Tb_Msg_SoundAlerts_Msg.Font = new System.Drawing.Font("Noto Sans TC", 14F);
            this.Tb_Msg_SoundAlerts_Msg.Location = new System.Drawing.Point(174, 379);
            this.Tb_Msg_SoundAlerts_Msg.Name = "Tb_Msg_SoundAlerts_Msg";
            this.Tb_Msg_SoundAlerts_Msg.Size = new System.Drawing.Size(451, 48);
            this.Tb_Msg_SoundAlerts_Msg.TabIndex = 28;
            //
            // label16
            //
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Noto Sans TC", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.Location = new System.Drawing.Point(37, 388);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(191, 29);
            this.label16.TabIndex = 27;
            this.label16.Text = "SoundAlerts 輸出：";
            //
            // BtPreview_Streamlabs_Resub
            //
            this.BtPreview_Streamlabs_Resub.Font = new System.Drawing.Font("Noto Sans TC", 12F);
            this.BtPreview_Streamlabs_Resub.Location = new System.Drawing.Point(631, 338);
            this.BtPreview_Streamlabs_Resub.Name = "BtPreview_Streamlabs_Resub";
            this.BtPreview_Streamlabs_Resub.Size = new System.Drawing.Size(62, 35);
            this.BtPreview_Streamlabs_Resub.TabIndex = 24;
            this.BtPreview_Streamlabs_Resub.Text = "預覽";
            this.BtPreview_Streamlabs_Resub.UseVisualStyleBackColor = true;
            this.BtPreview_Streamlabs_Resub.Click += new System.EventHandler(this.BtPreview_Streamlabs_Resub_Click);
            //
            // Tb_Msg_Streamlabs_Resub_Msg
            //
            this.Tb_Msg_Streamlabs_Resub_Msg.Font = new System.Drawing.Font("Noto Sans TC", 14F);
            this.Tb_Msg_Streamlabs_Resub_Msg.Location = new System.Drawing.Point(174, 338);
            this.Tb_Msg_Streamlabs_Resub_Msg.Name = "Tb_Msg_Streamlabs_Resub_Msg";
            this.Tb_Msg_Streamlabs_Resub_Msg.Size = new System.Drawing.Size(451, 48);
            this.Tb_Msg_Streamlabs_Resub_Msg.TabIndex = 25;
            //
            // label15
            //
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Noto Sans TC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(70, 341);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(163, 42);
            this.label15.TabIndex = 26;
            this.label15.Text = "續訂輸出：";
            //
            // BtPreview_Streamlabs_Sub
            //
            this.BtPreview_Streamlabs_Sub.Font = new System.Drawing.Font("Noto Sans TC", 12F);
            this.BtPreview_Streamlabs_Sub.Location = new System.Drawing.Point(631, 297);
            this.BtPreview_Streamlabs_Sub.Name = "BtPreview_Streamlabs_Sub";
            this.BtPreview_Streamlabs_Sub.Size = new System.Drawing.Size(62, 35);
            this.BtPreview_Streamlabs_Sub.TabIndex = 21;
            this.BtPreview_Streamlabs_Sub.Text = "預覽";
            this.BtPreview_Streamlabs_Sub.UseVisualStyleBackColor = true;
            this.BtPreview_Streamlabs_Sub.Click += new System.EventHandler(this.BtPreview_Streamlabs_Sub_Click);
            //
            // Tb_Msg_Streamlabs_Sub_Msg
            //
            this.Tb_Msg_Streamlabs_Sub_Msg.Font = new System.Drawing.Font("Noto Sans TC", 14F);
            this.Tb_Msg_Streamlabs_Sub_Msg.Location = new System.Drawing.Point(174, 297);
            this.Tb_Msg_Streamlabs_Sub_Msg.Name = "Tb_Msg_Streamlabs_Sub_Msg";
            this.Tb_Msg_Streamlabs_Sub_Msg.Size = new System.Drawing.Size(451, 48);
            this.Tb_Msg_Streamlabs_Sub_Msg.TabIndex = 22;
            //
            // label14
            //
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Noto Sans TC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(51, 300);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(192, 42);
            this.label14.TabIndex = 23;
            this.label14.Text = "新訂閱輸出：";
            //
            // BtPreview_HiveBee
            //
            this.BtPreview_HiveBee.Font = new System.Drawing.Font("Noto Sans TC", 12F);
            this.BtPreview_HiveBee.Location = new System.Drawing.Point(631, 146);
            this.BtPreview_HiveBee.Name = "BtPreview_HiveBee";
            this.BtPreview_HiveBee.Size = new System.Drawing.Size(62, 35);
            this.BtPreview_HiveBee.TabIndex = 20;
            this.BtPreview_HiveBee.Text = "預覽";
            this.BtPreview_HiveBee.UseVisualStyleBackColor = true;
            this.BtPreview_HiveBee.Click += new System.EventHandler(this.BtPreview_HiveBee_Click);
            //
            // Tb_Msg_HiveBee_Msg
            //
            this.Tb_Msg_HiveBee_Msg.Font = new System.Drawing.Font("Noto Sans TC", 14F);
            this.Tb_Msg_HiveBee_Msg.Location = new System.Drawing.Point(173, 146);
            this.Tb_Msg_HiveBee_Msg.Name = "Tb_Msg_HiveBee_Msg";
            this.Tb_Msg_HiveBee_Msg.Size = new System.Drawing.Size(451, 48);
            this.Tb_Msg_HiveBee_Msg.TabIndex = 19;
            //
            // label13
            //
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Noto Sans TC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(29, 149);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(222, 42);
            this.label13.TabIndex = 18;
            this.label13.Text = "HiveBee 輸出：";
            //
            // BtPreview_Streamlabs_Bits
            //
            this.BtPreview_Streamlabs_Bits.Font = new System.Drawing.Font("Noto Sans TC", 12F);
            this.BtPreview_Streamlabs_Bits.Location = new System.Drawing.Point(631, 256);
            this.BtPreview_Streamlabs_Bits.Name = "BtPreview_Streamlabs_Bits";
            this.BtPreview_Streamlabs_Bits.Size = new System.Drawing.Size(62, 35);
            this.BtPreview_Streamlabs_Bits.TabIndex = 17;
            this.BtPreview_Streamlabs_Bits.Text = "預覽";
            this.BtPreview_Streamlabs_Bits.UseVisualStyleBackColor = true;
            this.BtPreview_Streamlabs_Bits.Click += new System.EventHandler(this.BtPreview_Streamlabs_Bits_Click);
            //
            // BtPreview_Streamlabs_SubGift
            //
            this.BtPreview_Streamlabs_SubGift.Font = new System.Drawing.Font("Noto Sans TC", 12F);
            this.BtPreview_Streamlabs_SubGift.Location = new System.Drawing.Point(631, 215);
            this.BtPreview_Streamlabs_SubGift.Name = "BtPreview_Streamlabs_SubGift";
            this.BtPreview_Streamlabs_SubGift.Size = new System.Drawing.Size(62, 35);
            this.BtPreview_Streamlabs_SubGift.TabIndex = 16;
            this.BtPreview_Streamlabs_SubGift.Text = "預覽";
            this.BtPreview_Streamlabs_SubGift.UseVisualStyleBackColor = true;
            this.BtPreview_Streamlabs_SubGift.Click += new System.EventHandler(this.BtPreview_Streamlabs_SubGift_Click);
            //
            // BtPreview_Streamlabs_Paypal
            //
            this.BtPreview_Streamlabs_Paypal.Font = new System.Drawing.Font("Noto Sans TC", 12F);
            this.BtPreview_Streamlabs_Paypal.Location = new System.Drawing.Point(631, 105);
            this.BtPreview_Streamlabs_Paypal.Name = "BtPreview_Streamlabs_Paypal";
            this.BtPreview_Streamlabs_Paypal.Size = new System.Drawing.Size(62, 35);
            this.BtPreview_Streamlabs_Paypal.TabIndex = 15;
            this.BtPreview_Streamlabs_Paypal.Text = "預覽";
            this.BtPreview_Streamlabs_Paypal.UseVisualStyleBackColor = true;
            this.BtPreview_Streamlabs_Paypal.Click += new System.EventHandler(this.BtPreview_Streamlabs_Paypal_Click);
            //
            // BtPreview_OPay
            //
            this.BtPreview_OPay.Font = new System.Drawing.Font("Noto Sans TC", 12F);
            this.BtPreview_OPay.Location = new System.Drawing.Point(630, 65);
            this.BtPreview_OPay.Name = "BtPreview_OPay";
            this.BtPreview_OPay.Size = new System.Drawing.Size(62, 35);
            this.BtPreview_OPay.TabIndex = 14;
            this.BtPreview_OPay.Text = "預覽";
            this.BtPreview_OPay.UseVisualStyleBackColor = true;
            this.BtPreview_OPay.Click += new System.EventHandler(this.BtPreview_OPay_Click);
            //
            // BtPreview_ECPay
            //
            this.BtPreview_ECPay.Font = new System.Drawing.Font("Noto Sans TC", 12F);
            this.BtPreview_ECPay.Location = new System.Drawing.Point(630, 23);
            this.BtPreview_ECPay.Name = "BtPreview_ECPay";
            this.BtPreview_ECPay.Size = new System.Drawing.Size(62, 35);
            this.BtPreview_ECPay.TabIndex = 13;
            this.BtPreview_ECPay.Text = "預覽";
            this.BtPreview_ECPay.UseVisualStyleBackColor = true;
            this.BtPreview_ECPay.Click += new System.EventHandler(this.BtPreview_ECPay_Click);
            //
            // Tb_Msg_Streamlabs_Bits_Msg
            //
            this.Tb_Msg_Streamlabs_Bits_Msg.Font = new System.Drawing.Font("Noto Sans TC", 14F);
            this.Tb_Msg_Streamlabs_Bits_Msg.Location = new System.Drawing.Point(174, 256);
            this.Tb_Msg_Streamlabs_Bits_Msg.Name = "Tb_Msg_Streamlabs_Bits_Msg";
            this.Tb_Msg_Streamlabs_Bits_Msg.Size = new System.Drawing.Size(451, 48);
            this.Tb_Msg_Streamlabs_Bits_Msg.TabIndex = 12;
            //
            // label6
            //
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Noto Sans TC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(51, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 42);
            this.label6.TabIndex = 11;
            this.label6.Text = "小奇點輸出：";
            //
            // Tb_Msg_Streamlabs_SubGift_Msg
            //
            this.Tb_Msg_Streamlabs_SubGift_Msg.Font = new System.Drawing.Font("Noto Sans TC", 14F);
            this.Tb_Msg_Streamlabs_SubGift_Msg.Location = new System.Drawing.Point(174, 215);
            this.Tb_Msg_Streamlabs_SubGift_Msg.Name = "Tb_Msg_Streamlabs_SubGift_Msg";
            this.Tb_Msg_Streamlabs_SubGift_Msg.Size = new System.Drawing.Size(451, 48);
            this.Tb_Msg_Streamlabs_SubGift_Msg.TabIndex = 10;
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Noto Sans TC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(70, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 42);
            this.label5.TabIndex = 9;
            this.label5.Text = "贈訂輸出：";
            //
            // Tb_Msg_Streamlabs_Paypal_Msg
            //
            this.Tb_Msg_Streamlabs_Paypal_Msg.Font = new System.Drawing.Font("Noto Sans TC", 14F);
            this.Tb_Msg_Streamlabs_Paypal_Msg.Location = new System.Drawing.Point(173, 105);
            this.Tb_Msg_Streamlabs_Paypal_Msg.Name = "Tb_Msg_Streamlabs_Paypal_Msg";
            this.Tb_Msg_Streamlabs_Paypal_Msg.Size = new System.Drawing.Size(451, 48);
            this.Tb_Msg_Streamlabs_Paypal_Msg.TabIndex = 8;
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Noto Sans TC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(43, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 42);
            this.label4.TabIndex = 7;
            this.label4.Text = "Paypal 輸出：";
            //
            // Tb_Msg_OPay_Msg
            //
            this.Tb_Msg_OPay_Msg.Font = new System.Drawing.Font("Noto Sans TC", 14F);
            this.Tb_Msg_OPay_Msg.Location = new System.Drawing.Point(173, 64);
            this.Tb_Msg_OPay_Msg.Name = "Tb_Msg_OPay_Msg";
            this.Tb_Msg_OPay_Msg.Size = new System.Drawing.Size(451, 48);
            this.Tb_Msg_OPay_Msg.TabIndex = 6;
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans TC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(50, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 42);
            this.label3.TabIndex = 5;
            this.label3.Text = "歐富寶輸出：";
            //
            // Tb_Msg_ECPay_Msg
            //
            this.Tb_Msg_ECPay_Msg.Font = new System.Drawing.Font("Noto Sans TC", 14F);
            this.Tb_Msg_ECPay_Msg.Location = new System.Drawing.Point(173, 23);
            this.Tb_Msg_ECPay_Msg.Name = "Tb_Msg_ECPay_Msg";
            this.Tb_Msg_ECPay_Msg.Size = new System.Drawing.Size(451, 48);
            this.Tb_Msg_ECPay_Msg.TabIndex = 4;
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans TC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(69, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "綠界輸出：";
            //
            // Bt_Save
            //
            this.Bt_Save.Font = new System.Drawing.Font("Noto Sans TC", 14F);
            this.Bt_Save.Location = new System.Drawing.Point(12, 624);
            this.Bt_Save.Name = "Bt_Save";
            this.Bt_Save.Size = new System.Drawing.Size(699, 46);
            this.Bt_Save.TabIndex = 5;
            this.Bt_Save.Text = "保 存";
            this.Bt_Save.UseVisualStyleBackColor = true;
            this.Bt_Save.Click += new System.EventHandler(this.Bt_Save_Click);
            //
            // tabPage3
            //
            this.tabPage3.Controls.Add(this.Tb_Msg_Custom_Sub_Tier3);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.Tb_Msg_Custom_Sub_Tier2);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.Tb_Msg_Custom_Sub_Tier1);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.Tb_Msg_Custom_Bits);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.Tb_Msg_Custom_Sub_Gift);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.Tb_Msg_Custom_Anon);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 36);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(691, 560);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "別稱設定";
            this.tabPage3.UseVisualStyleBackColor = true;
            //
            // Tb_Msg_Custom_Sub_Tier3
            //
            this.Tb_Msg_Custom_Sub_Tier3.Font = new System.Drawing.Font("Noto Sans TC", 14F);
            this.Tb_Msg_Custom_Sub_Tier3.Location = new System.Drawing.Point(466, 148);
            this.Tb_Msg_Custom_Sub_Tier3.Name = "Tb_Msg_Custom_Sub_Tier3";
            this.Tb_Msg_Custom_Sub_Tier3.Size = new System.Drawing.Size(226, 48);
            this.Tb_Msg_Custom_Sub_Tier3.TabIndex = 24;
            //
            // label12
            //
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Noto Sans TC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(381, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 42);
            this.label12.TabIndex = 23;
            this.label12.Text = "層級三：";
            //
            // Tb_Msg_Custom_Sub_Tier2
            //
            this.Tb_Msg_Custom_Sub_Tier2.Font = new System.Drawing.Font("Noto Sans TC", 14F);
            this.Tb_Msg_Custom_Sub_Tier2.Location = new System.Drawing.Point(466, 107);
            this.Tb_Msg_Custom_Sub_Tier2.Name = "Tb_Msg_Custom_Sub_Tier2";
            this.Tb_Msg_Custom_Sub_Tier2.Size = new System.Drawing.Size(226, 48);
            this.Tb_Msg_Custom_Sub_Tier2.TabIndex = 22;
            //
            // label11
            //
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Noto Sans TC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(381, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 42);
            this.label11.TabIndex = 21;
            this.label11.Text = "層級二：";
            //
            // Tb_Msg_Custom_Sub_Tier1
            //
            this.Tb_Msg_Custom_Sub_Tier1.Font = new System.Drawing.Font("Noto Sans TC", 14F);
            this.Tb_Msg_Custom_Sub_Tier1.Location = new System.Drawing.Point(466, 66);
            this.Tb_Msg_Custom_Sub_Tier1.Name = "Tb_Msg_Custom_Sub_Tier1";
            this.Tb_Msg_Custom_Sub_Tier1.Size = new System.Drawing.Size(226, 48);
            this.Tb_Msg_Custom_Sub_Tier1.TabIndex = 20;
            //
            // label10
            //
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Noto Sans TC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(381, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 42);
            this.label10.TabIndex = 19;
            this.label10.Text = "層級一：";
            //
            // Tb_Msg_Custom_Bits
            //
            this.Tb_Msg_Custom_Bits.Font = new System.Drawing.Font("Noto Sans TC", 14F);
            this.Tb_Msg_Custom_Bits.Location = new System.Drawing.Point(90, 66);
            this.Tb_Msg_Custom_Bits.Name = "Tb_Msg_Custom_Bits";
            this.Tb_Msg_Custom_Bits.Size = new System.Drawing.Size(266, 48);
            this.Tb_Msg_Custom_Bits.TabIndex = 18;
            //
            // label9
            //
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Noto Sans TC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(6, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 42);
            this.label9.TabIndex = 17;
            this.label9.Text = "小奇點：";
            //
            // Tb_Msg_Custom_Sub_Gift
            //
            this.Tb_Msg_Custom_Sub_Gift.Font = new System.Drawing.Font("Noto Sans TC", 14F);
            this.Tb_Msg_Custom_Sub_Gift.Location = new System.Drawing.Point(466, 25);
            this.Tb_Msg_Custom_Sub_Gift.Name = "Tb_Msg_Custom_Sub_Gift";
            this.Tb_Msg_Custom_Sub_Gift.Size = new System.Drawing.Size(226, 48);
            this.Tb_Msg_Custom_Sub_Gift.TabIndex = 16;
            //
            // label8
            //
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Noto Sans TC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(362, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 42);
            this.label8.TabIndex = 15;
            this.label8.Text = "贈禮訂閱：";
            //
            // Tb_Msg_Custom_Anon
            //
            this.Tb_Msg_Custom_Anon.Font = new System.Drawing.Font("Noto Sans TC", 14F);
            this.Tb_Msg_Custom_Anon.Location = new System.Drawing.Point(73, 25);
            this.Tb_Msg_Custom_Anon.Name = "Tb_Msg_Custom_Anon";
            this.Tb_Msg_Custom_Anon.Size = new System.Drawing.Size(283, 48);
            this.Tb_Msg_Custom_Anon.TabIndex = 14;
            //
            // label7
            //
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Noto Sans TC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(6, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 42);
            this.label7.TabIndex = 13;
            this.label7.Text = "匿名：";
            //
            // BtReset
            //
            this.BtReset.Font = new System.Drawing.Font("Noto Sans TC", 14F);
            this.BtReset.Location = new System.Drawing.Point(12, 676);
            this.BtReset.Name = "BtReset";
            this.BtReset.Size = new System.Drawing.Size(699, 46);
            this.BtReset.TabIndex = 7;
            this.BtReset.Text = "重置設定";
            this.BtReset.UseVisualStyleBackColor = true;
            this.BtReset.Click += new System.EventHandler(this.BtReset_Click);
            //
            // Config
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 731);
            this.Controls.Add(this.BtReset);
            this.Controls.Add(this.Bt_Save);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Noto Sans TC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Config";
            ((System.ComponentModel.ISupportInitialize)(this.Nud_MinBitsAmount)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RBt_ObsOutputMode_Single;
        private System.Windows.Forms.RadioButton RBt_ObsOutputMode_NextLine;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tb_Msg_ECPay_Msg;
        private System.Windows.Forms.Button Bt_Save;
        private System.Windows.Forms.TextBox Tb_Msg_OPay_Msg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tb_Msg_Streamlabs_Paypal_Msg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Tb_Msg_Streamlabs_SubGift_Msg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tb_Msg_Streamlabs_Bits_Msg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Tb_Msg_Custom_Anon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Tb_Msg_Custom_Sub_Gift;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Tb_Msg_Custom_Bits;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Tb_Msg_Custom_Sub_Tier3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Tb_Msg_Custom_Sub_Tier2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Tb_Msg_Custom_Sub_Tier1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtReset;
        private System.Windows.Forms.Button BtPreview_ECPay;
        private System.Windows.Forms.Button BtPreview_OPay;
        private System.Windows.Forms.Button BtPreview_Streamlabs_Paypal;
        private System.Windows.Forms.Button BtPreview_Streamlabs_SubGift;
        private System.Windows.Forms.Button BtPreview_Streamlabs_Bits;
        private System.Windows.Forms.Button BtPreview_HiveBee;
        private System.Windows.Forms.TextBox Tb_Msg_HiveBee_Msg;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox Cb_EnableSubOutput;
        private System.Windows.Forms.CheckBox Cb_EnableResubOutput;
        private System.Windows.Forms.CheckBox Cb_EnableStartupCheckOldData;
        private System.Windows.Forms.Label label_MinBitsAmount;
        private System.Windows.Forms.NumericUpDown Nud_MinBitsAmount;
        private System.Windows.Forms.Button BtPreview_Streamlabs_Sub;
        private System.Windows.Forms.TextBox Tb_Msg_Streamlabs_Sub_Msg;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button BtPreview_Streamlabs_Resub;
        private System.Windows.Forms.TextBox Tb_Msg_Streamlabs_Resub_Msg;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button BtPreview_SoundAlerts;
        private System.Windows.Forms.TextBox Tb_Msg_SoundAlerts_Msg;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button BtPreview_StreamBoostMax_Text;
        private System.Windows.Forms.TextBox Tb_Msg_StreamBoostMax_Text_Msg;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button BtPreview_StreamBoostMax_Video;
        private System.Windows.Forms.TextBox Tb_Msg_StreamBoostMax_Video_Msg;
        private System.Windows.Forms.Label label18;
    }
}
