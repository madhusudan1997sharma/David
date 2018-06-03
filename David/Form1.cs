using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Speech;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Media;
using System.Management;
using System.Xml.Linq;
using System.Web;
using NAudio;
using NAudio.CoreAudioApi;

namespace Jerry
{
    public partial class Form1 : Form
    {
        [DllImport("wininet.dll")]
        private static extern bool InternetGetConnectedState(out int Description, int ReservedValue);

        SpeechRecognitionEngine _recognizer = new SpeechRecognitionEngine();
        SpeechSynthesizer Jerry = new SpeechSynthesizer();
        int count = 1;

        private PerformanceCounter cpuCounter;
        private PerformanceCounter ramCounter;

        string QEvent;
        string ProcWindow;
        Random rnd = new Random();
        string Temperature;
        string Condition;
        string Humidity;
        string Windspeed;
        string Town;
        string TFCond;
        string TFHigh;
        string TFLow;
        public Form1()
        {
            InitializeComponent();
            InitialiseCPUCounter();
            InitializeRAMCounter();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;

            _recognizer.SetInputToDefaultAudioDevice();
            RecognitionResult Result = _recognizer.Recognize();
            _recognizer.LoadGrammar(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"D:\Jerry\Jerry\bin\Debug\Commands.txt")))));
            _recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(_recognizer_SpeechRecognized);
            _recognizer.RecognizeAsync(RecognizeMode.Multiple);


            GetWeather();
            DateTime now = DateTime.Now;
            string time = now.GetDateTimeFormats('t')[0];
            PowerStatus p = SystemInformation.PowerStatus;
            progressBar1.Value = (int)(p.BatteryLifePercent * 100);
            lbl_BatteryPercent.Text = string.Format("{0}%", p.BatteryLifePercent * 100);
            lbl_LoggedIn.Text = Environment.UserName;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label8.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label18.Visible = true;
            label21.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            progressBar1.Visible = true;
            textBox1.Visible = true;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            VUMeter.Visible = true;
            if (SystemInformation.PowerStatus.PowerLineStatus == PowerLineStatus.Offline)
            {
                lbl_BatteryRunning.Text = "Running on DC";
            }
            else
            {
                if (SystemInformation.PowerStatus.PowerLineStatus == PowerLineStatus.Online)
                {
                    lbl_BatteryRunning.Text = "Running on AC";
                }
            }
            int Desc;
            if (Form1.InternetGetConnectedState(out Desc, 0))
            {
                if (now.Hour >= 5 && now.Hour < 12)
                {
                    Jerry.SpeakAsync("Goodmorning sir.");
                }
                if (now.Hour >= 12 && now.Hour < 16)
                {
                    Jerry.SpeakAsync("Good afternoon sir.");
                }
                if (now.Hour >= 16)
                {
                    Jerry.SpeakAsync("Good evening sir.");
                }
                Jerry.SpeakAsync("I have deep been uploaded. We are Online and Ready");
                Jerry.SpeakAsync("The weather condition in " + Town + " is " + Condition + " at " + Temperature + " degrees centigrades, with the humidity of" + Humidity + "percent." + "The" + "windspeed" + "is" + Windspeed + "Kilometers per hour");
            }
            else
            {
                if (now.Hour >= 5 && now.Hour < 12)
                {
                    Jerry.SpeakAsync("Goodmorning sir.");
                }
                if (now.Hour >= 12 && now.Hour < 16)
                {
                    Jerry.SpeakAsync("Good afternoon sir.");
                }
                if (now.Hour >= 16)
                {
                    Jerry.SpeakAsync("Good evening sir.");
                }
                Jerry.SpeakAsync("I have deep been uploaded.");
                Jerry.SpeakAsync("It seems that Network Connection is not Available.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "::{20d04fe0-3aea-1069-a2d8-08002b30309d}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Users\\Owner\\Documents");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "::{645FF040-5081-101B-9F08-00AA002F954E}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.facebook.com");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.twitter.com");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.google.com");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void _recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            GetWeather();
            int ranNum = rnd.Next(1, 10);
            string speech = e.Result.Text;

            if (speech == "Hello" || speech == "Hi" || speech == "Hello David" || speech == "Hi David")
            {
                if (ranNum > 4)
                {
                    Jerry.SpeakAsync("Hello sir.");
                }
                else if (ranNum < 5)
                {
                    Jerry.SpeakAsync("Hi sir.");
                }
            }
            else if (speech == "Bye" || speech == "Close" || speech == "Goodbye")
            {
                Jerry.Speak("Goodbye sir.");
                Application.Exit();
            }
            else if (speech == "How are you" || speech == "How are you David")
            {
                Jerry.SpeakAsync("I'm fine sir. Thanks for asking");
            }
            else if (speech == "Whats up" || speech == "Whats up David")
            {
                Jerry.SpeakAsync("Nothing much sir.");
            }
            else if (speech == "Thankyou" || speech == "Thanks")
            {
                Jerry.SpeakAsync("Its my pleasure to help you sir.");
            }
            else if (speech == "Are you there" || speech == "You there" || speech == "Are you there David" || speech == "You there David")
            {
                if (ranNum > 4)
                {
                    Jerry.SpeakAsync("At your service sir.");
                }
                else if (ranNum < 5)
                {
                    Jerry.SpeakAsync("For you sir, always.");
                }
            }
            else if (speech == "What are you doing")
            {
                Jerry.SpeakAsync("Just doing calculations to perform better sir.");
            }
            else if (speech == "David")
            {
                if (ranNum > 4)
                {
                    Jerry.SpeakAsync("Yes sir?");
                }
                else if (ranNum < 5)
                {
                    Jerry.SpeakAsync("How can I help you sir?");
                }
            }
            else if (speech == "Introduce" || speech == "Introduce yourself")
            {
                Jerry.SpeakAsync("Sure Sir. My name is David. I am an Artificially Intelligent, Digital life assistant. I am programmed by Mudhoosoodun Shurma. I can do many things but still I am learning.");
            }
            else if (speech == "Weather" || speech == "Temperature" || speech == "Hows the weather" || speech == "Hows the weather outside")
            {
                if (lbl_NetConnection.Text == "Available")
                {
                    Jerry.SpeakAsync("The weather condition in " + Town + " is " + Condition + " at " + Temperature + " degrees centigrades.");
                }
                else if (lbl_NetConnection.Text == "Not Available")
                {
                    Jerry.SpeakAsync("Sorry. But there is no network connection sir.");
                }
            }
            else if (speech == "Task Manager" || speech == "Open task manager")
            {
                System.Diagnostics.Process.Start("taskmgr.exe");
            }
            else if (speech == "Google" || speech == "Open Google")
            {
                Jerry.SpeakAsync("Opening Google Sir.");
                System.Diagnostics.Process.Start("http://www.google.com");
            }
            else if (speech == "Facebook" || speech == "Open Facebook")
            {
                Jerry.SpeakAsync("Opening Facebook Sir.");
                System.Diagnostics.Process.Start("http://www.facebook.com");
            }
            else if (speech == "Twitter" || speech == "Open Twitter")
            {
                Jerry.SpeakAsync("Opening Twitter Sir.");
                System.Diagnostics.Process.Start("http://www.twitter.com");
            }
            else if (speech == "Youtube" || speech == "Open Youtube")
            {
                Jerry.SpeakAsync("Opening Youtube Sir.");
                System.Diagnostics.Process.Start("http://www.youtube.com");
            }
            else if (speech == "Wikipedia" || speech == "Open Wikipedia")
            {
                Jerry.SpeakAsync("Opening Wikipedia Sir.");
                System.Diagnostics.Process.Start("http://www.wikipedia.com");
            }
            else if (speech == "Picasa" || speech == "Open Picasa")
            {
                System.Diagnostics.Process.Start("file location");
                Jerry.SpeakAsync("Opening picasa sir.");
            }
            else if (speech == "Close picasa")
            {
                ProcWindow = "Picasa";
                StopWindow();
            }
            else if (speech == "Switch window")
            {
                SendKeys.Send("%{TAB " + count + "}");
                count += 1;
            }
            else if (speech == "Time" || speech == "Whats the time")
            {
                string time = DateTime.Now.GetDateTimeFormats('t')[0];
            }
            else if (speech == "Date")
            {
                Jerry.SpeakAsync(DateTime.Now.ToString("MMMM dd, yyyy"));
            }
            else if (speech == "Day")
            {
                Jerry.SpeakAsync(DateTime.Now.ToString("dddd"));
            }
            else if (speech == "Minimize" || speech == "Go")
            {
                if (WindowState == FormWindowState.Normal || WindowState == FormWindowState.Maximized)
                {
                    WindowState = FormWindowState.Minimized;
                    Jerry.SpeakAsync("Alright.");
                }
            }
            else if (speech == "Maximize" || speech == "Comeback")
            {
                if (WindowState == FormWindowState.Minimized)
                {
                    Jerry.SpeakAsync("Here I am sir.");
                    WindowState = FormWindowState.Normal;
                }
            }
            else if (speech == "Commands" || speech == "Command" || speech == "Show Commands")
            {
                commandbox.Text = File.ReadAllText(@"D:\Jerry\Jerry\bin\Debug\Commands.txt");
                commandbox.Visible = true;
            }
            else if (speech == "Hide" || speech == "Hide Commands")
            {
                commandbox.Visible = false;
            }
            else if (speech == "Browser" || speech == "Open Browser")
            {
                System.Diagnostics.Process.Start("http://www.google.com");
            }
            else if (speech == "Settings" || speech == "Setting")
            {
                Form2 frm2 = new Form2();
                frm2.Show();
            }
            else if (speech == "Shutdown" || speech == "Shutdown the system" || speech == "Shutdown the system David")
            {
                QEvent = "shutdown";
                Jerry.SpeakAsync("Warning!. System shutdown.");
                lbl_Warning2.Text = "SYSTEM SHUTDOWN";
                this.lbl_Warning2.Location = new Point(406, 335);
                lbl_Warning2.Visible = true;
                lbl_Warning.Visible = true;
                shutdown_Timer.Enabled = true;
            }
            else if (speech == "Log off")
            {
                QEvent = "logoff";
                Jerry.SpeakAsync("Warning!. System Logging off.");
                lbl_Warning2.Text = "SYSTEM LOGOFF";
                this.lbl_Warning2.Location = new Point(437, 335);
                lbl_Warning2.Visible = true;
                lbl_Warning.Visible = true;
                shutdown_Timer.Enabled = true;
            }
            else if (speech == "Restart")
            {
                QEvent = "restart";
                Jerry.SpeakAsync("Warning!. System restart.");
                lbl_Warning2.Text = "SYSTEM RESTART";
                this.lbl_Warning2.Location = new Point(430, 335);
                lbl_Warning2.Visible = true;
                lbl_Warning.Visible = true;
                shutdown_Timer.Enabled = true;
            }
            else if (speech == "Abort")
            {
                if (shutdown_Timer.Enabled)
                {
                    Jerry.SpeakAsync("Aborting Sir.");
                    lbl_Warning2.Visible = false;
                    lbl_Warning.Visible = false;
                    shutdown_Timer.Enabled = false;
                }
            }
            else if (speech == "Speed up" || speech == "Fast")
            {
                if (shutdown_Timer.Enabled)
                {
                    Jerry.SpeakAsync("Speeding up.");
                    shutdown_Timer.Interval = shutdown_Timer.Interval / 10;
                }
            }
            else if (speech == "Speed down" || speech == "Slow")
            {
                if (shutdown_Timer.Enabled)
                {
                    Jerry.SpeakAsync("Speeding down.");
                    shutdown_Timer.Interval = shutdown_Timer.Interval * 10;
                }
            }
            }

        private void shutdown_timer_Tick(object sender, EventArgs e)
        {
                ComputerTermination();
                shutdown_Timer.Enabled = false;
        }

        private void ComputerTermination()
        {
            string qEvent = QEvent;
            if (qEvent == "restart")
            {
                Process.Start("shutdown", "-r");
            }
            else if (qEvent == "logoff")
            {
                Process.Start("shutdown", "-l");
            }
            else if (qEvent == "shutdown")
            {
                Process.Start("shutdown", "-s");
            }
        }

        private void StopWindow()
        {
            System.Diagnostics.Process[] procs = System.Diagnostics.Process.GetProcessesByName(ProcWindow);
            foreach (System.Diagnostics.Process proc in procs)
            {
                proc.CloseMainWindow();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (textBox1.Text == "")
                {
                }
                else
                {
                    if (radioButton1.Checked)
                    {
                        System.Diagnostics.Process.Start("http://www.google.com/search?q=" + textBox1.Text);
                        textBox1.Text = "";
                    }
                    else if (radioButton2.Checked) 
                    {
                        System.Diagnostics.Process.Start("https://www.google.com/search?tbm=isch&q=" + textBox1.Text);
                        textBox1.Text = "";
                    }
                }
            }
        }

        private void GetWeather()
        {
            int Desc;
            if (Form1.InternetGetConnectedState(out Desc, 0))
            {
                try
                {
                    string query = string.Format("https://weather.yahooapis.com/forecastrss?w=2295400");
                    XmlDocument wdata = new XmlDocument();
                    wdata.Load(query);

                    XmlNamespaceManager manager = new XmlNamespaceManager(wdata.NameTable);
                    manager.AddNamespace("yweather", "http://xml.weather.yahoo.com/ns/rss/1.0");

                    XmlNode channel = wdata.SelectSingleNode("rss").SelectSingleNode("channel");
                    XmlNodeList nodes = wdata.SelectNodes("/rss/channel/item/yweather:forecast", manager);
                    
                    int temp;
                    temp = Convert.ToInt32(channel.SelectSingleNode("item").SelectSingleNode("yweather:condition", manager).Attributes["temp"].Value);
                    Temperature = (((temp-32)*5)/9).ToString();

                    Condition = channel.SelectSingleNode("item").SelectSingleNode("yweather:condition", manager).Attributes["text"].Value;

                    Humidity = channel.SelectSingleNode("yweather:atmosphere", manager).Attributes["humidity"].Value;

                    Windspeed = channel.SelectSingleNode("yweather:wind", manager).Attributes["speed"].Value;

                    Town = channel.SelectSingleNode("yweather:location", manager).Attributes["city"].Value;

                    TFCond = channel.SelectSingleNode("item").SelectSingleNode("yweather:forecast", manager).Attributes["text"].Value;

                    TFHigh = channel.SelectSingleNode("item").SelectSingleNode("yweather:forecast", manager).Attributes["high"].Value;

                    TFLow = channel.SelectSingleNode("item").SelectSingleNode("yweather:forecast", manager).Attributes["low"].Value;
                }
                catch
                {
                    return;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void InitialiseCPUCounter()
        {
            cpuCounter = new PerformanceCounter(
            "Processor",
            "% Processor Time",
            "_Total",
            true
            );
        }

        private void InitializeRAMCounter()
        {
            ramCounter = new PerformanceCounter("Memory", "Available MBytes", true);

        }

        private void UsageTimer_Tick(object sender, EventArgs e)
        {
            this.CPUmonitor.Text = Convert.ToInt32(cpuCounter.NextValue()).ToString() +
            " %";
            float value;
            value = ramCounter.NextValue();
            float final = Convert.ToInt32(100-((value/2048)*100))-1/2;
            this.RAMmonitor.Text = final.ToString() + " %";
        }

        private void time_Timer_Tick(object sender, EventArgs e)
        {
            lbl_Time.Text = DateTime.Now.ToString("hh:mm");
            lbl_Meridian.Text = DateTime.Now.ToString("tt");
            lbl_Date.Text = DateTime.Now.ToString("MMMM dd, yyyy");
        }

        private void vumeter_Timer_Tick(object sender, EventArgs e)
        {
            MMDeviceEnumerator de = new MMDeviceEnumerator();
            MMDevice device = de.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
            float volume = (float)device.AudioMeterInformation.MasterPeakValue * 100;
            VUMeter.Value = (int)volume;
        }

        private void netConnectivity_Timer_Tick(object sender, EventArgs e)
        {
            int Desc;
            if (Form1.InternetGetConnectedState(out Desc, 0))
            {
                lbl_NetConnection.Text = "Available";
                lbl_WLocation.Text = Town;
                lbl_WCondition.Text = Condition;
                lbl_WTemperature.Text = Temperature + ("­ °C");
                lbl_WHumidity.Text = Humidity + (" %");
                lbl_WWindspeed.Text = Windspeed + (" Kmph");
            }
            else
            {
                lbl_NetConnection.Text = "Not Available";
                lbl_WLocation.Text = "?";
                lbl_WCondition.Text = "?";
                lbl_WTemperature.Text = "?";
                lbl_WHumidity.Text = "?";
                lbl_WWindspeed.Text = "?";
            }
        }
        private void weather_Timer_Tick(object sender, EventArgs e)
        {
            GetWeather();
        }
    }
}
