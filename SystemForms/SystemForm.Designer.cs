namespace SystemForms
{
    partial class SystemForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbx_Service_Content = new System.Windows.Forms.TextBox();
            this.tbx_DispName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_ServicePath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbx_Content = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tlsButSetup = new System.Windows.Forms.ToolStripButton();
            this.tlsButDel = new System.Windows.Forms.ToolStripButton();
            this.tlsButStart = new System.Windows.Forms.ToolStripButton();
            this.tlsButStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsButExit = new System.Windows.Forms.ToolStripButton();
            this.tlsButOpenDic = new System.Windows.Forms.ToolStripButton();
            this.tlsButClear = new System.Windows.Forms.ToolStripButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.text_PingContent = new System.Windows.Forms.TextBox();
            this.btn_Ping_val = new System.Windows.Forms.Button();
            this.tbx_Host = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tbx_Service_Content);
            this.groupBox2.Controls.Add(this.tbx_DispName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbx_ServicePath);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(13, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 317);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "服务参数";
            // 
            // tbx_Service_Content
            // 
            this.tbx_Service_Content.Location = new System.Drawing.Point(107, 127);
            this.tbx_Service_Content.Multiline = true;
            this.tbx_Service_Content.Name = "tbx_Service_Content";
            this.tbx_Service_Content.Size = new System.Drawing.Size(301, 173);
            this.tbx_Service_Content.TabIndex = 6;
            // 
            // tbx_DispName
            // 
            this.tbx_DispName.Location = new System.Drawing.Point(107, 95);
            this.tbx_DispName.Name = "tbx_DispName";
            this.tbx_DispName.Size = new System.Drawing.Size(180, 21);
            this.tbx_DispName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "服务描述：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "显示服务名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "服务文件路径：";
            // 
            // tbx_ServicePath
            // 
            this.tbx_ServicePath.Location = new System.Drawing.Point(107, 55);
            this.tbx_ServicePath.Name = "tbx_ServicePath";
            this.tbx_ServicePath.ReadOnly = true;
            this.tbx_ServicePath.Size = new System.Drawing.Size(180, 21);
            this.tbx_ServicePath.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "选择安装文件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OpenFileByButtion_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tbx_Content);
            this.groupBox1.Location = new System.Drawing.Point(13, 354);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(955, 328);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "测试信息";
            // 
            // tbx_Content
            // 
            this.tbx_Content.Location = new System.Drawing.Point(7, 21);
            this.tbx_Content.Multiline = true;
            this.tbx_Content.Name = "tbx_Content";
            this.tbx_Content.ReadOnly = true;
            this.tbx_Content.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbx_Content.Size = new System.Drawing.Size(942, 301);
            this.tbx_Content.TabIndex = 11;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsButSetup,
            this.tlsButDel,
            this.tlsButStart,
            this.tlsButStop,
            this.toolStripSeparator1,
            this.tlsButExit,
            this.tlsButOpenDic,
            this.tlsButClear});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(980, 28);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tlsButSetup
            // 
            this.tlsButSetup.Image = ((System.Drawing.Image)(resources.GetObject("tlsButSetup.Image")));
            this.tlsButSetup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsButSetup.Name = "tlsButSetup";
            this.tlsButSetup.Size = new System.Drawing.Size(62, 25);
            this.tlsButSetup.Text = "安装";
            this.tlsButSetup.Click += new System.EventHandler(this.tlsButSetup_Click);
            // 
            // tlsButDel
            // 
            this.tlsButDel.Image = ((System.Drawing.Image)(resources.GetObject("tlsButDel.Image")));
            this.tlsButDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsButDel.Name = "tlsButDel";
            this.tlsButDel.Size = new System.Drawing.Size(62, 25);
            this.tlsButDel.Text = "卸载";
            this.tlsButDel.Click += new System.EventHandler(this.tlsButDel_Click);
            // 
            // tlsButStart
            // 
            this.tlsButStart.Image = ((System.Drawing.Image)(resources.GetObject("tlsButStart.Image")));
            this.tlsButStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsButStart.Name = "tlsButStart";
            this.tlsButStart.Size = new System.Drawing.Size(62, 25);
            this.tlsButStart.Text = "启动";
            this.tlsButStart.Click += new System.EventHandler(this.tlsButStart_Click);
            // 
            // tlsButStop
            // 
            this.tlsButStop.Image = ((System.Drawing.Image)(resources.GetObject("tlsButStop.Image")));
            this.tlsButStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsButStop.Name = "tlsButStop";
            this.tlsButStop.Size = new System.Drawing.Size(62, 25);
            this.tlsButStop.Text = "停止";
            this.tlsButStop.Click += new System.EventHandler(this.tlsButStop_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // tlsButExit
            // 
            this.tlsButExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tlsButExit.Image = ((System.Drawing.Image)(resources.GetObject("tlsButExit.Image")));
            this.tlsButExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsButExit.Name = "tlsButExit";
            this.tlsButExit.Size = new System.Drawing.Size(62, 25);
            this.tlsButExit.Text = "退出";
            this.tlsButExit.Click += new System.EventHandler(this.tlsButExit_Click);
            // 
            // tlsButOpenDic
            // 
            this.tlsButOpenDic.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tlsButOpenDic.Image = ((System.Drawing.Image)(resources.GetObject("tlsButOpenDic.Image")));
            this.tlsButOpenDic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsButOpenDic.Name = "tlsButOpenDic";
            this.tlsButOpenDic.Size = new System.Drawing.Size(110, 25);
            this.tlsButOpenDic.Text = "当前文件夹";
            this.tlsButOpenDic.Click += new System.EventHandler(this.tlsButOpenDic_Click);
            // 
            // tlsButClear
            // 
            this.tlsButClear.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tlsButClear.Image = ((System.Drawing.Image)(resources.GetObject("tlsButClear.Image")));
            this.tlsButClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsButClear.Name = "tlsButClear";
            this.tlsButClear.Size = new System.Drawing.Size(62, 25);
            this.tlsButClear.Text = "清除";
            this.tlsButClear.Click += new System.EventHandler(this.tlsButClear_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.text_PingContent);
            this.groupBox3.Controls.Add(this.btn_Ping_val);
            this.groupBox3.Controls.Add(this.tbx_Host);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(481, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(481, 317);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "连接检测";
            // 
            // text_PingContent
            // 
            this.text_PingContent.Location = new System.Drawing.Point(37, 136);
            this.text_PingContent.Multiline = true;
            this.text_PingContent.Name = "text_PingContent";
            this.text_PingContent.ReadOnly = true;
            this.text_PingContent.Size = new System.Drawing.Size(427, 164);
            this.text_PingContent.TabIndex = 3;
            // 
            // btn_Ping_val
            // 
            this.btn_Ping_val.Location = new System.Drawing.Point(221, 93);
            this.btn_Ping_val.Name = "btn_Ping_val";
            this.btn_Ping_val.Size = new System.Drawing.Size(75, 23);
            this.btn_Ping_val.TabIndex = 2;
            this.btn_Ping_val.Text = "检测稳定性";
            this.btn_Ping_val.UseVisualStyleBackColor = true;
            this.btn_Ping_val.Click += new System.EventHandler(this.btn_Ping_val_Click);
            // 
            // tbx_Host
            // 
            this.tbx_Host.Location = new System.Drawing.Point(145, 46);
            this.tbx_Host.Name = "tbx_Host";
            this.tbx_Host.Size = new System.Drawing.Size(319, 21);
            this.tbx_Host.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "hostNameOrAddress：";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.InitialDirectory = "D:\\projects\\gfccydx\\Git\\SystemManage\\SystemService";
            // 
            // SystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 694);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "SystemForm";
            this.Text = "业务系统管理";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbx_Content;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tlsButSetup;
        private System.Windows.Forms.ToolStripButton tlsButDel;
        private System.Windows.Forms.ToolStripButton tlsButStart;
        private System.Windows.Forms.ToolStripButton tlsButStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tlsButExit;
        private System.Windows.Forms.ToolStripButton tlsButOpenDic;
        private System.Windows.Forms.ToolStripButton tlsButClear;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbx_Service_Content;
        private System.Windows.Forms.TextBox tbx_DispName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_ServicePath;
        private System.Windows.Forms.TextBox text_PingContent;
        private System.Windows.Forms.Button btn_Ping_val;
        private System.Windows.Forms.TextBox tbx_Host;
        private System.Windows.Forms.Label label4;
    }
}

