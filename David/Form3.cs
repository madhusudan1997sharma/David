using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.IO;
using System.Threading;
using System.Globalization;

namespace Jerry
{
    public partial class Form3 : Form
    {
        SpeechSynthesizer Jerry = new SpeechSynthesizer();
        SpeechRecognitionEngine _recognizer = new SpeechRecognitionEngine();
        public Form3()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.settings.volume = 70;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            _recognizer.SetInputToDefaultAudioDevice();
            RecognitionResult Result = _recognizer.Recognize();
            _recognizer.LoadGrammar(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"D:\Jerry\Jerry\bin\Debug\Form3.txt")))));
            _recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(_recognizer_SpeechRecognized);
            _recognizer.RecognizeAsync(RecognizeMode.Multiple);
            Jerry.SpeakAsync("Please Speak Password");
        }

        private void _recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string speech = e.Result.Text;
            if (speech == "Wake Up")
            {
                label1.Visible = false;
                Jerry.Speak("Password, accepted");
                Thread.Sleep(600);
                pictureBox1.Visible = true;
                timer1.Enabled = true;
                Jerry.SpeakAsync("Loading preferences and calibrating virtual environment");
                axWindowsMediaPlayer1.URL = @"D:\Jerry\Jerry\Resources\StartingMusic.wav";
                _recognizer.RecognizeAsyncStop();
            }
            else if (speech == "Bye" | speech == "Goodbye" | speech == "Close" | speech == "Exit")
            {
                Random rnd = new Random();
                int rn = rnd.Next(1, 10);
                if (rn < 4)
                {
                    Jerry.SpeakAsync("Bye. Try requesting Mudhoosoodun for the password");
                    Application.Exit();
                }
                else if (rn >= 4 && rn <= 7)
                {
                    Jerry.SpeakAsync("Goodbye. Try requesting Mudhoosoodun to unlock me");
                    Application.Exit();
                }
                else if (rn > 7)
                {
                    Jerry.SpeakAsync("Get Mudhoosoodun permission to enter");
                    Application.Exit();
                }
            }
            else
            {
                Jerry.SpeakAsync("Wrong Password. Request Mudhoosoodun for password");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
            timer1.Enabled = false;
        }
    }
}
