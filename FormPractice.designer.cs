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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CheckBoxSymbolsSingle = new System.Windows.Forms.CheckBox();
            this.LabelKphSingle = new System.Windows.Forms.Label();
            this.LabelBadSingle = new System.Windows.Forms.Label();
            this.LabelGoodSingle = new System.Windows.Forms.Label();
            this.LabelTimeSingle = new System.Windows.Forms.Label();
            this.ButtonStopSingle = new System.Windows.Forms.Button();
            this.ButtonStartSingle = new System.Windows.Forms.Button();
            this.TabPageMultiple = new System.Windows.Forms.TabPage();
            this.CheckBoxSymbolsMultiple = new System.Windows.Forms.CheckBox();
            this.LabelKphMultiple = new System.Windows.Forms.Label();
            this.LabelErrorMultiple = new System.Windows.Forms.Label();
            this.LabelCountMultiple = new System.Windows.Forms.Label();
            this.LabelTimeMultiple = new System.Windows.Forms.Label();
            this.ButtonStopMultiple = new System.Windows.Forms.Button();
            this.ButtonStartMultiple = new System.Windows.Forms.Button();
            this.LabelPracticeMultiple = new System.Windows.Forms.Label();
            this.TabControlPractice.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.TabPageMultiple.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelPracticeSingle
            // 
            this.LabelPracticeSingle.BackColor = System.Drawing.SystemColors.Window;
            this.LabelPracticeSingle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelPracticeSingle.Font = new System.Drawing.Font("Tahoma", 95.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPracticeSingle.Location = new System.Drawing.Point(3, 3);
            this.LabelPracticeSingle.Name = "LabelPracticeSingle";
            this.LabelPracticeSingle.Size = new System.Drawing.Size(619, 398);
            this.LabelPracticeSingle.TabIndex = 0;
            this.LabelPracticeSingle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.TabControlPractice.Controls.Add(this.tabPage1);
            this.TabControlPractice.Controls.Add(this.TabPageMultiple);
            this.TabControlPractice.Location = new System.Drawing.Point(8, 9);
            this.TabControlPractice.Name = "TabControlPractice";
            this.TabControlPractice.SelectedIndex = 0;
            this.TabControlPractice.Size = new System.Drawing.Size(633, 430);
            this.TabControlPractice.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CheckBoxSymbolsSingle);
            this.tabPage1.Controls.Add(this.LabelKphSingle);
            this.tabPage1.Controls.Add(this.LabelBadSingle);
            this.tabPage1.Controls.Add(this.LabelGoodSingle);
            this.tabPage1.Controls.Add(this.LabelTimeSingle);
            this.tabPage1.Controls.Add(this.ButtonStopSingle);
            this.tabPage1.Controls.Add(this.ButtonStartSingle);
            this.tabPage1.Controls.Add(this.LabelPracticeSingle);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(625, 404);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Single Number Practice";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CheckBoxSymbolsSingle
            // 
            this.CheckBoxSymbolsSingle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBoxSymbolsSingle.AutoSize = true;
            this.CheckBoxSymbolsSingle.Location = new System.Drawing.Point(475, 378);
            this.CheckBoxSymbolsSingle.Name = "CheckBoxSymbolsSingle";
            this.CheckBoxSymbolsSingle.Size = new System.Drawing.Size(65, 17);
            this.CheckBoxSymbolsSingle.TabIndex = 8;
            this.CheckBoxSymbolsSingle.Text = "Symbols";
            this.CheckBoxSymbolsSingle.UseVisualStyleBackColor = true;
            this.CheckBoxSymbolsSingle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormDisplay_KeyDown);
            // 
            // LabelKphSingle
            // 
            this.LabelKphSingle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelKphSingle.AutoSize = true;
            this.LabelKphSingle.Location = new System.Drawing.Point(367, 379);
            this.LabelKphSingle.Name = "LabelKphSingle";
            this.LabelKphSingle.Size = new System.Drawing.Size(36, 13);
            this.LabelKphSingle.TabIndex = 13;
            this.LabelKphSingle.Text = "KPH : ";
            // 
            // LabelBadSingle
            // 
            this.LabelBadSingle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelBadSingle.AutoSize = true;
            this.LabelBadSingle.Location = new System.Drawing.Point(301, 379);
            this.LabelBadSingle.Name = "LabelBadSingle";
            this.LabelBadSingle.Size = new System.Drawing.Size(41, 13);
            this.LabelBadSingle.TabIndex = 12;
            this.LabelBadSingle.Text = "Error : ";
            // 
            // LabelGoodSingle
            // 
            this.LabelGoodSingle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelGoodSingle.AutoSize = true;
            this.LabelGoodSingle.Location = new System.Drawing.Point(230, 379);
            this.LabelGoodSingle.Name = "LabelGoodSingle";
            this.LabelGoodSingle.Size = new System.Drawing.Size(46, 13);
            this.LabelGoodSingle.TabIndex = 11;
            this.LabelGoodSingle.Text = "Count : ";
            // 
            // LabelTimeSingle
            // 
            this.LabelTimeSingle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelTimeSingle.AutoSize = true;
            this.LabelTimeSingle.Location = new System.Drawing.Point(111, 379);
            this.LabelTimeSingle.Name = "LabelTimeSingle";
            this.LabelTimeSingle.Size = new System.Drawing.Size(36, 13);
            this.LabelTimeSingle.TabIndex = 10;
            this.LabelTimeSingle.Text = "Time: ";
            // 
            // ButtonStopSingle
            // 
            this.ButtonStopSingle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonStopSingle.Enabled = false;
            this.ButtonStopSingle.Location = new System.Drawing.Point(541, 374);
            this.ButtonStopSingle.Name = "ButtonStopSingle";
            this.ButtonStopSingle.Size = new System.Drawing.Size(75, 23);
            this.ButtonStopSingle.TabIndex = 9;
            this.ButtonStopSingle.Text = "Stop";
            this.ButtonStopSingle.UseVisualStyleBackColor = true;
            this.ButtonStopSingle.Click += new System.EventHandler(this.ButtonStop_Click);
            this.ButtonStopSingle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormDisplay_KeyDown);
            // 
            // ButtonStartSingle
            // 
            this.ButtonStartSingle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonStartSingle.Location = new System.Drawing.Point(9, 374);
            this.ButtonStartSingle.Name = "ButtonStartSingle";
            this.ButtonStartSingle.Size = new System.Drawing.Size(75, 23);
            this.ButtonStartSingle.TabIndex = 7;
            this.ButtonStartSingle.Text = "Start";
            this.ButtonStartSingle.UseVisualStyleBackColor = true;
            this.ButtonStartSingle.Click += new System.EventHandler(this.ButtonStart_Click);
            this.ButtonStartSingle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormDisplay_KeyDown);
            // 
            // TabPageMultiple
            // 
            this.TabPageMultiple.Controls.Add(this.CheckBoxSymbolsMultiple);
            this.TabPageMultiple.Controls.Add(this.LabelKphMultiple);
            this.TabPageMultiple.Controls.Add(this.LabelErrorMultiple);
            this.TabPageMultiple.Controls.Add(this.LabelCountMultiple);
            this.TabPageMultiple.Controls.Add(this.LabelTimeMultiple);
            this.TabPageMultiple.Controls.Add(this.ButtonStopMultiple);
            this.TabPageMultiple.Controls.Add(this.ButtonStartMultiple);
            this.TabPageMultiple.Controls.Add(this.LabelPracticeMultiple);
            this.TabPageMultiple.Location = new System.Drawing.Point(4, 22);
            this.TabPageMultiple.Name = "TabPageMultiple";
            this.TabPageMultiple.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageMultiple.Size = new System.Drawing.Size(625, 404);
            this.TabPageMultiple.TabIndex = 1;
            this.TabPageMultiple.Text = "Multiple Numbers Practice";
            this.TabPageMultiple.UseVisualStyleBackColor = true;
            // 
            // CheckBoxSymbolsMultiple
            // 
            this.CheckBoxSymbolsMultiple.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBoxSymbolsMultiple.AutoSize = true;
            this.CheckBoxSymbolsMultiple.Location = new System.Drawing.Point(475, 378);
            this.CheckBoxSymbolsMultiple.Name = "CheckBoxSymbolsMultiple";
            this.CheckBoxSymbolsMultiple.Size = new System.Drawing.Size(65, 17);
            this.CheckBoxSymbolsMultiple.TabIndex = 15;
            this.CheckBoxSymbolsMultiple.Text = "Symbols";
            this.CheckBoxSymbolsMultiple.UseVisualStyleBackColor = true;
            // 
            // LabelKphMultiple
            // 
            this.LabelKphMultiple.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelKphMultiple.AutoSize = true;
            this.LabelKphMultiple.Location = new System.Drawing.Point(367, 379);
            this.LabelKphMultiple.Name = "LabelKphMultiple";
            this.LabelKphMultiple.Size = new System.Drawing.Size(36, 13);
            this.LabelKphMultiple.TabIndex = 20;
            this.LabelKphMultiple.Text = "KPH : ";
            // 
            // LabelErrorMultiple
            // 
            this.LabelErrorMultiple.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelErrorMultiple.AutoSize = true;
            this.LabelErrorMultiple.Location = new System.Drawing.Point(301, 379);
            this.LabelErrorMultiple.Name = "LabelErrorMultiple";
            this.LabelErrorMultiple.Size = new System.Drawing.Size(41, 13);
            this.LabelErrorMultiple.TabIndex = 19;
            this.LabelErrorMultiple.Text = "Error : ";
            // 
            // LabelCountMultiple
            // 
            this.LabelCountMultiple.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelCountMultiple.AutoSize = true;
            this.LabelCountMultiple.Location = new System.Drawing.Point(230, 379);
            this.LabelCountMultiple.Name = "LabelCountMultiple";
            this.LabelCountMultiple.Size = new System.Drawing.Size(46, 13);
            this.LabelCountMultiple.TabIndex = 18;
            this.LabelCountMultiple.Text = "Count : ";
            // 
            // LabelTimeMultiple
            // 
            this.LabelTimeMultiple.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelTimeMultiple.AutoSize = true;
            this.LabelTimeMultiple.Location = new System.Drawing.Point(111, 379);
            this.LabelTimeMultiple.Name = "LabelTimeMultiple";
            this.LabelTimeMultiple.Size = new System.Drawing.Size(36, 13);
            this.LabelTimeMultiple.TabIndex = 17;
            this.LabelTimeMultiple.Text = "Time: ";
            // 
            // ButtonStopMultiple
            // 
            this.ButtonStopMultiple.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonStopMultiple.Enabled = false;
            this.ButtonStopMultiple.Location = new System.Drawing.Point(541, 374);
            this.ButtonStopMultiple.Name = "ButtonStopMultiple";
            this.ButtonStopMultiple.Size = new System.Drawing.Size(75, 23);
            this.ButtonStopMultiple.TabIndex = 16;
            this.ButtonStopMultiple.Text = "Stop";
            this.ButtonStopMultiple.UseVisualStyleBackColor = true;
            // 
            // ButtonStartMultiple
            // 
            this.ButtonStartMultiple.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonStartMultiple.Location = new System.Drawing.Point(9, 374);
            this.ButtonStartMultiple.Name = "ButtonStartMultiple";
            this.ButtonStartMultiple.Size = new System.Drawing.Size(75, 23);
            this.ButtonStartMultiple.TabIndex = 14;
            this.ButtonStartMultiple.Text = "Start";
            this.ButtonStartMultiple.UseVisualStyleBackColor = true;
            // 
            // LabelPracticeMultiple
            // 
            this.LabelPracticeMultiple.BackColor = System.Drawing.SystemColors.Window;
            this.LabelPracticeMultiple.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelPracticeMultiple.Font = new System.Drawing.Font("Tahoma", 95.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPracticeMultiple.Location = new System.Drawing.Point(3, 3);
            this.LabelPracticeMultiple.Name = "LabelPracticeMultiple";
            this.LabelPracticeMultiple.Size = new System.Drawing.Size(619, 398);
            this.LabelPracticeMultiple.TabIndex = 8;
            this.LabelPracticeMultiple.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPractice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(646, 447);
            this.Controls.Add(this.TabControlPractice);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPractice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NumPad Practice";
            this.Load += new System.EventHandler(this.FormDisplay_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormDisplay_KeyDown);
            this.TabControlPractice.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.TabPageMultiple.ResumeLayout(false);
            this.TabPageMultiple.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelPracticeSingle;
        private System.Windows.Forms.Timer TimerDisplayWatch;
        private System.Windows.Forms.TabControl TabControlPractice;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage TabPageMultiple;
        private System.Windows.Forms.CheckBox CheckBoxSymbolsMultiple;
        private System.Windows.Forms.Label LabelKphMultiple;
        private System.Windows.Forms.Label LabelErrorMultiple;
        private System.Windows.Forms.Label LabelCountMultiple;
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
        private System.Windows.Forms.Label LabelPracticeMultiple;
    }
}