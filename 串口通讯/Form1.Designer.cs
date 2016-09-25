namespace 串口通讯
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.protswitch = new System.Windows.Forms.Button();
            this.showdatebox = new System.Windows.Forms.TextBox();
            this.add_screen = new System.Windows.Forms.Button();
            this.div_screen = new System.Windows.Forms.Button();
            this.screen_label = new System.Windows.Forms.Label();
            this.扫描时间 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serialport_state = new System.Windows.Forms.Label();
            this.clear_revicebox = new System.Windows.Forms.Button();
            this.serialport_name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.port_buandrate = new System.Windows.Forms.ComboBox();
            this.prot_stopbit = new System.Windows.Forms.ComboBox();
            this.prot_datebit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.port_parity = new System.Windows.Forms.ComboBox();
            this.port_name = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // protswitch
            // 
            this.protswitch.Location = new System.Drawing.Point(683, 394);
            this.protswitch.Name = "protswitch";
            this.protswitch.Size = new System.Drawing.Size(75, 23);
            this.protswitch.TabIndex = 0;
            this.protswitch.Text = "open";
            this.protswitch.UseVisualStyleBackColor = true;
            this.protswitch.Click += new System.EventHandler(this.protswitch_Click);
            // 
            // showdatebox
            // 
            this.showdatebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.showdatebox.Location = new System.Drawing.Point(34, 179);
            this.showdatebox.Multiline = true;
            this.showdatebox.Name = "showdatebox";
            this.showdatebox.Size = new System.Drawing.Size(445, 238);
            this.showdatebox.TabIndex = 3;
            // 
            // add_screen
            // 
            this.add_screen.Location = new System.Drawing.Point(604, 337);
            this.add_screen.Name = "add_screen";
            this.add_screen.Size = new System.Drawing.Size(87, 23);
            this.add_screen.TabIndex = 4;
            this.add_screen.Text = "增加扫描速度";
            this.add_screen.UseVisualStyleBackColor = true;
            this.add_screen.Click += new System.EventHandler(this.add_screen_Click);
            // 
            // div_screen
            // 
            this.div_screen.Location = new System.Drawing.Point(502, 337);
            this.div_screen.Name = "div_screen";
            this.div_screen.Size = new System.Drawing.Size(87, 23);
            this.div_screen.TabIndex = 5;
            this.div_screen.Text = "减少扫描速度";
            this.div_screen.UseVisualStyleBackColor = true;
            this.div_screen.Click += new System.EventHandler(this.div_screen_Click);
            // 
            // screen_label
            // 
            this.screen_label.AutoSize = true;
            this.screen_label.Location = new System.Drawing.Point(571, 307);
            this.screen_label.Name = "screen_label";
            this.screen_label.Size = new System.Drawing.Size(17, 12);
            this.screen_label.TabIndex = 6;
            this.screen_label.Text = "10";
            // 
            // 扫描时间
            // 
            this.扫描时间.AutoSize = true;
            this.扫描时间.Location = new System.Drawing.Point(500, 307);
            this.扫描时间.Name = "扫描时间";
            this.扫描时间.Size = new System.Drawing.Size(65, 12);
            this.扫描时间.TabIndex = 7;
            this.扫描时间.Text = "扫描时间：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(626, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "串口状态：";
            // 
            // serialport_state
            // 
            this.serialport_state.AutoSize = true;
            this.serialport_state.Location = new System.Drawing.Point(697, 264);
            this.serialport_state.Name = "serialport_state";
            this.serialport_state.Size = new System.Drawing.Size(29, 12);
            this.serialport_state.TabIndex = 9;
            this.serialport_state.Text = "关闭";
            // 
            // clear_revicebox
            // 
            this.clear_revicebox.AutoSize = true;
            this.clear_revicebox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clear_revicebox.Location = new System.Drawing.Point(501, 395);
            this.clear_revicebox.Name = "clear_revicebox";
            this.clear_revicebox.Size = new System.Drawing.Size(87, 22);
            this.clear_revicebox.TabIndex = 10;
            this.clear_revicebox.Text = "清空接受文本";
            this.clear_revicebox.UseVisualStyleBackColor = true;
            this.clear_revicebox.Click += new System.EventHandler(this.clear_revicebox_Click);
            // 
            // serialport_name
            // 
            this.serialport_name.AutoSize = true;
            this.serialport_name.Location = new System.Drawing.Point(499, 199);
            this.serialport_name.Name = "serialport_name";
            this.serialport_name.Size = new System.Drawing.Size(41, 12);
            this.serialport_name.TabIndex = 11;
            this.serialport_name.Text = "串口号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(499, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "波特率";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(626, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "奇偶校验";
            // 
            // port_buandrate
            // 
            this.port_buandrate.FormattingEnabled = true;
            this.port_buandrate.Location = new System.Drawing.Point(548, 229);
            this.port_buandrate.Name = "port_buandrate";
            this.port_buandrate.Size = new System.Drawing.Size(64, 20);
            this.port_buandrate.TabIndex = 15;
            this.port_buandrate.Text = "9600";
            // 
            // prot_stopbit
            // 
            this.prot_stopbit.FormattingEnabled = true;
            this.prot_stopbit.Location = new System.Drawing.Point(548, 261);
            this.prot_stopbit.Name = "prot_stopbit";
            this.prot_stopbit.Size = new System.Drawing.Size(64, 20);
            this.prot_stopbit.TabIndex = 20;
            // 
            // prot_datebit
            // 
            this.prot_datebit.FormattingEnabled = true;
            this.prot_datebit.Location = new System.Drawing.Point(694, 226);
            this.prot_datebit.Name = "prot_datebit";
            this.prot_datebit.Size = new System.Drawing.Size(64, 20);
            this.prot_datebit.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(499, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 18;
            this.label5.Text = "停止位";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(626, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "数据位数";
            // 
            // port_parity
            // 
            this.port_parity.FormattingEnabled = true;
            this.port_parity.Location = new System.Drawing.Point(694, 197);
            this.port_parity.Name = "port_parity";
            this.port_parity.Size = new System.Drawing.Size(63, 20);
            this.port_parity.TabIndex = 21;
            // 
            // port_name
            // 
            this.port_name.FormattingEnabled = true;
            this.port_name.Location = new System.Drawing.Point(548, 196);
            this.port_name.Name = "port_name";
            this.port_name.Size = new System.Drawing.Size(64, 20);
            this.port_name.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(783, 464);
            this.Controls.Add(this.port_name);
            this.Controls.Add(this.port_parity);
            this.Controls.Add(this.prot_stopbit);
            this.Controls.Add(this.prot_datebit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.port_buandrate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.serialport_name);
            this.Controls.Add(this.clear_revicebox);
            this.Controls.Add(this.serialport_state);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.扫描时间);
            this.Controls.Add(this.screen_label);
            this.Controls.Add(this.div_screen);
            this.Controls.Add(this.add_screen);
            this.Controls.Add(this.showdatebox);
            this.Controls.Add(this.protswitch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button protswitch;
        private System.Windows.Forms.TextBox showdatebox;
        private System.Windows.Forms.Button add_screen;
        private System.Windows.Forms.Button div_screen;
        private System.Windows.Forms.Label screen_label;
        private System.Windows.Forms.Label 扫描时间;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label serialport_state;
        private System.Windows.Forms.Button clear_revicebox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox port_buandrate;
        private System.Windows.Forms.Label serialport_name;
        private System.Windows.Forms.ComboBox prot_stopbit;
        private System.Windows.Forms.ComboBox prot_datebit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox port_parity;
        private System.Windows.Forms.ComboBox port_name;
    }
}

