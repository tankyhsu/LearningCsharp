namespace alarm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Hour = new System.Windows.Forms.Label();
            this.HourSelect = new System.Windows.Forms.ComboBox();
            this.Second = new System.Windows.Forms.Label();
            this.Minute = new System.Windows.Forms.Label();
            this.Set = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Quit = new System.Windows.Forms.Button();
            this.TimeLeft = new System.Windows.Forms.Label();
            this.SecondDisplay = new System.Windows.Forms.TextBox();
            this.S = new System.Windows.Forms.Label();
            this.H = new System.Windows.Forms.Label();
            this.HourDisplay = new System.Windows.Forms.TextBox();
            this.M = new System.Windows.Forms.Label();
            this.MinuteDisplay = new System.Windows.Forms.TextBox();
            this.CurrentTime = new System.Windows.Forms.Label();
            this.TimeDisplay = new System.Windows.Forms.TextBox();
            this.MinuteInput = new System.Windows.Forms.TextBox();
            this.SecondInput = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Hour
            // 
            this.Hour.AutoSize = true;
            this.Hour.Location = new System.Drawing.Point(60, 61);
            this.Hour.Name = "Hour";
            this.Hour.Size = new System.Drawing.Size(29, 12);
            this.Hour.TabIndex = 1;
            this.Hour.Text = "Hour";
            this.Hour.Click += new System.EventHandler(this.Hour_Click);
            // 
            // HourSelect
            // 
            this.HourSelect.FormattingEnabled = true;
            this.HourSelect.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.HourSelect.Location = new System.Drawing.Point(90, 58);
            this.HourSelect.Name = "HourSelect";
            this.HourSelect.Size = new System.Drawing.Size(86, 20);
            this.HourSelect.TabIndex = 24;
            this.HourSelect.SelectedIndexChanged += new System.EventHandler(this.HourSelect_SelectedIndexChanged);
            // 
            // Second
            // 
            this.Second.AutoSize = true;
            this.Second.Location = new System.Drawing.Point(313, 61);
            this.Second.Name = "Second";
            this.Second.Size = new System.Drawing.Size(41, 12);
            this.Second.TabIndex = 5;
            this.Second.Text = "Second";
            this.Second.Click += new System.EventHandler(this.Second_Click);
            // 
            // Minute
            // 
            this.Minute.AutoSize = true;
            this.Minute.Location = new System.Drawing.Point(182, 61);
            this.Minute.Name = "Minute";
            this.Minute.Size = new System.Drawing.Size(41, 12);
            this.Minute.TabIndex = 8;
            this.Minute.Text = "Minute";
            // 
            // Set
            // 
            this.Set.Location = new System.Drawing.Point(62, 219);
            this.Set.Name = "Set";
            this.Set.Size = new System.Drawing.Size(75, 23);
            this.Set.TabIndex = 9;
            this.Set.Text = "Set";
            this.Set.UseVisualStyleBackColor = true;
            this.Set.Click += new System.EventHandler(this.Set_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(201, 219);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 10;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(511, 352);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(75, 23);
            this.Quit.TabIndex = 11;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // TimeLeft
            // 
            this.TimeLeft.AutoSize = true;
            this.TimeLeft.Location = new System.Drawing.Point(62, 161);
            this.TimeLeft.Name = "TimeLeft";
            this.TimeLeft.Size = new System.Drawing.Size(53, 12);
            this.TimeLeft.TabIndex = 12;
            this.TimeLeft.Text = "TimeLeft";
            this.TimeLeft.Click += new System.EventHandler(this.TimeLeft_Click);
            // 
            // SecondDisplay
            // 
            this.SecondDisplay.Location = new System.Drawing.Point(312, 158);
            this.SecondDisplay.Name = "SecondDisplay";
            this.SecondDisplay.ReadOnly = true;
            this.SecondDisplay.Size = new System.Drawing.Size(52, 21);
            this.SecondDisplay.TabIndex = 13;
            this.SecondDisplay.TextChanged += new System.EventHandler(this.SecondDisplay_TextChanged);
            // 
            // S
            // 
            this.S.AutoSize = true;
            this.S.Location = new System.Drawing.Point(370, 161);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(11, 12);
            this.S.TabIndex = 14;
            this.S.Text = "s";
            // 
            // H
            // 
            this.H.AutoSize = true;
            this.H.Location = new System.Drawing.Point(220, 161);
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(11, 12);
            this.H.TabIndex = 16;
            this.H.Text = "h";
            // 
            // HourDisplay
            // 
            this.HourDisplay.Location = new System.Drawing.Point(162, 158);
            this.HourDisplay.Name = "HourDisplay";
            this.HourDisplay.ReadOnly = true;
            this.HourDisplay.Size = new System.Drawing.Size(52, 21);
            this.HourDisplay.TabIndex = 15;
            this.HourDisplay.TextChanged += new System.EventHandler(this.HourDisplay_TextChanged);
            // 
            // M
            // 
            this.M.AutoSize = true;
            this.M.Location = new System.Drawing.Point(295, 161);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(11, 12);
            this.M.TabIndex = 18;
            this.M.Text = "m";
            // 
            // MinuteDisplay
            // 
            this.MinuteDisplay.Location = new System.Drawing.Point(237, 158);
            this.MinuteDisplay.Name = "MinuteDisplay";
            this.MinuteDisplay.ReadOnly = true;
            this.MinuteDisplay.Size = new System.Drawing.Size(52, 21);
            this.MinuteDisplay.TabIndex = 17;
            this.MinuteDisplay.TextChanged += new System.EventHandler(this.MinuteDisplay_TextChanged);
            // 
            // CurrentTime
            // 
            this.CurrentTime.AutoSize = true;
            this.CurrentTime.Location = new System.Drawing.Point(62, 113);
            this.CurrentTime.Name = "CurrentTime";
            this.CurrentTime.Size = new System.Drawing.Size(71, 12);
            this.CurrentTime.TabIndex = 19;
            this.CurrentTime.Text = "CurrentTime";
            this.CurrentTime.Click += new System.EventHandler(this.CurrentTime_Click);
            // 
            // TimeDisplay
            // 
            this.TimeDisplay.Location = new System.Drawing.Point(162, 110);
            this.TimeDisplay.Name = "TimeDisplay";
            this.TimeDisplay.Size = new System.Drawing.Size(202, 21);
            this.TimeDisplay.TabIndex = 20;
            this.TimeDisplay.Text = "16:50:27";
            this.TimeDisplay.TextChanged += new System.EventHandler(this.TimeDisplay_TextChanged);
            // 
            // MinuteInput
            // 
            this.MinuteInput.Location = new System.Drawing.Point(229, 58);
            this.MinuteInput.Name = "MinuteInput";
            this.MinuteInput.Size = new System.Drawing.Size(77, 21);
            this.MinuteInput.TabIndex = 25;
            this.MinuteInput.TextChanged += new System.EventHandler(this.MinuteInput_TextChanged);
            // 
            // SecondInput
            // 
            this.SecondInput.Location = new System.Drawing.Point(360, 58);
            this.SecondInput.Name = "SecondInput";
            this.SecondInput.Size = new System.Drawing.Size(77, 21);
            this.SecondInput.TabIndex = 26;
            this.SecondInput.TextChanged += new System.EventHandler(this.SecondInput_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 408);
            this.Controls.Add(this.SecondInput);
            this.Controls.Add(this.MinuteInput);
            this.Controls.Add(this.TimeDisplay);
            this.Controls.Add(this.CurrentTime);
            this.Controls.Add(this.M);
            this.Controls.Add(this.MinuteDisplay);
            this.Controls.Add(this.H);
            this.Controls.Add(this.HourDisplay);
            this.Controls.Add(this.S);
            this.Controls.Add(this.SecondDisplay);
            this.Controls.Add(this.TimeLeft);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Set);
            this.Controls.Add(this.Minute);
            this.Controls.Add(this.Second);
            this.Controls.Add(this.HourSelect);
            this.Controls.Add(this.Hour);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

            ///Timer2
            ///
            this.timer2.Enabled = false;


        }

        #endregion

        private System.Windows.Forms.Label Hour;
        
        private System.Windows.Forms.ComboBox HourSelect;
        private System.Windows.Forms.Label Second;
        private System.Windows.Forms.Label Minute;
        private System.Windows.Forms.Button Set;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Quit;
        private System.Windows.Forms.Label TimeLeft;
        private System.Windows.Forms.TextBox SecondDisplay;
        private System.Windows.Forms.Label S;
        private System.Windows.Forms.Label H;
        private System.Windows.Forms.TextBox HourDisplay;
        private System.Windows.Forms.Label M;
        private System.Windows.Forms.TextBox MinuteDisplay;
        private System.Windows.Forms.Label CurrentTime;
        private System.Windows.Forms.TextBox TimeDisplay;
        private System.Windows.Forms.TextBox MinuteInput;
        private System.Windows.Forms.TextBox SecondInput;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;



        


    }
}

