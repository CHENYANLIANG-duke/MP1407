namespace MP1407
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_CloseReader = new System.Windows.Forms.Button();
            this.btn_OpenReader = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtmsg = new System.Windows.Forms.TextBox();
            this.btn_AutoReadUltraLight = new System.Windows.Forms.Button();
            this.txtthreadtime = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.labcomchoice = new System.Windows.Forms.Label();
            this.ComportName = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_CloseReader
            // 
            this.btn_CloseReader.Enabled = false;
            this.btn_CloseReader.Location = new System.Drawing.Point(110, 60);
            this.btn_CloseReader.Name = "btn_CloseReader";
            this.btn_CloseReader.Size = new System.Drawing.Size(86, 29);
            this.btn_CloseReader.TabIndex = 94;
            this.btn_CloseReader.Text = "Close Reader";
            this.btn_CloseReader.UseVisualStyleBackColor = true;
            this.btn_CloseReader.SizeChanged += new System.EventHandler(this.btn_CloseReader_SizeChanged);
            this.btn_CloseReader.Click += new System.EventHandler(this.btn_CloseReader_Click);
            // 
            // btn_OpenReader
            // 
            this.btn_OpenReader.Location = new System.Drawing.Point(18, 60);
            this.btn_OpenReader.Name = "btn_OpenReader";
            this.btn_OpenReader.Size = new System.Drawing.Size(86, 29);
            this.btn_OpenReader.TabIndex = 96;
            this.btn_OpenReader.Text = "Open Reader";
            this.btn_OpenReader.UseVisualStyleBackColor = true;
            this.btn_OpenReader.Click += new System.EventHandler(this.btn_OpenReader_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtmsg);
            this.groupBox1.Location = new System.Drawing.Point(12, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 157);
            this.groupBox1.TabIndex = 97;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NDEF Message";
            // 
            // txtmsg
            // 
            this.txtmsg.Location = new System.Drawing.Point(6, 21);
            this.txtmsg.Multiline = true;
            this.txtmsg.Name = "txtmsg";
            this.txtmsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtmsg.Size = new System.Drawing.Size(412, 129);
            this.txtmsg.TabIndex = 97;
            // 
            // btn_AutoReadUltraLight
            // 
            this.btn_AutoReadUltraLight.Enabled = false;
            this.btn_AutoReadUltraLight.Location = new System.Drawing.Point(202, 60);
            this.btn_AutoReadUltraLight.Name = "btn_AutoReadUltraLight";
            this.btn_AutoReadUltraLight.Size = new System.Drawing.Size(120, 30);
            this.btn_AutoReadUltraLight.TabIndex = 94;
            this.btn_AutoReadUltraLight.Text = "AutoRead UltraLight";
            this.btn_AutoReadUltraLight.UseVisualStyleBackColor = true;
            this.btn_AutoReadUltraLight.Click += new System.EventHandler(this.btn_AutoReadUltraLight_Click);
            // 
            // txtthreadtime
            // 
            this.txtthreadtime.AcceptsReturn = true;
            this.txtthreadtime.BackColor = System.Drawing.SystemColors.Window;
            this.txtthreadtime.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtthreadtime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtthreadtime.Font = new System.Drawing.Font("細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtthreadtime.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtthreadtime.Location = new System.Drawing.Point(338, 44);
            this.txtthreadtime.MaxLength = 8;
            this.txtthreadtime.Name = "txtthreadtime";
            this.txtthreadtime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtthreadtime.Size = new System.Drawing.Size(65, 22);
            this.txtthreadtime.TabIndex = 100;
            this.txtthreadtime.Text = "500";
            this.txtthreadtime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Font = new System.Drawing.Font("細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(338, 24);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 101;
            this.label8.Text = "Thread(ms)";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "2D Scaner";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // labcomchoice
            // 
            this.labcomchoice.AutoSize = true;
            this.labcomchoice.Font = new System.Drawing.Font("標楷體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labcomchoice.Location = new System.Drawing.Point(15, 22);
            this.labcomchoice.Name = "labcomchoice";
            this.labcomchoice.Size = new System.Drawing.Size(79, 15);
            this.labcomchoice.TabIndex = 103;
            this.labcomchoice.Text = "選擇COM :";
            // 
            // ComportName
            // 
            this.ComportName.FormattingEnabled = true;
            this.ComportName.Location = new System.Drawing.Point(100, 21);
            this.ComportName.Name = "ComportName";
            this.ComportName.Size = new System.Drawing.Size(79, 20);
            this.ComportName.TabIndex = 102;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 281);
            this.Controls.Add(this.labcomchoice);
            this.Controls.Add(this.ComportName);
            this.Controls.Add(this.txtthreadtime);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_OpenReader);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_CloseReader);
            this.Controls.Add(this.btn_AutoReadUltraLight);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Unitech_MP1407";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button btn_CloseReader;
        internal System.Windows.Forms.Button btn_OpenReader;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Button btn_AutoReadUltraLight;
        public System.Windows.Forms.TextBox txtthreadtime;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtmsg;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label labcomchoice;
        private System.Windows.Forms.ComboBox ComportName;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

