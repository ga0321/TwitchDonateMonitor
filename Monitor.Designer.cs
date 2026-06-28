namespace DonateMonitor
{
    partial class Monitor
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
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMonitor = new System.Windows.Forms.TabPage();
            this.lbECPAY_Status = new System.Windows.Forms.Label();
            this.lbOPAY_Status = new System.Windows.Forms.Label();
            this.lbHiveBee_Status = new System.Windows.Forms.Label();
            this.lbStreamlabs_Status = new System.Windows.Forms.Label();
            this.lbSoundAlerts_Status = new System.Windows.Forms.Label();
            this.lbStreamBoostMax_Text_Status = new System.Windows.Forms.Label();
            this.lbStreamBoostMax_Video_Status = new System.Windows.Forms.Label();
            this.Tb_MonitorOut = new System.Windows.Forms.TextBox();
            this.BtConfig = new System.Windows.Forms.Button();
            this.BtClearDonateDB = new System.Windows.Forms.Button();
            this.tabData = new System.Windows.Forms.TabPage();
            this.dgvDonateData = new System.Windows.Forms.DataGridView();
            this.BtRefreshData = new System.Windows.Forms.Button();
            this.BtAddData = new System.Windows.Forms.Button();
            this.BtDeleteSelected = new System.Windows.Forms.Button();
            this.cmsAmount = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAddAmount = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl.SuspendLayout();
            this.tabMonitor.SuspendLayout();
            this.tabData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonateData)).BeginInit();
            this.cmsAmount.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabMonitor);
            this.tabControl.Controls.Add(this.tabData);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Noto Sans TC", 10F);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(945, 692);
            this.tabControl.TabIndex = 0;
            // 
            // tabMonitor
            // 
            this.tabMonitor.Controls.Add(this.lbECPAY_Status);
            this.tabMonitor.Controls.Add(this.lbOPAY_Status);
            this.tabMonitor.Controls.Add(this.lbHiveBee_Status);
            this.tabMonitor.Controls.Add(this.lbStreamlabs_Status);
            this.tabMonitor.Controls.Add(this.lbSoundAlerts_Status);
            this.tabMonitor.Controls.Add(this.lbStreamBoostMax_Text_Status);
            this.tabMonitor.Controls.Add(this.lbStreamBoostMax_Video_Status);
            this.tabMonitor.Controls.Add(this.Tb_MonitorOut);
            this.tabMonitor.Controls.Add(this.BtConfig);
            this.tabMonitor.Controls.Add(this.BtClearDonateDB);
            this.tabMonitor.Location = new System.Drawing.Point(4, 38);
            this.tabMonitor.Name = "tabMonitor";
            this.tabMonitor.Padding = new System.Windows.Forms.Padding(3);
            this.tabMonitor.Size = new System.Drawing.Size(937, 650);
            this.tabMonitor.TabIndex = 0;
            this.tabMonitor.Text = "監控";
            this.tabMonitor.UseVisualStyleBackColor = true;
            // 
            // lbECPAY_Status
            // 
            this.lbECPAY_Status.AutoSize = true;
            this.lbECPAY_Status.Font = new System.Drawing.Font("Noto Sans TC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbECPAY_Status.Location = new System.Drawing.Point(6, 3);
            this.lbECPAY_Status.Name = "lbECPAY_Status";
            this.lbECPAY_Status.Size = new System.Drawing.Size(213, 40);
            this.lbECPAY_Status.TabIndex = 1;
            this.lbECPAY_Status.Text = "綠界狀態：無效";
            // 
            // lbOPAY_Status
            // 
            this.lbOPAY_Status.AutoSize = true;
            this.lbOPAY_Status.Font = new System.Drawing.Font("Noto Sans TC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbOPAY_Status.Location = new System.Drawing.Point(6, 30);
            this.lbOPAY_Status.Name = "lbOPAY_Status";
            this.lbOPAY_Status.Size = new System.Drawing.Size(241, 40);
            this.lbOPAY_Status.TabIndex = 4;
            this.lbOPAY_Status.Text = "歐富寶狀態：無效";
            // 
            // lbHiveBee_Status
            // 
            this.lbHiveBee_Status.AutoSize = true;
            this.lbHiveBee_Status.Font = new System.Drawing.Font("Noto Sans TC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbHiveBee_Status.Location = new System.Drawing.Point(6, 57);
            this.lbHiveBee_Status.Name = "lbHiveBee_Status";
            this.lbHiveBee_Status.Size = new System.Drawing.Size(272, 40);
            this.lbHiveBee_Status.TabIndex = 6;
            this.lbHiveBee_Status.Text = "HiveBee 狀態：無效";
            // 
            // lbStreamlabs_Status
            // 
            this.lbStreamlabs_Status.AutoSize = true;
            this.lbStreamlabs_Status.Font = new System.Drawing.Font("Noto Sans TC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbStreamlabs_Status.Location = new System.Drawing.Point(6, 84);
            this.lbStreamlabs_Status.Name = "lbStreamlabs_Status";
            this.lbStreamlabs_Status.Size = new System.Drawing.Size(312, 40);
            this.lbStreamlabs_Status.TabIndex = 5;
            this.lbStreamlabs_Status.Text = "Streamlabs 狀態：無效";
            // 
            // lbSoundAlerts_Status
            // 
            this.lbSoundAlerts_Status.AutoSize = true;
            this.lbSoundAlerts_Status.Font = new System.Drawing.Font("Noto Sans TC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbSoundAlerts_Status.Location = new System.Drawing.Point(6, 111);
            this.lbSoundAlerts_Status.Name = "lbSoundAlerts_Status";
            this.lbSoundAlerts_Status.Size = new System.Drawing.Size(324, 40);
            this.lbSoundAlerts_Status.TabIndex = 8;
            this.lbSoundAlerts_Status.Text = "SoundAlerts 狀態：無效";
            // 
            // lbStreamBoostMax_Text_Status
            // 
            this.lbStreamBoostMax_Text_Status.AutoSize = true;
            this.lbStreamBoostMax_Text_Status.Font = new System.Drawing.Font("Noto Sans TC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbStreamBoostMax_Text_Status.Location = new System.Drawing.Point(280, 3);
            this.lbStreamBoostMax_Text_Status.Name = "lbStreamBoostMax_Text_Status";
            this.lbStreamBoostMax_Text_Status.Size = new System.Drawing.Size(460, 40);
            this.lbStreamBoostMax_Text_Status.TabIndex = 9;
            this.lbStreamBoostMax_Text_Status.Text = "StreamBoostMax(訊息) 狀態：無效";
            this.lbStreamBoostMax_Text_Status.Visible = false;
            // 
            // lbStreamBoostMax_Video_Status
            // 
            this.lbStreamBoostMax_Video_Status.AutoSize = true;
            this.lbStreamBoostMax_Video_Status.Font = new System.Drawing.Font("Noto Sans TC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbStreamBoostMax_Video_Status.Location = new System.Drawing.Point(280, 38);
            this.lbStreamBoostMax_Video_Status.Name = "lbStreamBoostMax_Video_Status";
            this.lbStreamBoostMax_Video_Status.Size = new System.Drawing.Size(460, 40);
            this.lbStreamBoostMax_Video_Status.TabIndex = 10;
            this.lbStreamBoostMax_Video_Status.Text = "StreamBoostMax(影片) 狀態：無效";
            this.lbStreamBoostMax_Video_Status.Visible = false;
            // 
            // Tb_MonitorOut
            // 
            this.Tb_MonitorOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tb_MonitorOut.Font = new System.Drawing.Font("Noto Sans TC", 14F);
            this.Tb_MonitorOut.Location = new System.Drawing.Point(6, 141);
            this.Tb_MonitorOut.Multiline = true;
            this.Tb_MonitorOut.Name = "Tb_MonitorOut";
            this.Tb_MonitorOut.ReadOnly = true;
            this.Tb_MonitorOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Tb_MonitorOut.Size = new System.Drawing.Size(925, 509);
            this.Tb_MonitorOut.TabIndex = 2;
            // 
            // BtConfig
            // 
            this.BtConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtConfig.Location = new System.Drawing.Point(856, 3);
            this.BtConfig.Name = "BtConfig";
            this.BtConfig.Size = new System.Drawing.Size(75, 33);
            this.BtConfig.TabIndex = 3;
            this.BtConfig.Text = "設 定";
            this.BtConfig.UseVisualStyleBackColor = true;
            this.BtConfig.Click += new System.EventHandler(this.BtConfig_Click);
            // 
            // BtClearDonateDB
            // 
            this.BtClearDonateDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtClearDonateDB.Location = new System.Drawing.Point(738, 3);
            this.BtClearDonateDB.Name = "BtClearDonateDB";
            this.BtClearDonateDB.Size = new System.Drawing.Size(112, 33);
            this.BtClearDonateDB.TabIndex = 7;
            this.BtClearDonateDB.Text = "清除所有累計";
            this.BtClearDonateDB.UseVisualStyleBackColor = true;
            this.BtClearDonateDB.Click += new System.EventHandler(this.BtClearDonateDB_Click);
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.dgvDonateData);
            this.tabData.Controls.Add(this.BtRefreshData);
            this.tabData.Controls.Add(this.BtAddData);
            this.tabData.Controls.Add(this.BtDeleteSelected);
            this.tabData.Location = new System.Drawing.Point(4, 38);
            this.tabData.Name = "tabData";
            this.tabData.Padding = new System.Windows.Forms.Padding(3);
            this.tabData.Size = new System.Drawing.Size(937, 650);
            this.tabData.TabIndex = 1;
            this.tabData.Text = "資料管理";
            this.tabData.UseVisualStyleBackColor = true;
            // 
            // dgvDonateData
            // 
            this.dgvDonateData.AllowUserToAddRows = false;
            this.dgvDonateData.AllowUserToDeleteRows = false;
            this.dgvDonateData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDonateData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDonateData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonateData.Location = new System.Drawing.Point(6, 45);
            this.dgvDonateData.Name = "dgvDonateData";
            this.dgvDonateData.RowHeadersWidth = 51;
            this.dgvDonateData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonateData.Size = new System.Drawing.Size(925, 605);
            this.dgvDonateData.TabIndex = 0;
            this.dgvDonateData.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvDonateData_CellMouseClick);
            this.dgvDonateData.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDonateData_CellValueChanged);
            this.dgvDonateData.CurrentCellDirtyStateChanged += new System.EventHandler(this.DgvDonateData_CurrentCellDirtyStateChanged);
            // 
            // BtRefreshData
            // 
            this.BtRefreshData.Location = new System.Drawing.Point(6, 6);
            this.BtRefreshData.Name = "BtRefreshData";
            this.BtRefreshData.Size = new System.Drawing.Size(100, 33);
            this.BtRefreshData.TabIndex = 1;
            this.BtRefreshData.Text = "重新載入";
            this.BtRefreshData.UseVisualStyleBackColor = true;
            this.BtRefreshData.Click += new System.EventHandler(this.BtRefreshData_Click);
            // 
            // BtAddData
            // 
            this.BtAddData.Location = new System.Drawing.Point(112, 6);
            this.BtAddData.Name = "BtAddData";
            this.BtAddData.Size = new System.Drawing.Size(100, 33);
            this.BtAddData.TabIndex = 2;
            this.BtAddData.Text = "新增";
            this.BtAddData.UseVisualStyleBackColor = true;
            this.BtAddData.Click += new System.EventHandler(this.BtAddData_Click);
            // 
            // BtDeleteSelected
            // 
            this.BtDeleteSelected.Location = new System.Drawing.Point(218, 6);
            this.BtDeleteSelected.Name = "BtDeleteSelected";
            this.BtDeleteSelected.Size = new System.Drawing.Size(100, 33);
            this.BtDeleteSelected.TabIndex = 3;
            this.BtDeleteSelected.Text = "刪除選取";
            this.BtDeleteSelected.UseVisualStyleBackColor = true;
            this.BtDeleteSelected.Click += new System.EventHandler(this.BtDeleteSelected_Click);
            // 
            // cmsAmount
            // 
            this.cmsAmount.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsAmount.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddAmount});
            this.cmsAmount.Name = "cmsAmount";
            this.cmsAmount.Size = new System.Drawing.Size(161, 36);
            // 
            // tsmiAddAmount
            // 
            this.tsmiAddAmount.Name = "tsmiAddAmount";
            this.tsmiAddAmount.Size = new System.Drawing.Size(160, 32);
            this.tsmiAddAmount.Text = "增加金額";
            this.tsmiAddAmount.Click += new System.EventHandler(this.TsmiAddAmount_Click);
            // 
            // Monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 692);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Noto Sans TC", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Monitor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Monitor_FormClosing);
            this.tabControl.ResumeLayout(false);
            this.tabMonitor.ResumeLayout(false);
            this.tabMonitor.PerformLayout();
            this.tabData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonateData)).EndInit();
            this.cmsAmount.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMonitor;
        private System.Windows.Forms.TabPage tabData;
        private System.Windows.Forms.Label lbECPAY_Status;
        private System.Windows.Forms.TextBox Tb_MonitorOut;
        private System.Windows.Forms.Button BtConfig;
        private System.Windows.Forms.Label lbOPAY_Status;
        private System.Windows.Forms.Label lbStreamlabs_Status;
        private System.Windows.Forms.Label lbHiveBee_Status;
        private System.Windows.Forms.Label lbSoundAlerts_Status;
        private System.Windows.Forms.Label lbStreamBoostMax_Text_Status;
        private System.Windows.Forms.Label lbStreamBoostMax_Video_Status;
        private System.Windows.Forms.Button BtClearDonateDB;
        private System.Windows.Forms.DataGridView dgvDonateData;
        private System.Windows.Forms.Button BtRefreshData;
        private System.Windows.Forms.Button BtAddData;
        private System.Windows.Forms.Button BtDeleteSelected;
        private System.Windows.Forms.ContextMenuStrip cmsAmount;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddAmount;
    }
}