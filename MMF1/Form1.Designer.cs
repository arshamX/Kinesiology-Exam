namespace MMF1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbPersonalInfo = new System.Windows.Forms.GroupBox();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gbTestInfo = new System.Windows.Forms.GroupBox();
            this.cbFrequency = new System.Windows.Forms.ComboBox();
            this.nudDelayKR = new System.Windows.Forms.NumericUpDown();
            this.nudShowTime = new System.Windows.Forms.NumericUpDown();
            this.nudFeedBack = new System.Windows.Forms.NumericUpDown();
            this.nudRepeat = new System.Windows.Forms.NumericUpDown();
            this.rbtnITTMT = new System.Windows.Forms.RadioButton();
            this.rbtnTMT = new System.Windows.Forms.RadioButton();
            this.rbtnIT = new System.Windows.Forms.RadioButton();
            this.cbTestType = new System.Windows.Forms.ComboBox();
            this.lblFeedBackType = new System.Windows.Forms.Label();
            this.lblFrequency = new System.Windows.Forms.Label();
            this.lblDelayKR = new System.Windows.Forms.Label();
            this.lblShowTime = new System.Windows.Forms.Label();
            this.lblFeedBack = new System.Windows.Forms.Label();
            this.lblRepeat = new System.Windows.Forms.Label();
            this.lblTestType = new System.Windows.Forms.Label();
            this.TimerStopBtn = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.gbPersonalInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gbTestInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayKR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudShowTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFeedBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRepeat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbPersonalInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 236);
            this.panel1.TabIndex = 0;
            // 
            // gbPersonalInfo
            // 
            this.gbPersonalInfo.Controls.Add(this.txtGroup);
            this.gbPersonalInfo.Controls.Add(this.txtCode);
            this.gbPersonalInfo.Controls.Add(this.txtLastName);
            this.gbPersonalInfo.Controls.Add(this.txtName);
            this.gbPersonalInfo.Controls.Add(this.lblGroup);
            this.gbPersonalInfo.Controls.Add(this.lblCode);
            this.gbPersonalInfo.Controls.Add(this.lblLastName);
            this.gbPersonalInfo.Controls.Add(this.lblName);
            this.gbPersonalInfo.Location = new System.Drawing.Point(16, 15);
            this.gbPersonalInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPersonalInfo.Name = "gbPersonalInfo";
            this.gbPersonalInfo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPersonalInfo.Size = new System.Drawing.Size(432, 209);
            this.gbPersonalInfo.TabIndex = 0;
            this.gbPersonalInfo.TabStop = false;
            this.gbPersonalInfo.Text = "Personal Information";
            // 
            // txtGroup
            // 
            this.txtGroup.Location = new System.Drawing.Point(129, 151);
            this.txtGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(132, 22);
            this.txtGroup.TabIndex = 7;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(129, 116);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(132, 22);
            this.txtCode.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(129, 79);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(132, 22);
            this.txtLastName.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(129, 43);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 22);
            this.txtName.TabIndex = 4;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(23, 151);
            this.lblGroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(53, 16);
            this.lblGroup.TabIndex = 3;
            this.lblGroup.Text = "Group : ";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(24, 119);
            this.lblCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(46, 16);
            this.lblCode.TabIndex = 2;
            this.lblCode.Text = "Code :";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(23, 82);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(78, 16);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(24, 47);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "First Name :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnStop);
            this.panel2.Controls.Add(this.btnStart);
            this.panel2.Controls.Add(this.btnExport);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 591);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 43);
            this.panel2.TabIndex = 2;
            // 
            // btnStop
            // 
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStop.Location = new System.Drawing.Point(100, 0);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 43);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStart.Location = new System.Drawing.Point(0, 0);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 43);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExport
            // 
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExport.Location = new System.Drawing.Point(341, 0);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(124, 43);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "Export Results";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gbTestInfo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 236);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(465, 347);
            this.panel3.TabIndex = 3;
            // 
            // gbTestInfo
            // 
            this.gbTestInfo.Controls.Add(this.cbFrequency);
            this.gbTestInfo.Controls.Add(this.nudDelayKR);
            this.gbTestInfo.Controls.Add(this.nudShowTime);
            this.gbTestInfo.Controls.Add(this.nudFeedBack);
            this.gbTestInfo.Controls.Add(this.nudRepeat);
            this.gbTestInfo.Controls.Add(this.rbtnITTMT);
            this.gbTestInfo.Controls.Add(this.rbtnTMT);
            this.gbTestInfo.Controls.Add(this.rbtnIT);
            this.gbTestInfo.Controls.Add(this.cbTestType);
            this.gbTestInfo.Controls.Add(this.lblFeedBackType);
            this.gbTestInfo.Controls.Add(this.lblFrequency);
            this.gbTestInfo.Controls.Add(this.lblDelayKR);
            this.gbTestInfo.Controls.Add(this.lblShowTime);
            this.gbTestInfo.Controls.Add(this.lblFeedBack);
            this.gbTestInfo.Controls.Add(this.lblRepeat);
            this.gbTestInfo.Controls.Add(this.lblTestType);
            this.gbTestInfo.Location = new System.Drawing.Point(16, 10);
            this.gbTestInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbTestInfo.Name = "gbTestInfo";
            this.gbTestInfo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbTestInfo.Size = new System.Drawing.Size(432, 320);
            this.gbTestInfo.TabIndex = 1;
            this.gbTestInfo.TabStop = false;
            this.gbTestInfo.Text = "Test Information";
            // 
            // cbFrequency
            // 
            this.cbFrequency.FormattingEnabled = true;
            this.cbFrequency.Items.AddRange(new object[] {
            "25%",
            "50%",
            "75%",
            "100%"});
            this.cbFrequency.Location = new System.Drawing.Point(128, 209);
            this.cbFrequency.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFrequency.Name = "cbFrequency";
            this.cbFrequency.Size = new System.Drawing.Size(111, 24);
            this.cbFrequency.TabIndex = 15;
            this.cbFrequency.SelectedIndexChanged += new System.EventHandler(this.cbFrequency_SelectedIndexChanged);
            // 
            // nudDelayKR
            // 
            this.nudDelayKR.Location = new System.Drawing.Point(177, 177);
            this.nudDelayKR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudDelayKR.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudDelayKR.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDelayKR.Name = "nudDelayKR";
            this.nudDelayKR.Size = new System.Drawing.Size(57, 22);
            this.nudDelayKR.TabIndex = 14;
            this.nudDelayKR.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudShowTime
            // 
            this.nudShowTime.Location = new System.Drawing.Point(177, 145);
            this.nudShowTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudShowTime.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudShowTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudShowTime.Name = "nudShowTime";
            this.nudShowTime.Size = new System.Drawing.Size(57, 22);
            this.nudShowTime.TabIndex = 13;
            this.nudShowTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudFeedBack
            // 
            this.nudFeedBack.Location = new System.Drawing.Point(177, 110);
            this.nudFeedBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudFeedBack.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudFeedBack.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFeedBack.Name = "nudFeedBack";
            this.nudFeedBack.Size = new System.Drawing.Size(57, 22);
            this.nudFeedBack.TabIndex = 12;
            this.nudFeedBack.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudRepeat
            // 
            this.nudRepeat.Location = new System.Drawing.Point(177, 78);
            this.nudRepeat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudRepeat.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudRepeat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRepeat.Name = "nudRepeat";
            this.nudRepeat.Size = new System.Drawing.Size(57, 22);
            this.nudRepeat.TabIndex = 11;
            this.nudRepeat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rbtnITTMT
            // 
            this.rbtnITTMT.AutoSize = true;
            this.rbtnITTMT.Location = new System.Drawing.Point(311, 274);
            this.rbtnITTMT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnITTMT.Name = "rbtnITTMT";
            this.rbtnITTMT.Size = new System.Drawing.Size(79, 20);
            this.rbtnITTMT.TabIndex = 10;
            this.rbtnITTMT.TabStop = true;
            this.rbtnITTMT.Text = "IT - TMT";
            this.rbtnITTMT.UseVisualStyleBackColor = true;
            this.rbtnITTMT.CheckedChanged += new System.EventHandler(this.rbtnITTMT_CheckedChanged);
            // 
            // rbtnTMT
            // 
            this.rbtnTMT.AutoSize = true;
            this.rbtnTMT.Location = new System.Drawing.Point(199, 274);
            this.rbtnTMT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnTMT.Name = "rbtnTMT";
            this.rbtnTMT.Size = new System.Drawing.Size(57, 20);
            this.rbtnTMT.TabIndex = 9;
            this.rbtnTMT.TabStop = true;
            this.rbtnTMT.Text = "TMT";
            this.rbtnTMT.UseVisualStyleBackColor = true;
            this.rbtnTMT.CheckedChanged += new System.EventHandler(this.rbtnITTMT_CheckedChanged);
            // 
            // rbtnIT
            // 
            this.rbtnIT.AutoSize = true;
            this.rbtnIT.Location = new System.Drawing.Point(91, 274);
            this.rbtnIT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnIT.Name = "rbtnIT";
            this.rbtnIT.Size = new System.Drawing.Size(40, 20);
            this.rbtnIT.TabIndex = 8;
            this.rbtnIT.TabStop = true;
            this.rbtnIT.Text = "IT";
            this.rbtnIT.UseVisualStyleBackColor = true;
            this.rbtnIT.CheckedChanged += new System.EventHandler(this.rbtnITTMT_CheckedChanged);
            // 
            // cbTestType
            // 
            this.cbTestType.FormattingEnabled = true;
            this.cbTestType.Items.AddRange(new object[] {
            "Acquisition",
            "Delayed Retention",
            "Immediate Retention",
            "Post Test",
            "Pre Test",
            "Transfer",
            "Transfer Under Pressure",
            "Other... "});
            this.cbTestType.Location = new System.Drawing.Point(151, 34);
            this.cbTestType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTestType.Name = "cbTestType";
            this.cbTestType.Size = new System.Drawing.Size(160, 24);
            this.cbTestType.TabIndex = 7;
            this.cbTestType.SelectedIndexChanged += new System.EventHandler(this.cbTestType_SelectedIndexChanged);
            // 
            // lblFeedBackType
            // 
            this.lblFeedBackType.AutoSize = true;
            this.lblFeedBackType.Location = new System.Drawing.Point(36, 241);
            this.lblFeedBackType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFeedBackType.Name = "lblFeedBackType";
            this.lblFeedBackType.Size = new System.Drawing.Size(114, 16);
            this.lblFeedBackType.TabIndex = 6;
            this.lblFeedBackType.Text = "FeedBack Type : ";
            // 
            // lblFrequency
            // 
            this.lblFrequency.AutoSize = true;
            this.lblFrequency.Location = new System.Drawing.Point(36, 210);
            this.lblFrequency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(77, 16);
            this.lblFrequency.TabIndex = 5;
            this.lblFrequency.Text = "Frequency :";
            // 
            // lblDelayKR
            // 
            this.lblDelayKR.AutoSize = true;
            this.lblDelayKR.Location = new System.Drawing.Point(37, 180);
            this.lblDelayKR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDelayKR.Name = "lblDelayKR";
            this.lblDelayKR.Size = new System.Drawing.Size(123, 16);
            this.lblDelayKR.TabIndex = 4;
            this.lblDelayKR.Text = "Delayed KR Time : ";
            // 
            // lblShowTime
            // 
            this.lblShowTime.AutoSize = true;
            this.lblShowTime.Location = new System.Drawing.Point(37, 153);
            this.lblShowTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShowTime.Name = "lblShowTime";
            this.lblShowTime.Size = new System.Drawing.Size(80, 16);
            this.lblShowTime.TabIndex = 3;
            this.lblShowTime.Text = "Show Time :";
            // 
            // lblFeedBack
            // 
            this.lblFeedBack.AutoSize = true;
            this.lblFeedBack.Location = new System.Drawing.Point(36, 121);
            this.lblFeedBack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFeedBack.Name = "lblFeedBack";
            this.lblFeedBack.Size = new System.Drawing.Size(115, 16);
            this.lblFeedBack.TabIndex = 2;
            this.lblFeedBack.Text = "FeedBack Delay :";
            // 
            // lblRepeat
            // 
            this.lblRepeat.AutoSize = true;
            this.lblRepeat.Location = new System.Drawing.Point(37, 86);
            this.lblRepeat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRepeat.Name = "lblRepeat";
            this.lblRepeat.Size = new System.Drawing.Size(91, 16);
            this.lblRepeat.TabIndex = 1;
            this.lblRepeat.Text = "Trial Number :";
            // 
            // lblTestType
            // 
            this.lblTestType.AutoSize = true;
            this.lblTestType.Location = new System.Drawing.Point(61, 38);
            this.lblTestType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTestType.Name = "lblTestType";
            this.lblTestType.Size = new System.Drawing.Size(75, 16);
            this.lblTestType.TabIndex = 0;
            this.lblTestType.Text = "Test Type :";
            // 
            // TimerStopBtn
            // 
            this.TimerStopBtn.Tick += new System.EventHandler(this.TimerStopBtn_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 634);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "MMF";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.gbPersonalInfo.ResumeLayout(false);
            this.gbPersonalInfo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.gbTestInfo.ResumeLayout(false);
            this.gbTestInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelayKR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudShowTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFeedBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRepeat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbPersonalInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox gbTestInfo;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFeedBackType;
        private System.Windows.Forms.Label lblFrequency;
        private System.Windows.Forms.Label lblDelayKR;
        private System.Windows.Forms.Label lblShowTime;
        private System.Windows.Forms.Label lblFeedBack;
        private System.Windows.Forms.Label lblRepeat;
        private System.Windows.Forms.Label lblTestType;
        private System.Windows.Forms.ComboBox cbTestType;
        private System.Windows.Forms.RadioButton rbtnITTMT;
        private System.Windows.Forms.RadioButton rbtnTMT;
        private System.Windows.Forms.RadioButton rbtnIT;
        private System.Windows.Forms.ComboBox cbFrequency;
        private System.Windows.Forms.NumericUpDown nudDelayKR;
        private System.Windows.Forms.NumericUpDown nudShowTime;
        private System.Windows.Forms.NumericUpDown nudFeedBack;
        private System.Windows.Forms.NumericUpDown nudRepeat;
        private System.Windows.Forms.Timer TimerStopBtn;
    }
}

