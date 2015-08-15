using System;
using System.Drawing;
using System.Diagnostics;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NumPadPractice
{
    internal partial class FormPractice : Form
    {
        internal FormPractice()
        {
            InitializeComponent();
        }

        private Random Rand;
        private Stopwatch Watch;
        private void FormDisplay_Load(object sender, EventArgs e)
        {
            Rand = new Random(3652165);
            Watch = new Stopwatch();
        }
    
        private KeyValuePair<Keys, string> CurrentKey;
        private bool PracticeEnabled;
        private int GoodCounter;
        private int BadCounter;
        private void FormDisplay_KeyDown(object sender, KeyEventArgs e)
        {
            if (PracticeEnabled)
            {
                LabelPracticeSingle.ForeColor = Color.Black;
                if (e.KeyCode == CurrentKey.Key)
                {
                    CurrentKey = RandomNumPad();
                    LabelPracticeSingle.Text = CurrentKey.Value;
                }
                else
                {
                    BadCounter++;
                    LabelBadSingle.Text = "Error : " + BadCounter;
                    LabelPracticeSingle.ForeColor = Color.Red;
                    System.Media.SystemSounds.Asterisk.Play();
                }
            }
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            GoodCounter = -1;
            BadCounter = 0;
            LabelBadSingle.Text = "Error : " + BadCounter;
            Watch = Stopwatch.StartNew();
            TimerDisplayWatch.Enabled = true;
            CurrentKey = RandomNumPad();
            LabelPracticeSingle.Text = CurrentKey.Value;
            PracticeEnabled = true;
            ButtonStartSingle.Enabled = false;
            ButtonStopSingle.Enabled = true;
            Focus();
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            PracticeEnabled = false;
            Watch.Stop();
            TimerDisplayWatch.Enabled = false;
            ButtonStartSingle.Enabled = true;
            ButtonStopSingle.Enabled = false;
        }

        private void TimerDisplayWatch_Tick(object sender, EventArgs e)
        {
            LabelTimeSingle.Text = string.Format("Time : {0}h {1}m {2}s", Watch.Elapsed.Hours.ToString().PadLeft(2), Watch.Elapsed.Minutes.ToString("00"), Watch.Elapsed.Seconds.ToString("00"), Watch.Elapsed.Milliseconds.ToString("000"));
            var KPH = GoodCounter*(3600000/Watch.Elapsed.TotalMilliseconds);
            LabelKphSingle.Text = string.Format("KPH : {0}", KPH.ToString("0").PadLeft(5));
        }

        private KeyValuePair<Keys,string> RandomNumPad()
        {
            GoodCounter++;
            LabelGoodSingle.Text = "Count : " + GoodCounter;
            switch (Rand.Next(0, CheckBoxSymbolsSingle.Checked ? 15 : 11))
            {
                case 0:
                    return new KeyValuePair<Keys, string>(Keys.NumPad0, "0");
                case 1:
                    return new KeyValuePair<Keys, string>(Keys.NumPad1, "1");
                case 2:
                    return new KeyValuePair<Keys, string>(Keys.NumPad2, "2");
                case 3:
                    return new KeyValuePair<Keys, string>(Keys.NumPad3, "3");
                case 4:
                    return new KeyValuePair<Keys, string>(Keys.NumPad4, "4");
                case 5:
                    return new KeyValuePair<Keys, string>(Keys.NumPad5, "5");
                case 6:
                    return new KeyValuePair<Keys, string>(Keys.NumPad6, "6");
                case 7:
                    return new KeyValuePair<Keys, string>(Keys.NumPad7, "7");
                case 8:
                    return new KeyValuePair<Keys, string>(Keys.NumPad8, "8");
                case 9:
                    return new KeyValuePair<Keys, string>(Keys.NumPad9, "9");
                case 10:
                    return new KeyValuePair<Keys, string>(Keys.Decimal, ".");
                case 11:
                    return new KeyValuePair<Keys, string>(Keys.Enter, "Enter");
                case 12:
                    return new KeyValuePair<Keys, string>(Keys.Divide, "/");
                case 13:
                    return new KeyValuePair<Keys, string>(Keys.Multiply, "*");
                case 14:
                    return new KeyValuePair<Keys, string>(Keys.Add, "+");
                case 15:
                    return new KeyValuePair<Keys, string>(Keys.Subtract, "-");
                default:
                    MessageBox.Show("Error, tell Alex :-)");
                    return new KeyValuePair<Keys, string>(Keys.Control, "Ctrl");
            }
        }
    }
}
