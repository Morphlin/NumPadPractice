namespace NumPadPractice
{
    partial class FormPractice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPractice));
            this.LabelPracticeSingle = new System.Windows.Forms.Label();
            this.TimerDisplayWatch = new System.Windows.Forms.Timer(this.components);
            this.TabControlPractice = new System.Windows.Forms.TabControl();
            this.TabPageSingle = new System.Windows.Forms.TabPage();
            this.LabelInstructionSingle = new System.Windows.Forms.Label();
            this.CheckBoxSymbolsSingle = new System.Windows.Forms.CheckBox();
            this.LabelKphSingle = new System.Windows.Forms.Label();
            this.LabelBadSingle = new System.Windows.Forms.Label();
            this.LabelGoodSingle = new System.Windows.Forms.Label();
            this.LabelTimeSingle = new System.Windows.Forms.Label();
            this.ButtonStopSingle = new System.Windows.Forms.Button();
            this.ButtonStartSingle = new System.Windows.Forms.Button();
            this.TabPageMultiple = new System.Windows.Forms.TabPage();
            this.LabelKphAverageMultiple = new System.Windows.Forms.Label();
            this.CheckBoxSymbolsMultiple = new System.Windows.Forms.CheckBox();
            this.LabelKphMultiple = new System.Windows.Forms.Label();
            this.LabelBadMultiple = new System.Windows.Forms.Label();
            this.LabelGoodMultiple = new System.Windows.Forms.Label();
            this.LabelTimeMultiple = new System.Windows.Forms.Label();
            this.ButtonStopMultiple = new System.Windows.Forms.Button();
            this.ButtonStartMultiple = new System.Windows.Forms.Button();
            this.LabelInstructionsMultiple = new System.Windows.Forms.Label();
            this.TableLayoutPanelMultiple = new System.Windows.Forms.TableLayoutPanel();
            this.LabelDigitMultiple2 = new System.Windows.Forms.Label();
            this.LabelDigitMultiple8 = new System.Windows.Forms.Label();
            this.LabelDigitMultiple7 = new System.Windows.Forms.Label();
            this.LabelDigitMultiple6 = new System.Windows.Forms.Label();
            this.LabelDigitMultiple5 = new System.Windows.Forms.Label();
            this.LabelDigitMultiple4 = new System.Windows.Forms.Label();
            this.LabelDigitMultiple3 = new System.Windows.Forms.Label();
            this.LabelDigitMultiple1 = new System.Windows.Forms.Label();
            this.TabControlPractice.SuspendLayout();
            this.TabPageSingle.SuspendLayout();
            this.TabPageMultiple.SuspendLayout();
            this.TableLayoutPanelMultiple.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelPracticeSingle
            // 
            this.LabelPracticeSingle.BackColor = System.Drawing.SystemColors.Window;
            this.LabelPracticeSingle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelPracticeSingle.Location = new System.Drawing.Point(3, 3);
            this.LabelPracticeSingle.Name = "LabelPracticeSingle";
            this.LabelPracticeSingle.Size = new System.Drawing.Size(617, 392);
            this.LabelPracticeSingle.TabIndex = 0;
            this.LabelPracticeSingle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelPracticeSingle.Resize += new System.EventHandler(this.LabelPracticeSingle_Resize);
            // 
            // TimerDisplayWatch
            // 
            this.TimerDisplayWatch.Tick += new System.EventHandler(this.TimerDisplayWatch_Tick);
            // 
            // TabControlPractice
            // 
            this.TabControlPractice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControlPractice.Controls.Add(this.TabPageSingle);
            this.TabControlPractice.Controls.Add(this.TabPageMultiple);
            this.TabControlPractice.Location = new System.Drawing.Point(8, 9);
            this.TabControlPractice.Name = "TabControlPractice";
            this.TabControlPractice.SelectedIndex = 0;
            this.TabControlPractice.Size = new System.Drawing.Size(631, 424);
            this.TabControlPractice.TabIndex = 7;
            this.TabControlPractice.SelectedIndexChanged += new System.EventHandler(this.TabControlPractice_SelectedIndexChanged);
            this.TabControlPractice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormDisplay_KeyDown);
            // 
            // TabPageSingle
            // 
            this.TabPageSingle.Controls.Add(this.LabelInstructionSingle);
            this.TabPageSingle.Controls.Add(this.CheckBoxSymbolsSingle);
            this.TabPageSingle.Controls.Add(this.LabelKphSingle);
            this.TabPageSingle.Controls.Add(this.LabelBadSingle);
            this.TabPageSingle.Controls.Add(this.LabelGoodSingle);
            this.TabPageSingle.Controls.Add(this.LabelTimeSingle);
            this.TabPageSingle.Controls.Add(this.ButtonStopSingle);
            this.TabPageSingle.Controls.Add(this.ButtonStartSingle);
            this.TabPageSingle.Controls.Add(this.LabelPracticeSingle);
            this.TabPageSingle.Location = new System.Drawing.Point(4, 22);
            this.TabPageSingle.Name = "TabPageSingle";
            this.TabPageSingle.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageSingle.Size = new System.Drawing.Size(623, 398);
            this.TabPageSingle.TabIndex = 0;
            this.TabPageSingle.Text = "Single Number Practice";
            this.TabPageSingle.UseVisualStyleBackColor = true;
            // 
            // LabelInstructionSingle
            // 
            this.LabelInstructionSingle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelInstructionSingle.Location = new System.Drawing.Point(32, 41);
            this.LabelInstructionSingle.Name = "LabelInstructionSingle";
            this.LabelInstructionSingle.Size = new System.Drawing.Size(559, 316);
            this.LabelInstructionSingle.TabIndex = 14;
            this.LabelInstructionSingle.Text = "Click Start or pres Enter to begin.";
            this.LabelInstructionSingle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CheckBoxSymbolsSingle
            // 
            this.CheckBoxSymbolsSingle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBoxSymbolsSingle.AutoSize = true;
            this.CheckBoxSymbolsSingle.Location = new System.Drawing.Point(469, 372);
            this.CheckBoxSymbolsSingle.Name = "CheckBoxSymbolsSingle";
            this.CheckBoxSymbolsSingle.Size = new System.Drawing.Size(65, 17);
            this.CheckBoxSymbolsSingle.TabIndex = 2;
            this.CheckBoxSymbolsSingle.Text = "Symbols";
            this.CheckBoxSymbolsSingle.UseVisualStyleBackColor = true;
            // 
            // LabelKphSingle
            // 
            this.LabelKphSingle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelKphSingle.AutoSize = true;
            this.LabelKphSingle.Location = new System.Drawing.Point(350, 373);
            this.LabelKphSingle.Name = "LabelKphSingle";
            this.LabelKphSingle.Size = new System.Drawing.Size(54, 13);
            this.LabelKphSingle.TabIndex = 13;
            this.LabelKphSingle.Text = "KPH :     0";
            this.LabelKphSingle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelBadSingle
            // 
            this.LabelBadSingle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelBadSingle.AutoSize = true;
            this.LabelBadSingle.Location = new System.Drawing.Point(284, 373);
            this.LabelBadSingle.Name = "LabelBadSingle";
            this.LabelBadSingle.Size = new System.Drawing.Size(47, 13);
            this.LabelBadSingle.TabIndex = 12;
            this.LabelBadSingle.Text = "Error : 0";
            this.LabelBadSingle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelGoodSingle
            // 
            this.LabelGoodSingle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelGoodSingle.AutoSize = true;
            this.LabelGoodSingle.Location = new System.Drawing.Point(213, 373);
            this.LabelGoodSingle.Name = "LabelGoodSingle";
            this.LabelGoodSingle.Size = new System.Drawing.Size(52, 13);
            this.LabelGoodSingle.TabIndex = 11;
            this.LabelGoodSingle.Text = "Count : 0";
            this.LabelGoodSingle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelTimeSingle
            // 
            this.LabelTimeSingle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelTimeSingle.AutoSize = true;
            this.LabelTimeSingle.Location = new System.Drawing.Point(94, 373);
            this.LabelTimeSingle.Name = "LabelTimeSingle";
            this.LabelTimeSingle.Size = new System.Drawing.Size(97, 13);
            this.LabelTimeSingle.TabIndex = 10;
            this.LabelTimeSingle.Text = "Time :  0h 00m 00s";
            this.LabelTimeSingle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ButtonStopSingle
            // 
            this.ButtonStopSingle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonStopSingle.Enabled = false;
            this.ButtonStopSingle.Location = new System.Drawing.Point(539, 368);
            this.ButtonStopSingle.Name = "ButtonStopSingle";
            this.ButtonStopSingle.Size = new System.Drawing.Size(75, 23);
            this.ButtonStopSingle.TabIndex = 1;
            this.ButtonStopSingle.Text = "Stop";
            this.ButtonStopSingle.UseVisualStyleBackColor = true;
            this.ButtonStopSingle.Click += new System.EventHandler(this.ButtonStopSingle_Click);
            this.ButtonStopSingle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormDisplay_KeyDown);
            // 
            // ButtonStartSingle
            // 
            this.ButtonStartSingle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonStartSingle.Location = new System.Drawing.Point(6, 368);
            this.ButtonStartSingle.Name = "ButtonStartSingle";
            this.ButtonStartSingle.Size = new System.Drawing.Size(75, 23);
            this.ButtonStartSingle.TabIndex = 0;
            this.ButtonStartSingle.Text = "Start";
            this.ButtonStartSingle.UseVisualStyleBackColor = true;
            this.ButtonStartSingle.Click += new System.EventHandler(this.ButtonStartSingle_Click);
            this.ButtonStartSingle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormDisplay_KeyDown);
            // 
            // TabPageMultiple
            // 
            this.TabPageMultiple.Controls.Add(this.LabelKphAverageMultiple);
            this.TabPageMultiple.Controls.Add(this.CheckBoxSymbolsMultiple);
            this.TabPageMultiple.Controls.Add(this.LabelKphMultiple);
            this.TabPageMultiple.Controls.Add(this.LabelBadMultiple);
            this.TabPageMultiple.Controls.Add(this.LabelGoodMultiple);
            this.TabPageMultiple.Controls.Add(this.LabelTimeMultiple);
            this.TabPageMultiple.Controls.Add(this.ButtonStopMultiple);
            this.TabPageMultiple.Controls.Add(this.ButtonStartMultiple);
            this.TabPageMultiple.Controls.Add(this.LabelInstructionsMultiple);
            this.TabPageMultiple.Controls.Add(this.TableLayoutPanelMultiple);
            this.TabPageMultiple.Location = new System.Drawing.Point(4, 22);
            this.TabPageMultiple.Name = "TabPageMultiple";
            this.TabPageMultiple.Padding = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.TabPageMultiple.Size = new System.Drawing.Size(623, 398);
            this.TabPageMultiple.TabIndex = 1;
            this.TabPageMultiple.Text = "Multiple Numbers Practice";
            this.TabPageMultiple.UseVisualStyleBackColor = true;
            // 
            // LabelKphAverageMultiple
            // 
            this.LabelKphAverageMultiple.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelKphAverageMultiple.Location = new System.Drawing.Point(391, 15);
            this.LabelKphAverageMultiple.Name = "LabelKphAverageMultiple";
            this.LabelKphAverageMultiple.Size = new System.Drawing.Size(216, 13);
            this.LabelKphAverageMultiple.TabIndex = 23;
            this.LabelKphAverageMultiple.Text = "Average KPH : 0";
            this.LabelKphAverageMultiple.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CheckBoxSymbolsMultiple
            // 
            this.CheckBoxSymbolsMultiple.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBoxSymbolsMultiple.AutoSize = true;
            this.CheckBoxSymbolsMultiple.Location = new System.Drawing.Point(469, 372);
            this.CheckBoxSymbolsMultiple.Name = "CheckBoxSymbolsMultiple";
            this.CheckBoxSymbolsMultiple.Size = new System.Drawing.Size(65, 17);
            this.CheckBoxSymbolsMultiple.TabIndex = 2;
            this.CheckBoxSymbolsMultiple.Text = "Symbols";
            this.CheckBoxSymbolsMultiple.UseVisualStyleBackColor = true;
            // 
            // LabelKphMultiple
            // 
            this.LabelKphMultiple.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelKphMultiple.AutoSize = true;
            this.LabelKphMultiple.Location = new System.Drawing.Point(350, 373);
            this.LabelKphMultiple.Name = "LabelKphMultiple";
            this.LabelKphMultiple.Size = new System.Drawing.Size(54, 13);
            this.LabelKphMultiple.TabIndex = 20;
            this.LabelKphMultiple.Text = "KPH :     0";
            this.LabelKphMultiple.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelBadMultiple
            // 
            this.LabelBadMultiple.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelBadMultiple.AutoSize = true;
            this.LabelBadMultiple.Location = new System.Drawing.Point(284, 373);
            this.LabelBadMultiple.Name = "LabelBadMultiple";
            this.LabelBadMultiple.Size = new System.Drawing.Size(47, 13);
            this.LabelBadMultiple.TabIndex = 19;
            this.LabelBadMultiple.Text = "Error : 0";
            this.LabelBadMultiple.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelGoodMultiple
            // 
            this.LabelGoodMultiple.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelGoodMultiple.AutoSize = true;
            this.LabelGoodMultiple.Location = new System.Drawing.Point(213, 373);
            this.LabelGoodMultiple.Name = "LabelGoodMultiple";
            this.LabelGoodMultiple.Size = new System.Drawing.Size(52, 13);
            this.LabelGoodMultiple.TabIndex = 18;
            this.LabelGoodMultiple.Text = "Count : 0";
            this.LabelGoodMultiple.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelTimeMultiple
            // 
            this.LabelTimeMultiple.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelTimeMultiple.AutoSize = true;
            this.LabelTimeMultiple.Location = new System.Drawing.Point(94, 373);
            this.LabelTimeMultiple.Name = "LabelTimeMultiple";
            this.LabelTimeMultiple.Size = new System.Drawing.Size(97, 13);
            this.LabelTimeMultiple.TabIndex = 17;
            this.LabelTimeMultiple.Text = "Time :  0h 00m 00s";
            this.LabelTimeMultiple.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ButtonStopMultiple
            // 
            this.ButtonStopMultiple.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonStopMultiple.Enabled = false;
            this.ButtonStopMultiple.Location = new System.Drawing.Point(539, 368);
            this.ButtonStopMultiple.Name = "ButtonStopMultiple";
            this.ButtonStopMultiple.Size = new System.Drawing.Size(75, 23);
            this.ButtonStopMultiple.TabIndex = 1;
            this.ButtonStopMultiple.Text = "Stop";
            this.ButtonStopMultiple.UseVisualStyleBackColor = true;
            this.ButtonStopMultiple.Click += new System.EventHandler(this.ButtonStopMultiple_Click);
            this.ButtonStopMultiple.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormDisplay_KeyDown);
            // 
            // ButtonStartMultiple
            // 
            this.ButtonStartMultiple.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonStartMultiple.Location = new System.Drawing.Point(6, 368);
            this.ButtonStartMultiple.Name = "ButtonStartMultiple";
            this.ButtonStartMultiple.Size = new System.Drawing.Size(75, 23);
            this.ButtonStartMultiple.TabIndex = 0;
            this.ButtonStartMultiple.Text = "Start";
            this.ButtonStartMultiple.UseVisualStyleBackColor = true;
            this.ButtonStartMultiple.Click += new System.EventHandler(this.ButtonStartMultiple_Click);
            this.ButtonStartMultiple.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormDisplay_KeyDown);
            // 
            // LabelInstructionsMultiple
            // 
            this.LabelInstructionsMultiple.Location = new System.Drawing.Point(31, 38);
            this.LabelInstructionsMultiple.Name = "LabelInstructionsMultiple";
            this.LabelInstructionsMultiple.Size = new System.Drawing.Size(561, 322);
            this.LabelInstructionsMultiple.TabIndex = 21;
            this.LabelInstructionsMultiple.Text = "Click Start or pres Enter to begin.";
            this.LabelInstructionsMultiple.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TableLayoutPanelMultiple
            // 
            this.TableLayoutPanelMultiple.ColumnCount = 8;
            this.TableLayoutPanelMultiple.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TableLayoutPanelMultiple.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TableLayoutPanelMultiple.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TableLayoutPanelMultiple.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TableLayoutPanelMultiple.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TableLayoutPanelMultiple.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TableLayoutPanelMultiple.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TableLayoutPanelMultiple.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TableLayoutPanelMultiple.Controls.Add(this.LabelDigitMultiple2, 0, 0);
            this.TableLayoutPanelMultiple.Controls.Add(this.LabelDigitMultiple8, 6, 0);
            this.TableLayoutPanelMultiple.Controls.Add(this.LabelDigitMultiple7, 5, 0);
            this.TableLayoutPanelMultiple.Controls.Add(this.LabelDigitMultiple6, 4, 0);
            this.TableLayoutPanelMultiple.Controls.Add(this.LabelDigitMultiple5, 3, 0);
            this.TableLayoutPanelMultiple.Controls.Add(this.LabelDigitMultiple4, 2, 0);
            this.TableLayoutPanelMultiple.Controls.Add(this.LabelDigitMultiple3, 1, 0);
            this.TableLayoutPanelMultiple.Controls.Add(this.LabelDigitMultiple1, 0, 0);
            this.TableLayoutPanelMultiple.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanelMultiple.Location = new System.Drawing.Point(12, 3);
            this.TableLayoutPanelMultiple.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.TableLayoutPanelMultiple.Name = "TableLayoutPanelMultiple";
            this.TableLayoutPanelMultiple.RowCount = 1;
            this.TableLayoutPanelMultiple.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanelMultiple.Size = new System.Drawing.Size(608, 392);
            this.TableLayoutPanelMultiple.TabIndex = 22;
            // 
            // LabelDigitMultiple2
            // 
            this.LabelDigitMultiple2.AutoSize = true;
            this.LabelDigitMultiple2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelDigitMultiple2.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDigitMultiple2.Location = new System.Drawing.Point(76, 0);
            this.LabelDigitMultiple2.Margin = new System.Windows.Forms.Padding(0);
            this.LabelDigitMultiple2.Name = "LabelDigitMultiple2";
            this.LabelDigitMultiple2.Size = new System.Drawing.Size(76, 392);
            this.LabelDigitMultiple2.TabIndex = 7;
            this.LabelDigitMultiple2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelDigitMultiple2.Resize += new System.EventHandler(this.LabelDigitMultiple_Resize);
            // 
            // LabelDigitMultiple8
            // 
            this.LabelDigitMultiple8.AutoSize = true;
            this.LabelDigitMultiple8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelDigitMultiple8.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDigitMultiple8.Location = new System.Drawing.Point(532, 0);
            this.LabelDigitMultiple8.Margin = new System.Windows.Forms.Padding(0);
            this.LabelDigitMultiple8.Name = "LabelDigitMultiple8";
            this.LabelDigitMultiple8.Size = new System.Drawing.Size(76, 392);
            this.LabelDigitMultiple8.TabIndex = 6;
            this.LabelDigitMultiple8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelDigitMultiple8.Resize += new System.EventHandler(this.LabelDigitMultiple_Resize);
            // 
            // LabelDigitMultiple7
            // 
            this.LabelDigitMultiple7.AutoSize = true;
            this.LabelDigitMultiple7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelDigitMultiple7.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDigitMultiple7.Location = new System.Drawing.Point(456, 0);
            this.LabelDigitMultiple7.Margin = new System.Windows.Forms.Padding(0);
            this.LabelDigitMultiple7.Name = "LabelDigitMultiple7";
            this.LabelDigitMultiple7.Size = new System.Drawing.Size(76, 392);
            this.LabelDigitMultiple7.TabIndex = 5;
            this.LabelDigitMultiple7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelDigitMultiple7.Resize += new System.EventHandler(this.LabelDigitMultiple_Resize);
            // 
            // LabelDigitMultiple6
            // 
            this.LabelDigitMultiple6.AutoSize = true;
            this.LabelDigitMultiple6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelDigitMultiple6.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDigitMultiple6.Location = new System.Drawing.Point(380, 0);
            this.LabelDigitMultiple6.Margin = new System.Windows.Forms.Padding(0);
            this.LabelDigitMultiple6.Name = "LabelDigitMultiple6";
            this.LabelDigitMultiple6.Size = new System.Drawing.Size(76, 392);
            this.LabelDigitMultiple6.TabIndex = 4;
            this.LabelDigitMultiple6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelDigitMultiple6.Resize += new System.EventHandler(this.LabelDigitMultiple_Resize);
            // 
            // LabelDigitMultiple5
            // 
            this.LabelDigitMultiple5.AutoSize = true;
            this.LabelDigitMultiple5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelDigitMultiple5.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDigitMultiple5.Location = new System.Drawing.Point(304, 0);
            this.LabelDigitMultiple5.Margin = new System.Windows.Forms.Padding(0);
            this.LabelDigitMultiple5.Name = "LabelDigitMultiple5";
            this.LabelDigitMultiple5.Size = new System.Drawing.Size(76, 392);
            this.LabelDigitMultiple5.TabIndex = 3;
            this.LabelDigitMultiple5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelDigitMultiple5.Resize += new System.EventHandler(this.LabelDigitMultiple_Resize);
            // 
            // LabelDigitMultiple4
            // 
            this.LabelDigitMultiple4.AutoSize = true;
            this.LabelDigitMultiple4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelDigitMultiple4.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDigitMultiple4.Location = new System.Drawing.Point(228, 0);
            this.LabelDigitMultiple4.Margin = new System.Windows.Forms.Padding(0);
            this.LabelDigitMultiple4.Name = "LabelDigitMultiple4";
            this.LabelDigitMultiple4.Size = new System.Drawing.Size(76, 392);
            this.LabelDigitMultiple4.TabIndex = 2;
            this.LabelDigitMultiple4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelDigitMultiple4.Resize += new System.EventHandler(this.LabelDigitMultiple_Resize);
            // 
            // LabelDigitMultiple3
            // 
            this.LabelDigitMultiple3.AutoSize = true;
            this.LabelDigitMultiple3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelDigitMultiple3.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDigitMultiple3.Location = new System.Drawing.Point(152, 0);
            this.LabelDigitMultiple3.Margin = new System.Windows.Forms.Padding(0);
            this.LabelDigitMultiple3.Name = "LabelDigitMultiple3";
            this.LabelDigitMultiple3.Size = new System.Drawing.Size(76, 392);
            this.LabelDigitMultiple3.TabIndex = 1;
            this.LabelDigitMultiple3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelDigitMultiple3.Resize += new System.EventHandler(this.LabelDigitMultiple_Resize);
            // 
            // LabelDigitMultiple1
            // 
            this.LabelDigitMultiple1.AutoSize = true;
            this.LabelDigitMultiple1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelDigitMultiple1.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDigitMultiple1.Location = new System.Drawing.Point(0, 0);
            this.LabelDigitMultiple1.Margin = new System.Windows.Forms.Padding(0);
            this.LabelDigitMultiple1.Name = "LabelDigitMultiple1";
            this.LabelDigitMultiple1.Size = new System.Drawing.Size(76, 392);
            this.LabelDigitMultiple1.TabIndex = 0;
            this.LabelDigitMultiple1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelDigitMultiple1.Resize += new System.EventHandler(this.LabelDigitMultiple_Resize);
            // 
            // FormPractice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(644, 441);
            this.Controls.Add(this.TabControlPractice);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(620, 300);
            this.Name = "FormPractice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NumPad Practice";
            this.Load += new System.EventHandler(this.FormDisplay_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormDisplay_KeyDown);
            this.TabControlPractice.ResumeLayout(false);
            this.TabPageSingle.ResumeLayout(false);
            this.TabPageSingle.PerformLayout();
            this.TabPageMultiple.ResumeLayout(false);
            this.TabPageMultiple.PerformLayout();
            this.TableLayoutPanelMultiple.ResumeLayout(false);
            this.TableLayoutPanelMultiple.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelPracticeSingle;
        private System.Windows.Forms.Timer TimerDisplayWatch;
        private System.Windows.Forms.TabControl TabControlPractice;
        private System.Windows.Forms.TabPage TabPageSingle;
        private System.Windows.Forms.TabPage TabPageMultiple;
        private System.Windows.Forms.CheckBox CheckBoxSymbolsMultiple;
        private System.Windows.Forms.Label LabelKphMultiple;
        private System.Windows.Forms.Label LabelBadMultiple;
        private System.Windows.Forms.Label LabelGoodMultiple;
        private System.Windows.Forms.Label LabelTimeMultiple;
        private System.Windows.Forms.Button ButtonStopMultiple;
        private System.Windows.Forms.Button ButtonStartMultiple;
        private System.Windows.Forms.CheckBox CheckBoxSymbolsSingle;
        private System.Windows.Forms.Label LabelKphSingle;
        private System.Windows.Forms.Label LabelBadSingle;
        private System.Windows.Forms.Label LabelGoodSingle;
        private System.Windows.Forms.Label LabelTimeSingle;
        private System.Windows.Forms.Button ButtonStopSingle;
        private System.Windows.Forms.Button ButtonStartSingle;
        private System.Windows.Forms.Label LabelInstructionSingle;
        private System.Windows.Forms.Label LabelInstructionsMultiple;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanelMultiple;
        private System.Windows.Forms.Label LabelDigitMultiple8;
        private System.Windows.Forms.Label LabelDigitMultiple7;
        private System.Windows.Forms.Label LabelDigitMultiple6;
        private System.Windows.Forms.Label LabelDigitMultiple5;
        private System.Windows.Forms.Label LabelDigitMultiple4;
        private System.Windows.Forms.Label LabelDigitMultiple3;
        private System.Windows.Forms.Label LabelDigitMultiple1;
        private System.Windows.Forms.Label LabelDigitMultiple2;
        private System.Windows.Forms.Label LabelKphAverageMultiple;
    }
}