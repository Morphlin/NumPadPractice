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
        private bool PracticeSingleEnabled;
        private int GoodSingleCounter;
        private int BadSingleCounter;
        private bool PracticeMultipleEnabled;
        private int GoodMultipleCounter;
        private int BadMultipleCounter;
        private int PositionMultiple = 1;

        private void FormDisplay_KeyDown(object sender, KeyEventArgs e)
        {
            if (PracticeSingleEnabled)
            {
                LabelPracticeSingle.ForeColor = Color.Black;
                if (e.KeyCode == CurrentKey.Key)
                {
                    GoodSingleCounter++;
                    LabelGoodSingle.Text = "Count : " + GoodSingleCounter;
                    CurrentKey = RandomNumPad(CheckBoxSymbolsSingle.Checked);
                    LabelPracticeSingle.Text = CurrentKey.Value;
                }
                else
                {
                    BadSingleCounter++;
                    LabelBadSingle.Text = "Error : " + BadSingleCounter;
                    LabelPracticeSingle.ForeColor = Color.Red;
                    System.Media.SystemSounds.Asterisk.Play();
                }
            }
            if (PracticeMultipleEnabled)
            {
                switch (PositionMultiple)
                {
                    case 1:
                        LabelDigitMultiple1.ForeColor = Color.Black;
                        if (e.KeyCode == (Keys)LabelDigitMultiple1.Tag)
                        {
                            GoodMultipleCounter++;
                            LabelDigitMultiple1.ForeColor = Color.Green;
                            LabelGoodMultiple.Text = "Count : " + GoodMultipleCounter;
                            PositionMultiple++;
                        }
                        else
                        {
                            BadMultipleCounter++;
                            LabelBadMultiple.Text = "Error : " + BadMultipleCounter;
                            LabelDigitMultiple1.ForeColor = Color.Red;
                            System.Media.SystemSounds.Asterisk.Play();
                        }
                        break;
                    case 2:
                        LabelDigitMultiple2.ForeColor = Color.Black;
                        if (e.KeyCode == (Keys)LabelDigitMultiple2.Tag)
                        {
                            GoodMultipleCounter++;
                            LabelDigitMultiple2.ForeColor = Color.Green;
                            LabelGoodMultiple.Text = "Count : " + GoodMultipleCounter;
                            PositionMultiple++;
                        }
                        else
                        {
                            BadMultipleCounter++;
                            LabelBadMultiple.Text = "Error : " + BadMultipleCounter;
                            LabelDigitMultiple2.ForeColor = Color.Red;
                            System.Media.SystemSounds.Asterisk.Play();
                        }
                        break;
                    case 3:
                        LabelDigitMultiple3.ForeColor = Color.Black;
                        if (e.KeyCode == (Keys)LabelDigitMultiple3.Tag)
                        {
                            GoodMultipleCounter++;
                            LabelDigitMultiple3.ForeColor = Color.Green;
                            LabelGoodMultiple.Text = "Count : " + GoodMultipleCounter;
                            PositionMultiple++;
                        }
                        else
                        {
                            BadMultipleCounter++;
                            LabelBadMultiple.Text = "Error : " + BadMultipleCounter;
                            LabelDigitMultiple3.ForeColor = Color.Red;
                            System.Media.SystemSounds.Asterisk.Play();
                        }
                        break;
                    case 4:
                        LabelDigitMultiple4.ForeColor = Color.Black;
                        if (e.KeyCode == (Keys)LabelDigitMultiple4.Tag)
                        {
                            GoodMultipleCounter++;
                            LabelDigitMultiple4.ForeColor = Color.Green;
                            LabelGoodMultiple.Text = "Count : " + GoodMultipleCounter;
                            PositionMultiple++;
                        }
                        else
                        {
                            BadMultipleCounter++;
                            LabelBadMultiple.Text = "Error : " + BadMultipleCounter;
                            LabelDigitMultiple4.ForeColor = Color.Red;
                            System.Media.SystemSounds.Asterisk.Play();
                        }
                        break;
                    case 5:
                        LabelDigitMultiple5.ForeColor = Color.Black;
                        if (e.KeyCode == (Keys)LabelDigitMultiple5.Tag)
                        {
                            GoodMultipleCounter++;
                            LabelDigitMultiple5.ForeColor = Color.Green;
                            LabelGoodMultiple.Text = "Count : " + GoodMultipleCounter;
                            PositionMultiple++;
                        }
                        else
                        {
                            BadMultipleCounter++;
                            LabelBadMultiple.Text = "Error : " + BadMultipleCounter;
                            LabelDigitMultiple5.ForeColor = Color.Red;
                            System.Media.SystemSounds.Asterisk.Play();
                        }
                        break;
                    case 6:
                        LabelDigitMultiple6.ForeColor = Color.Black;
                        if (e.KeyCode == (Keys)LabelDigitMultiple6.Tag)
                        {
                            GoodMultipleCounter++;
                            LabelDigitMultiple6.ForeColor = Color.Green;
                            LabelGoodMultiple.Text = "Count : " + GoodMultipleCounter;
                            PositionMultiple++;
                        }
                        else
                        {
                            BadMultipleCounter++;
                            LabelBadMultiple.Text = "Error : " + BadMultipleCounter;
                            LabelDigitMultiple6.ForeColor = Color.Red;
                            System.Media.SystemSounds.Asterisk.Play();
                        }
                        break;
                    case 7:
                        LabelDigitMultiple7.ForeColor = Color.Black;
                        if (e.KeyCode == (Keys)LabelDigitMultiple7.Tag)
                        {
                            GoodMultipleCounter++;
                            LabelDigitMultiple7.ForeColor = Color.Green;
                            LabelGoodMultiple.Text = "Count : " + GoodMultipleCounter;
                            PositionMultiple++;
                        }
                        else
                        {
                            BadMultipleCounter++;
                            LabelBadMultiple.Text = "Error : " + BadMultipleCounter;
                            LabelDigitMultiple7.ForeColor = Color.Red;
                            System.Media.SystemSounds.Asterisk.Play();
                        }
                        break;
                    case 8:
                        LabelDigitMultiple8.ForeColor = Color.Black;
                        if (e.KeyCode == (Keys)LabelDigitMultiple8.Tag)
                        {
                            GoodMultipleCounter++;
                            LabelDigitMultiple8.ForeColor = Color.Green;
                            LabelGoodMultiple.Text = "Count : " + GoodMultipleCounter;
                            ButtonStopMultiple_Click(null, null);
                        }
                        else
                        {
                            BadMultipleCounter++;
                            LabelBadMultiple.Text = "Error : " + BadMultipleCounter;
                            LabelDigitMultiple8.ForeColor = Color.Red;
                            System.Media.SystemSounds.Asterisk.Play();
                        }
                        break;
                }
            }
        }

        private void TabControlPractice_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonStopSingle_Click(null, null);
            ButtonStopMultiple_Click(null, null);
        }

        private void LabelPracticeSingle_Resize(object sender, EventArgs e)
        {
            LabelPracticeSingle.Font = new Font(LabelPracticeSingle.Font.FontFamily, Height / 3, LabelPracticeSingle.Font.Style);
        }

        private void ButtonStartSingle_Click(object sender, EventArgs e)
        {
            LabelPracticeSingle_Resize(null, null);
            LabelInstructionSingle.Visible = false;
            LabelPracticeSingle.ForeColor = Color.Black;
            GoodSingleCounter = 0;
            LabelGoodSingle.Text = "Count : " + GoodSingleCounter;
            BadSingleCounter = 0;
            LabelBadSingle.Text = "Error : " + BadSingleCounter;
            Watch = Stopwatch.StartNew();
            TimerDisplayWatch.Enabled = true;
            CurrentKey = RandomNumPad(CheckBoxSymbolsSingle.Checked);
            LabelPracticeSingle.Text = CurrentKey.Value;
            PracticeSingleEnabled = true;
            ButtonStartSingle.Enabled = false;
            ButtonStopSingle.Enabled = true;
            Focus();
        }

        private void ButtonStopSingle_Click(object sender, EventArgs e)
        {
            PracticeSingleEnabled = false;
            LabelPracticeSingle.ForeColor = Color.Gray;
            Watch.Stop();
            TimerDisplayWatch.Enabled = false;
            ButtonStartSingle.Enabled = true;
            ButtonStopSingle.Enabled = false;
        }

        private void ButtonStartMultiple_Click(object sender, EventArgs e)
        {
            foreach (Label Label in TableLayoutPanelMultiple.Controls)
            {
                LabelDigitMultiple_Resize(Label, null);
            }
            LabelInstructionsMultiple.Visible = false;
            GoodMultipleCounter = 0;
            BadMultipleCounter = 0;
            LabelBadMultiple.Text = "Error : " + BadMultipleCounter;
            Watch = Stopwatch.StartNew();
            TimerDisplayWatch.Enabled = true;
            RandomNumPadMultiple(CheckBoxSymbolsMultiple.Checked);
            PracticeMultipleEnabled = true;
            ButtonStartMultiple.Enabled = false;
            CheckBoxSymbolsMultiple.Enabled = false;
            ButtonStopMultiple.Enabled = true;
            Focus();
        }

        private void ButtonStopMultiple_Click(object sender, EventArgs e)
        {
            PracticeMultipleEnabled = false;
            LabelDigitMultiple1.ForeColor = Color.Gray;
            LabelDigitMultiple2.ForeColor = Color.Gray;
            LabelDigitMultiple3.ForeColor = Color.Gray;
            LabelDigitMultiple4.ForeColor = Color.Gray;
            LabelDigitMultiple5.ForeColor = Color.Gray;
            LabelDigitMultiple6.ForeColor = Color.Gray;
            LabelDigitMultiple7.ForeColor = Color.Gray;
            LabelDigitMultiple8.ForeColor = Color.Gray;
            Watch.Stop();
            TimerDisplayWatch.Enabled = false;
            ButtonStartMultiple.Enabled = true;
            CheckBoxSymbolsMultiple.Enabled = true;
            ButtonStopMultiple.Enabled = false;
        }

        private void LabelDigitMultiple_Resize(object sender, EventArgs e)
        {
            ((Label)sender).Font = new Font(((Label)sender).Font.FontFamily, Width / 7, ((Label)sender).Font.Style);
        }

        private void TimerDisplayWatch_Tick(object sender, EventArgs e)
        {
            if (PracticeSingleEnabled)
            {
                LabelTimeSingle.Text = string.Format("Time : {0}h {1}m {2}s", Watch.Elapsed.Hours.ToString().PadLeft(2), Watch.Elapsed.Minutes.ToString("00"), Watch.Elapsed.Seconds.ToString("00"));
                var KPH = GoodSingleCounter * (3600000 / Watch.Elapsed.TotalMilliseconds);
                LabelKphSingle.Text = string.Format("KPH : {0}", KPH.ToString("0").PadLeft(5));
            }
            if (PracticeMultipleEnabled)
            {
                LabelTimeMultiple.Text = string.Format("Time : {0}h {1}m {2}s", Watch.Elapsed.Hours.ToString().PadLeft(2), Watch.Elapsed.Minutes.ToString("00"), Watch.Elapsed.Seconds.ToString("00"));
                var KPH = GoodMultipleCounter * (3600000 / Watch.Elapsed.TotalMilliseconds);
                LabelKphMultiple.Text = string.Format("KPH : {0}", KPH.ToString("0").PadLeft(5));
            }
        }

        private void RandomNumPadMultiple(bool Symbols)
        {
            PositionMultiple = 1;
            LabelDigitMultiple1.ForeColor = Color.Black;
            LabelDigitMultiple2.ForeColor = Color.Black;
            LabelDigitMultiple3.ForeColor = Color.Black;
            LabelDigitMultiple4.ForeColor = Color.Black;
            LabelDigitMultiple5.ForeColor = Color.Black;
            LabelDigitMultiple6.ForeColor = Color.Black;
            LabelDigitMultiple7.ForeColor = Color.Black;
            LabelDigitMultiple8.ForeColor = Color.Black;
            var NumPad1 = RandomNumPad(Symbols);
            LabelDigitMultiple1.Text = NumPad1.Value;
            LabelDigitMultiple1.Tag = NumPad1.Key;
            var NumPad2 = RandomNumPad(Symbols);
            LabelDigitMultiple2.Text = NumPad2.Value;
            LabelDigitMultiple2.Tag = NumPad2.Key;
            var NumPad3 = RandomNumPad(Symbols);
            LabelDigitMultiple3.Text = NumPad3.Value;
            LabelDigitMultiple3.Tag = NumPad3.Key;
            var NumPad4 = RandomNumPad(Symbols);
            LabelDigitMultiple4.Text = NumPad4.Value;
            LabelDigitMultiple4.Tag = NumPad4.Key;
            var NumPad5 = RandomNumPad(Symbols);
            LabelDigitMultiple5.Text = NumPad5.Value;
            LabelDigitMultiple5.Tag = NumPad5.Key;
            var NumPad6 = RandomNumPad(Symbols);
            LabelDigitMultiple6.Text = NumPad6.Value;
            LabelDigitMultiple6.Tag = NumPad6.Key;
            var NumPad7 = RandomNumPad(Symbols);
            LabelDigitMultiple7.Text = NumPad7.Value;
            LabelDigitMultiple7.Tag = NumPad7.Key;
            var NumPad8 = RandomNumPad(Symbols);
            LabelDigitMultiple8.Text = NumPad8.Value;
            LabelDigitMultiple8.Tag = NumPad8.Key;
        }

        private KeyValuePair<Keys, string> RandomNumPad(bool Symbols, bool NoEnter = false)
        {
            switch (Rand.Next(0, Symbols ? (NoEnter ? 14 : 15) : 10))
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
                    return new KeyValuePair<Keys, string>(Keys.Divide, "/");
                case 12:
                    return new KeyValuePair<Keys, string>(Keys.Multiply, "*");
                case 13:
                    return new KeyValuePair<Keys, string>(Keys.Add, "+");
                case 14:
                    return new KeyValuePair<Keys, string>(Keys.Subtract, "-");
                case 15:
                    return new KeyValuePair<Keys, string>(Keys.Enter, "Enter");
                default:
                    MessageBox.Show("Error, tell Alex :-)");
                    return new KeyValuePair<Keys, string>(Keys.Control, "Ctrl");
            }
        }
    }
}
