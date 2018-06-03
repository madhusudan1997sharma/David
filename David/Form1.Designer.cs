namespace Jerry
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.lbl_Meridian = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_BatteryPercent = new System.Windows.Forms.Label();
            this.lbl_BatteryRunning = new System.Windows.Forms.Label();
            this.time_Timer = new System.Windows.Forms.Timer(this.components);
            this.shutdown_Timer = new System.Windows.Forms.Timer(this.components);
            this.lbl_LoggedIn = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_NetConnection = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_WLocation = new System.Windows.Forms.Label();
            this.lbl_WTemperature = new System.Windows.Forms.Label();
            this.lbl_WCondition = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbl_WHumidity = new System.Windows.Forms.Label();
            this.lbl_WWindspeed = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.lbl_Warning = new System.Windows.Forms.Label();
            this.lbl_Warning2 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.VUMeter = new System.Windows.Forms.ProgressBar();
            this.commandbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CPUmonitor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RAMmonitor = new System.Windows.Forms.Label();
            this.systemInfo_Timer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.vumeter_Timer = new System.Windows.Forms.Timer(this.components);
            this.netConnectivity_Timer = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.weather_Timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.BlueViolet;
            this.textBox1.Location = new System.Drawing.Point(886, 273);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 24);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.Visible = false;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.BlueViolet;
            this.label5.Location = new System.Drawing.Point(1037, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Google Search";
            this.label5.Visible = false;
            // 
            // lbl_Time
            // 
            this.lbl_Time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Time.ForeColor = System.Drawing.Color.BlueViolet;
            this.lbl_Time.Location = new System.Drawing.Point(898, 30);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(0, 73);
            this.lbl_Time.TabIndex = 9;
            this.lbl_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Meridian
            // 
            this.lbl_Meridian.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Meridian.AutoSize = true;
            this.lbl_Meridian.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Meridian.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Meridian.ForeColor = System.Drawing.Color.BlueViolet;
            this.lbl_Meridian.Location = new System.Drawing.Point(1075, 38);
            this.lbl_Meridian.Name = "lbl_Meridian";
            this.lbl_Meridian.Size = new System.Drawing.Size(0, 29);
            this.lbl_Meridian.TabIndex = 10;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Black;
            this.progressBar1.Location = new System.Drawing.Point(74, 32);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(316, 19);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 11;
            this.progressBar1.Visible = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.BlueViolet;
            this.label8.Location = new System.Drawing.Point(15, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Power:";
            this.label8.Visible = false;
            // 
            // lbl_BatteryPercent
            // 
            this.lbl_BatteryPercent.AutoSize = true;
            this.lbl_BatteryPercent.BackColor = System.Drawing.Color.Transparent;
            this.lbl_BatteryPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BatteryPercent.ForeColor = System.Drawing.Color.BlueViolet;
            this.lbl_BatteryPercent.Location = new System.Drawing.Point(396, 31);
            this.lbl_BatteryPercent.Name = "lbl_BatteryPercent";
            this.lbl_BatteryPercent.Size = new System.Drawing.Size(0, 20);
            this.lbl_BatteryPercent.TabIndex = 13;
            // 
            // lbl_BatteryRunning
            // 
            this.lbl_BatteryRunning.AutoSize = true;
            this.lbl_BatteryRunning.BackColor = System.Drawing.Color.Transparent;
            this.lbl_BatteryRunning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BatteryRunning.ForeColor = System.Drawing.Color.BlueViolet;
            this.lbl_BatteryRunning.Location = new System.Drawing.Point(267, 52);
            this.lbl_BatteryRunning.Name = "lbl_BatteryRunning";
            this.lbl_BatteryRunning.Size = new System.Drawing.Size(0, 20);
            this.lbl_BatteryRunning.TabIndex = 14;
            // 
            // time_Timer
            // 
            this.time_Timer.Enabled = true;
            this.time_Timer.Interval = 1;
            this.time_Timer.Tick += new System.EventHandler(this.time_Timer_Tick);
            // 
            // shutdown_Timer
            // 
            this.shutdown_Timer.Interval = 30000;
            this.shutdown_Timer.Tick += new System.EventHandler(this.shutdown_timer_Tick);
            // 
            // lbl_LoggedIn
            // 
            this.lbl_LoggedIn.AutoSize = true;
            this.lbl_LoggedIn.BackColor = System.Drawing.Color.Transparent;
            this.lbl_LoggedIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoggedIn.ForeColor = System.Drawing.Color.BlueViolet;
            this.lbl_LoggedIn.Location = new System.Drawing.Point(120, 81);
            this.lbl_LoggedIn.Name = "lbl_LoggedIn";
            this.lbl_LoggedIn.Size = new System.Drawing.Size(0, 24);
            this.lbl_LoggedIn.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.BlueViolet;
            this.label4.Location = new System.Drawing.Point(15, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Logged In as:";
            this.label4.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.BlueViolet;
            this.label6.Location = new System.Drawing.Point(15, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Network Connectivity:";
            this.label6.Visible = false;
            // 
            // lbl_NetConnection
            // 
            this.lbl_NetConnection.AutoSize = true;
            this.lbl_NetConnection.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NetConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NetConnection.ForeColor = System.Drawing.Color.BlueViolet;
            this.lbl_NetConnection.Location = new System.Drawing.Point(175, 114);
            this.lbl_NetConnection.Name = "lbl_NetConnection";
            this.lbl_NetConnection.Size = new System.Drawing.Size(0, 24);
            this.lbl_NetConnection.TabIndex = 22;
            // 
            // lbl_Date
            // 
            this.lbl_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.Color.BlueViolet;
            this.lbl_Date.Location = new System.Drawing.Point(898, 96);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(0, 33);
            this.lbl_Date.TabIndex = 24;
            this.lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label10.Location = new System.Drawing.Point(431, -1);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(394, 33);
            this.label10.TabIndex = 25;
            this.label10.Text = "DAVID v1.0";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.BlueViolet;
            this.radioButton1.Location = new System.Drawing.Point(1056, 301);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(48, 17);
            this.radioButton1.TabIndex = 26;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Web";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.Visible = false;
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.BlueViolet;
            this.radioButton2.Location = new System.Drawing.Point(1114, 301);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(54, 17);
            this.radioButton2.TabIndex = 27;
            this.radioButton2.Text = "Image";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.Visible = false;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.BlueViolet;
            this.label11.Location = new System.Drawing.Point(861, 615);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(297, 33);
            this.label11.TabIndex = 28;
            this.label11.Text = "Weather Information";
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.BlueViolet;
            this.label12.Location = new System.Drawing.Point(865, 673);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 20);
            this.label12.TabIndex = 29;
            this.label12.Text = "Location:";
            this.label12.Visible = false;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.BlueViolet;
            this.label13.Location = new System.Drawing.Point(865, 742);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 20);
            this.label13.TabIndex = 30;
            this.label13.Text = "Temperature:";
            this.label13.Visible = false;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.BlueViolet;
            this.label14.Location = new System.Drawing.Point(865, 708);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 20);
            this.label14.TabIndex = 31;
            this.label14.Text = "Condition:";
            this.label14.Visible = false;
            // 
            // lbl_WLocation
            // 
            this.lbl_WLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_WLocation.AutoSize = true;
            this.lbl_WLocation.BackColor = System.Drawing.Color.Transparent;
            this.lbl_WLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WLocation.ForeColor = System.Drawing.Color.BlueViolet;
            this.lbl_WLocation.Location = new System.Drawing.Point(940, 667);
            this.lbl_WLocation.Name = "lbl_WLocation";
            this.lbl_WLocation.Size = new System.Drawing.Size(0, 29);
            this.lbl_WLocation.TabIndex = 32;
            // 
            // lbl_WTemperature
            // 
            this.lbl_WTemperature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_WTemperature.AutoSize = true;
            this.lbl_WTemperature.BackColor = System.Drawing.Color.Transparent;
            this.lbl_WTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WTemperature.ForeColor = System.Drawing.Color.BlueViolet;
            this.lbl_WTemperature.Location = new System.Drawing.Point(970, 736);
            this.lbl_WTemperature.Name = "lbl_WTemperature";
            this.lbl_WTemperature.Size = new System.Drawing.Size(0, 29);
            this.lbl_WTemperature.TabIndex = 33;
            // 
            // lbl_WCondition
            // 
            this.lbl_WCondition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_WCondition.AutoSize = true;
            this.lbl_WCondition.BackColor = System.Drawing.Color.Transparent;
            this.lbl_WCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WCondition.ForeColor = System.Drawing.Color.BlueViolet;
            this.lbl_WCondition.Location = new System.Drawing.Point(945, 702);
            this.lbl_WCondition.Name = "lbl_WCondition";
            this.lbl_WCondition.Size = new System.Drawing.Size(0, 29);
            this.lbl_WCondition.TabIndex = 34;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.BlueViolet;
            this.label18.Location = new System.Drawing.Point(865, 776);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 20);
            this.label18.TabIndex = 35;
            this.label18.Text = "Humidity:";
            this.label18.Visible = false;
            // 
            // lbl_WHumidity
            // 
            this.lbl_WHumidity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_WHumidity.AutoSize = true;
            this.lbl_WHumidity.BackColor = System.Drawing.Color.Transparent;
            this.lbl_WHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WHumidity.ForeColor = System.Drawing.Color.BlueViolet;
            this.lbl_WHumidity.Location = new System.Drawing.Point(939, 771);
            this.lbl_WHumidity.Name = "lbl_WHumidity";
            this.lbl_WHumidity.Size = new System.Drawing.Size(0, 29);
            this.lbl_WHumidity.TabIndex = 36;
            // 
            // lbl_WWindspeed
            // 
            this.lbl_WWindspeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_WWindspeed.AutoSize = true;
            this.lbl_WWindspeed.BackColor = System.Drawing.Color.Transparent;
            this.lbl_WWindspeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WWindspeed.ForeColor = System.Drawing.Color.BlueViolet;
            this.lbl_WWindspeed.Location = new System.Drawing.Point(958, 805);
            this.lbl_WWindspeed.Name = "lbl_WWindspeed";
            this.lbl_WWindspeed.Size = new System.Drawing.Size(0, 29);
            this.lbl_WWindspeed.TabIndex = 38;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.BlueViolet;
            this.label21.Location = new System.Drawing.Point(865, 811);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(93, 20);
            this.label21.TabIndex = 37;
            this.label21.Text = "Windspeed:";
            this.label21.Visible = false;
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.BackColor = System.Drawing.Color.Red;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.Red;
            this.button8.Location = new System.Drawing.Point(1143, -2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(22, 22);
            this.button8.TabIndex = 39;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Visible = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // lbl_Warning
            // 
            this.lbl_Warning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Warning.AutoSize = true;
            this.lbl_Warning.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Warning.ForeColor = System.Drawing.Color.Tomato;
            this.lbl_Warning.Location = new System.Drawing.Point(441, 418);
            this.lbl_Warning.Name = "lbl_Warning";
            this.lbl_Warning.Size = new System.Drawing.Size(422, 73);
            this.lbl_Warning.TabIndex = 40;
            this.lbl_Warning.Text = "! WARNING !";
            this.lbl_Warning.Visible = false;
            // 
            // lbl_Warning2
            // 
            this.lbl_Warning2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Warning2.AutoSize = true;
            this.lbl_Warning2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Warning2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Warning2.ForeColor = System.Drawing.Color.Tomato;
            this.lbl_Warning2.Location = new System.Drawing.Point(624, 491);
            this.lbl_Warning2.Name = "lbl_Warning2";
            this.lbl_Warning2.Size = new System.Drawing.Size(0, 42);
            this.lbl_Warning2.TabIndex = 41;
            this.lbl_Warning2.Visible = false;
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.Color.ForestGreen;
            this.button9.Location = new System.Drawing.Point(1117, -2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(23, 22);
            this.button9.TabIndex = 39;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Visible = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // VUMeter
            // 
            this.VUMeter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VUMeter.Location = new System.Drawing.Point(6, 845);
            this.VUMeter.Name = "VUMeter";
            this.VUMeter.Size = new System.Drawing.Size(1152, 15);
            this.VUMeter.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.VUMeter.TabIndex = 43;
            this.VUMeter.Value = 10;
            this.VUMeter.Visible = false;
            // 
            // commandbox
            // 
            this.commandbox.BackColor = System.Drawing.Color.Black;
            this.commandbox.ForeColor = System.Drawing.Color.BlueViolet;
            this.commandbox.FormattingEnabled = true;
            this.commandbox.Location = new System.Drawing.Point(74, 185);
            this.commandbox.Name = "commandbox";
            this.commandbox.Size = new System.Drawing.Size(225, 420);
            this.commandbox.TabIndex = 44;
            this.commandbox.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.BlueViolet;
            this.label1.Location = new System.Drawing.Point(402, 775);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "CPU Usage:";
            this.label1.Visible = false;
            // 
            // CPUmonitor
            // 
            this.CPUmonitor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CPUmonitor.AutoSize = true;
            this.CPUmonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUmonitor.ForeColor = System.Drawing.Color.BlueViolet;
            this.CPUmonitor.Location = new System.Drawing.Point(502, 775);
            this.CPUmonitor.Name = "CPUmonitor";
            this.CPUmonitor.Size = new System.Drawing.Size(0, 25);
            this.CPUmonitor.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.BlueViolet;
            this.label3.Location = new System.Drawing.Point(402, 811);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "RAM Usage:";
            this.label3.Visible = false;
            // 
            // RAMmonitor
            // 
            this.RAMmonitor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RAMmonitor.AutoSize = true;
            this.RAMmonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RAMmonitor.ForeColor = System.Drawing.Color.BlueViolet;
            this.RAMmonitor.Location = new System.Drawing.Point(504, 811);
            this.RAMmonitor.Name = "RAMmonitor";
            this.RAMmonitor.Size = new System.Drawing.Size(0, 25);
            this.RAMmonitor.TabIndex = 48;
            // 
            // systemInfo_Timer
            // 
            this.systemInfo_Timer.Enabled = true;
            this.systemInfo_Timer.Interval = 1500;
            this.systemInfo_Timer.Tick += new System.EventHandler(this.UsageTimer_Tick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.BlueViolet;
            this.label2.Location = new System.Drawing.Point(399, 718);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 33);
            this.label2.TabIndex = 49;
            this.label2.Text = "System Information";
            this.label2.Visible = false;
            // 
            // vumeter_Timer
            // 
            this.vumeter_Timer.Enabled = true;
            this.vumeter_Timer.Interval = 1;
            this.vumeter_Timer.Tick += new System.EventHandler(this.vumeter_Timer_Tick);
            // 
            // netConnectivity_Timer
            // 
            this.netConnectivity_Timer.Enabled = true;
            this.netConnectivity_Timer.Interval = 1;
            this.netConnectivity_Timer.Tick += new System.EventHandler(this.netConnectivity_Timer_Tick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.BackgroundImage = global::David.Properties.Resources.Recycle_Bin;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 309);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 55);
            this.button3.TabIndex = 2;
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Black;
            this.button7.BackgroundImage = global::David.Properties.Resources.Settings;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(0, 555);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(65, 55);
            this.button7.TabIndex = 6;
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.BackgroundImage = global::David.Properties.Resources.Google;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(0, 370);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(65, 55);
            this.button6.TabIndex = 5;
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Black;
            this.button5.BackgroundImage = global::David.Properties.Resources.twitter;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(0, 494);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(65, 55);
            this.button5.TabIndex = 4;
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.BackgroundImage = global::David.Properties.Resources.Facebook;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(0, 432);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(65, 55);
            this.button4.TabIndex = 3;
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.BackgroundImage = global::David.Properties.Resources.Documents;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 55);
            this.button2.TabIndex = 1;
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.BackgroundImage = global::David.Properties.Resources.Computer;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(-53, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 55);
            this.button1.TabIndex = 0;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // weather_Timer
            // 
            this.weather_Timer.Enabled = true;
            this.weather_Timer.Interval = 10000;
            this.weather_Timer.Tick += new System.EventHandler(this.weather_Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1148, 838);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RAMmonitor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CPUmonitor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.commandbox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.VUMeter);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_Warning2);
            this.Controls.Add(this.lbl_Warning);
            this.Controls.Add(this.lbl_WWindspeed);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lbl_WHumidity);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lbl_WCondition);
            this.Controls.Add(this.lbl_WTemperature);
            this.Controls.Add(this.lbl_WLocation);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_NetConnection);
            this.Controls.Add(this.lbl_Meridian);
            this.Controls.Add(this.lbl_Time);
            this.Controls.Add(this.lbl_LoggedIn);
            this.Controls.Add(this.lbl_BatteryRunning);
            this.Controls.Add(this.lbl_BatteryPercent);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DAVID (Artificial Intelligence System)";
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Label lbl_Meridian;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_BatteryPercent;
        private System.Windows.Forms.Label lbl_BatteryRunning;
        private System.Windows.Forms.Timer time_Timer;
        private System.Windows.Forms.Timer shutdown_Timer;
        private System.Windows.Forms.Label lbl_LoggedIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_NetConnection;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_WLocation;
        private System.Windows.Forms.Label lbl_WTemperature;
        private System.Windows.Forms.Label lbl_WCondition;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbl_WHumidity;
        private System.Windows.Forms.Label lbl_WWindspeed;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label lbl_Warning;
        private System.Windows.Forms.Label lbl_Warning2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ProgressBar VUMeter;
        private System.Windows.Forms.ListBox commandbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CPUmonitor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label RAMmonitor;
        private System.Windows.Forms.Timer systemInfo_Timer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer vumeter_Timer;
        private System.Windows.Forms.Timer netConnectivity_Timer;
        private System.Windows.Forms.Timer weather_Timer;
    }
}

