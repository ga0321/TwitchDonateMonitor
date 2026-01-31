namespace DonateMonitor
{
    partial class AddDonateRecord
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.LbDateTime = new System.Windows.Forms.Label();
            this.TbDateTime = new System.Windows.Forms.TextBox();
            this.LbType = new System.Windows.Forms.Label();
            this.CbType = new System.Windows.Forms.ComboBox();
            this.LbAccount = new System.Windows.Forms.Label();
            this.TbAccount = new System.Windows.Forms.TextBox();
            this.LbDisplayName = new System.Windows.Forms.Label();
            this.TbDisplayName = new System.Windows.Forms.TextBox();
            this.LbAmount = new System.Windows.Forms.Label();
            this.TbAmount = new System.Windows.Forms.TextBox();
            this.LbCurrency = new System.Windows.Forms.Label();
            this.TbCurrency = new System.Windows.Forms.TextBox();
            this.LbMessage = new System.Windows.Forms.Label();
            this.TbMessage = new System.Windows.Forms.TextBox();
            this.LbSubPlan = new System.Windows.Forms.Label();
            this.TbSubPlan = new System.Windows.Forms.TextBox();
            this.BtOK = new System.Windows.Forms.Button();
            this.BtCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // LbDateTime
            //
            this.LbDateTime.AutoSize = true;
            this.LbDateTime.Font = new System.Drawing.Font("Noto Sans TC", 12F);
            this.LbDateTime.Location = new System.Drawing.Point(20, 20);
            this.LbDateTime.Name = "LbDateTime";
            this.LbDateTime.Size = new System.Drawing.Size(52, 29);
            this.LbDateTime.TabIndex = 0;
            this.LbDateTime.Text = "時間";
            //
            // TbDateTime
            //
            this.TbDateTime.Font = new System.Drawing.Font("Noto Sans TC", 12F);
            this.TbDateTime.Location = new System.Drawing.Point(100, 17);
            this.TbDateTime.Name = "TbDateTime";
            this.TbDateTime.Size = new System.Drawing.Size(280, 32);
            this.TbDateTime.TabIndex = 1;
            //
            // LbType
            //
            this.LbType.AutoSize = true;
            this.LbType.Font = new System.Drawing.Font("Noto Sans TC", 12F);
            this.LbType.Location = new System.Drawing.Point(20, 60);
            this.LbType.Name = "LbType";
            this.LbType.Size = new System.Drawing.Size(52, 29);
            this.LbType.TabIndex = 2;
            this.LbType.Text = "類型";
            //
            // CbType
            //
            this.CbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbType.Font = new System.Drawing.Font("Noto Sans TC", 12F);
            this.CbType.FormattingEnabled = true;
            this.CbType.Location = new System.Drawing.Point(100, 57);
            this.CbType.Name = "CbType";
            this.CbType.Size = new System.Drawing.Size(280, 37);
            this.CbType.TabIndex = 3;
            //
            // LbAccount
            //
            this.LbAccount.AutoSize = true;
            this.LbAccount.Font = new System.Drawing.Font("Noto Sans TC", 12F);
            this.LbAccount.Location = new System.Drawing.Point(20, 105);
            this.LbAccount.Name = "LbAccount";
            this.LbAccount.Size = new System.Drawing.Size(52, 29);
            this.LbAccount.TabIndex = 4;
            this.LbAccount.Text = "帳號";
            //
            // TbAccount
            //
            this.TbAccount.Font = new System.Drawing.Font("Noto Sans TC", 12F);
            this.TbAccount.Location = new System.Drawing.Point(100, 102);
            this.TbAccount.Name = "TbAccount";
            this.TbAccount.Size = new System.Drawing.Size(280, 32);
            this.TbAccount.TabIndex = 5;
            //
            // LbDisplayName
            //
            this.LbDisplayName.AutoSize = true;
            this.LbDisplayName.Font = new System.Drawing.Font("Noto Sans TC", 12F);
            this.LbDisplayName.Location = new System.Drawing.Point(20, 145);
            this.LbDisplayName.Name = "LbDisplayName";
            this.LbDisplayName.Size = new System.Drawing.Size(52, 29);
            this.LbDisplayName.TabIndex = 6;
            this.LbDisplayName.Text = "名稱";
            //
            // TbDisplayName
            //
            this.TbDisplayName.Font = new System.Drawing.Font("Noto Sans TC", 12F);
            this.TbDisplayName.Location = new System.Drawing.Point(100, 142);
            this.TbDisplayName.Name = "TbDisplayName";
            this.TbDisplayName.Size = new System.Drawing.Size(280, 32);
            this.TbDisplayName.TabIndex = 7;
            //
            // LbAmount
            //
            this.LbAmount.AutoSize = true;
            this.LbAmount.Font = new System.Drawing.Font("Noto Sans TC", 12F);
            this.LbAmount.Location = new System.Drawing.Point(20, 185);
            this.LbAmount.Name = "LbAmount";
            this.LbAmount.Size = new System.Drawing.Size(52, 29);
            this.LbAmount.TabIndex = 8;
            this.LbAmount.Text = "金額";
            //
            // TbAmount
            //
            this.TbAmount.Font = new System.Drawing.Font("Noto Sans TC", 12F);
            this.TbAmount.Location = new System.Drawing.Point(100, 182);
            this.TbAmount.Name = "TbAmount";
            this.TbAmount.Size = new System.Drawing.Size(130, 32);
            this.TbAmount.TabIndex = 9;
            this.TbAmount.Text = "0";
            //
            // LbCurrency
            //
            this.LbCurrency.AutoSize = true;
            this.LbCurrency.Font = new System.Drawing.Font("Noto Sans TC", 12F);
            this.LbCurrency.Location = new System.Drawing.Point(240, 185);
            this.LbCurrency.Name = "LbCurrency";
            this.LbCurrency.Size = new System.Drawing.Size(52, 29);
            this.LbCurrency.TabIndex = 10;
            this.LbCurrency.Text = "幣別";
            //
            // TbCurrency
            //
            this.TbCurrency.Font = new System.Drawing.Font("Noto Sans TC", 12F);
            this.TbCurrency.Location = new System.Drawing.Point(300, 182);
            this.TbCurrency.Name = "TbCurrency";
            this.TbCurrency.Size = new System.Drawing.Size(80, 32);
            this.TbCurrency.TabIndex = 11;
            //
            // LbMessage
            //
            this.LbMessage.AutoSize = true;
            this.LbMessage.Font = new System.Drawing.Font("Noto Sans TC", 12F);
            this.LbMessage.Location = new System.Drawing.Point(20, 225);
            this.LbMessage.Name = "LbMessage";
            this.LbMessage.Size = new System.Drawing.Size(52, 29);
            this.LbMessage.TabIndex = 12;
            this.LbMessage.Text = "訊息";
            //
            // TbMessage
            //
            this.TbMessage.Font = new System.Drawing.Font("Noto Sans TC", 12F);
            this.TbMessage.Location = new System.Drawing.Point(100, 222);
            this.TbMessage.Name = "TbMessage";
            this.TbMessage.Size = new System.Drawing.Size(280, 32);
            this.TbMessage.TabIndex = 13;
            //
            // LbSubPlan
            //
            this.LbSubPlan.AutoSize = true;
            this.LbSubPlan.Font = new System.Drawing.Font("Noto Sans TC", 12F);
            this.LbSubPlan.Location = new System.Drawing.Point(20, 265);
            this.LbSubPlan.Name = "LbSubPlan";
            this.LbSubPlan.Size = new System.Drawing.Size(52, 29);
            this.LbSubPlan.TabIndex = 14;
            this.LbSubPlan.Text = "方案";
            //
            // TbSubPlan
            //
            this.TbSubPlan.Font = new System.Drawing.Font("Noto Sans TC", 12F);
            this.TbSubPlan.Location = new System.Drawing.Point(100, 262);
            this.TbSubPlan.Name = "TbSubPlan";
            this.TbSubPlan.Size = new System.Drawing.Size(280, 32);
            this.TbSubPlan.TabIndex = 15;
            //
            // BtOK
            //
            this.BtOK.Font = new System.Drawing.Font("Noto Sans TC", 12F);
            this.BtOK.Location = new System.Drawing.Point(100, 310);
            this.BtOK.Name = "BtOK";
            this.BtOK.Size = new System.Drawing.Size(100, 40);
            this.BtOK.TabIndex = 16;
            this.BtOK.Text = "確定";
            this.BtOK.UseVisualStyleBackColor = true;
            this.BtOK.Click += new System.EventHandler(this.BtOK_Click);
            //
            // BtCancel
            //
            this.BtCancel.Font = new System.Drawing.Font("Noto Sans TC", 12F);
            this.BtCancel.Location = new System.Drawing.Point(220, 310);
            this.BtCancel.Name = "BtCancel";
            this.BtCancel.Size = new System.Drawing.Size(100, 40);
            this.BtCancel.TabIndex = 17;
            this.BtCancel.Text = "取消";
            this.BtCancel.UseVisualStyleBackColor = true;
            this.BtCancel.Click += new System.EventHandler(this.BtCancel_Click);
            //
            // AddDonateRecord
            //
            this.AcceptButton = this.BtOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtCancel;
            this.ClientSize = new System.Drawing.Size(400, 370);
            this.Controls.Add(this.BtCancel);
            this.Controls.Add(this.BtOK);
            this.Controls.Add(this.TbSubPlan);
            this.Controls.Add(this.LbSubPlan);
            this.Controls.Add(this.TbMessage);
            this.Controls.Add(this.LbMessage);
            this.Controls.Add(this.TbCurrency);
            this.Controls.Add(this.LbCurrency);
            this.Controls.Add(this.TbAmount);
            this.Controls.Add(this.LbAmount);
            this.Controls.Add(this.TbDisplayName);
            this.Controls.Add(this.LbDisplayName);
            this.Controls.Add(this.TbAccount);
            this.Controls.Add(this.LbAccount);
            this.Controls.Add(this.CbType);
            this.Controls.Add(this.LbType);
            this.Controls.Add(this.TbDateTime);
            this.Controls.Add(this.LbDateTime);
            this.Font = new System.Drawing.Font("Noto Sans TC", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDonateRecord";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "新增資料";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label LbDateTime;
        private System.Windows.Forms.TextBox TbDateTime;
        private System.Windows.Forms.Label LbType;
        private System.Windows.Forms.ComboBox CbType;
        private System.Windows.Forms.Label LbAccount;
        private System.Windows.Forms.TextBox TbAccount;
        private System.Windows.Forms.Label LbDisplayName;
        private System.Windows.Forms.TextBox TbDisplayName;
        private System.Windows.Forms.Label LbAmount;
        private System.Windows.Forms.TextBox TbAmount;
        private System.Windows.Forms.Label LbCurrency;
        private System.Windows.Forms.TextBox TbCurrency;
        private System.Windows.Forms.Label LbMessage;
        private System.Windows.Forms.TextBox TbMessage;
        private System.Windows.Forms.Label LbSubPlan;
        private System.Windows.Forms.TextBox TbSubPlan;
        private System.Windows.Forms.Button BtOK;
        private System.Windows.Forms.Button BtCancel;
    }
}
