namespace MathGame2
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.ExerciseLabel = new System.Windows.Forms.Label();
            this.AnswerTB = new System.Windows.Forms.TextBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.CorrectCounterLabel = new System.Windows.Forms.Label();
            this.WrongCounterLabel = new System.Windows.Forms.Label();
            this.StatusGroupBox = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.WrongPB = new System.Windows.Forms.PictureBox();
            this.InputButton = new System.Windows.Forms.Button();
            this.SettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.OneNumCB = new System.Windows.Forms.CheckBox();
            this.MinusCB = new System.Windows.Forms.CheckBox();
            this.ThreeNumCB = new System.Windows.Forms.CheckBox();
            this.TwoNumCB = new System.Windows.Forms.CheckBox();
            this.PlusCB = new System.Windows.Forms.CheckBox();
            this.MultiplyCB = new System.Windows.Forms.CheckBox();
            this.DivideCB = new System.Windows.Forms.CheckBox();
            this.ThreeNumPB = new System.Windows.Forms.PictureBox();
            this.TwoNumPB = new System.Windows.Forms.PictureBox();
            this.OneNumPB = new System.Windows.Forms.PictureBox();
            this.MinusPB = new System.Windows.Forms.PictureBox();
            this.DividePB = new System.Windows.Forms.PictureBox();
            this.MultiplyPB = new System.Windows.Forms.PictureBox();
            this.PlusPB = new System.Windows.Forms.PictureBox();
            this.BackToMenuButton = new System.Windows.Forms.Button();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.MainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SkipButton = new System.Windows.Forms.Button();
            this.StatusGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WrongPB)).BeginInit();
            this.SettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThreeNumPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TwoNumPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OneNumPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinusPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DividePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MultiplyPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlusPB)).BeginInit();
            this.SuspendLayout();
            // 
            // ExerciseLabel
            // 
            this.ExerciseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ExerciseLabel.Font = new System.Drawing.Font("Open Sans", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExerciseLabel.Location = new System.Drawing.Point(182, 27);
            this.ExerciseLabel.Name = "ExerciseLabel";
            this.ExerciseLabel.Size = new System.Drawing.Size(153, 26);
            this.ExerciseLabel.TabIndex = 0;
            this.ExerciseLabel.Text = "9999 + 9999 =";
            this.ExerciseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AnswerTB
            // 
            this.AnswerTB.Font = new System.Drawing.Font("Open Sans", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerTB.Location = new System.Drawing.Point(190, 56);
            this.AnswerTB.Name = "AnswerTB";
            this.AnswerTB.Size = new System.Drawing.Size(136, 31);
            this.AnswerTB.TabIndex = 1;
            // 
            // TimeLabel
            // 
            this.TimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeLabel.Font = new System.Drawing.Font("Open Sans", 11.27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeLabel.Location = new System.Drawing.Point(196, 216);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(124, 23);
            this.TimeLabel.TabIndex = 2;
            this.TimeLabel.Text = "00h:00m:00s";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MainToolTip.SetToolTip(this.TimeLabel, "Time Elpased");
            // 
            // CorrectCounterLabel
            // 
            this.CorrectCounterLabel.AutoSize = true;
            this.CorrectCounterLabel.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CorrectCounterLabel.Location = new System.Drawing.Point(44, 51);
            this.CorrectCounterLabel.Name = "CorrectCounterLabel";
            this.CorrectCounterLabel.Size = new System.Drawing.Size(18, 20);
            this.CorrectCounterLabel.TabIndex = 5;
            this.CorrectCounterLabel.Text = "0";
            this.MainToolTip.SetToolTip(this.CorrectCounterLabel, "Correct Answers");
            // 
            // WrongCounterLabel
            // 
            this.WrongCounterLabel.AutoSize = true;
            this.WrongCounterLabel.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WrongCounterLabel.Location = new System.Drawing.Point(44, 109);
            this.WrongCounterLabel.Name = "WrongCounterLabel";
            this.WrongCounterLabel.Size = new System.Drawing.Size(18, 20);
            this.WrongCounterLabel.TabIndex = 6;
            this.WrongCounterLabel.Text = "0";
            this.MainToolTip.SetToolTip(this.WrongCounterLabel, "Wrong Answers");
            // 
            // StatusGroupBox
            // 
            this.StatusGroupBox.Controls.Add(this.CorrectCounterLabel);
            this.StatusGroupBox.Controls.Add(this.WrongCounterLabel);
            this.StatusGroupBox.Controls.Add(this.pictureBox1);
            this.StatusGroupBox.Controls.Add(this.WrongPB);
            this.StatusGroupBox.Location = new System.Drawing.Point(430, 34);
            this.StatusGroupBox.Name = "StatusGroupBox";
            this.StatusGroupBox.Size = new System.Drawing.Size(74, 180);
            this.StatusGroupBox.TabIndex = 7;
            this.StatusGroupBox.TabStop = false;
            this.StatusGroupBox.Text = "Status";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::MathGame2.Properties.Resources.correct;
            this.pictureBox1.Location = new System.Drawing.Point(13, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.MainToolTip.SetToolTip(this.pictureBox1, "Correct Answers");
            // 
            // WrongPB
            // 
            this.WrongPB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.WrongPB.Image = global::MathGame2.Properties.Resources.wrong;
            this.WrongPB.Location = new System.Drawing.Point(13, 107);
            this.WrongPB.Name = "WrongPB";
            this.WrongPB.Size = new System.Drawing.Size(25, 25);
            this.WrongPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.WrongPB.TabIndex = 4;
            this.WrongPB.TabStop = false;
            this.MainToolTip.SetToolTip(this.WrongPB, "Wrong Answers");
            // 
            // InputButton
            // 
            this.InputButton.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputButton.Location = new System.Drawing.Point(208, 104);
            this.InputButton.Name = "InputButton";
            this.InputButton.Size = new System.Drawing.Size(100, 36);
            this.InputButton.TabIndex = 8;
            this.InputButton.Text = "Input";
            this.InputButton.UseVisualStyleBackColor = true;
            this.InputButton.Click += new System.EventHandler(this.InputButton_Click);
            // 
            // SettingsGroupBox
            // 
            this.SettingsGroupBox.Controls.Add(this.MinusPB);
            this.SettingsGroupBox.Controls.Add(this.DividePB);
            this.SettingsGroupBox.Controls.Add(this.MultiplyPB);
            this.SettingsGroupBox.Controls.Add(this.ThreeNumPB);
            this.SettingsGroupBox.Controls.Add(this.TwoNumPB);
            this.SettingsGroupBox.Controls.Add(this.OneNumPB);
            this.SettingsGroupBox.Controls.Add(this.DivideCB);
            this.SettingsGroupBox.Controls.Add(this.MultiplyCB);
            this.SettingsGroupBox.Controls.Add(this.PlusCB);
            this.SettingsGroupBox.Controls.Add(this.PlusPB);
            this.SettingsGroupBox.Controls.Add(this.TwoNumCB);
            this.SettingsGroupBox.Controls.Add(this.ThreeNumCB);
            this.SettingsGroupBox.Controls.Add(this.MinusCB);
            this.SettingsGroupBox.Controls.Add(this.OneNumCB);
            this.SettingsGroupBox.Location = new System.Drawing.Point(12, 34);
            this.SettingsGroupBox.Name = "SettingsGroupBox";
            this.SettingsGroupBox.Size = new System.Drawing.Size(143, 180);
            this.SettingsGroupBox.TabIndex = 8;
            this.SettingsGroupBox.TabStop = false;
            this.SettingsGroupBox.Text = "Settings";
            // 
            // OneNumCB
            // 
            this.OneNumCB.AutoSize = true;
            this.OneNumCB.Location = new System.Drawing.Point(6, 39);
            this.OneNumCB.Name = "OneNumCB";
            this.OneNumCB.Size = new System.Drawing.Size(15, 14);
            this.OneNumCB.TabIndex = 0;
            this.OneNumCB.UseVisualStyleBackColor = true;
            this.OneNumCB.CheckedChanged += new System.EventHandler(this.OneNumCB_CheckedChanged);
            // 
            // MinusCB
            // 
            this.MinusCB.AutoSize = true;
            this.MinusCB.Location = new System.Drawing.Point(75, 65);
            this.MinusCB.Name = "MinusCB";
            this.MinusCB.Size = new System.Drawing.Size(15, 14);
            this.MinusCB.TabIndex = 1;
            this.MinusCB.UseVisualStyleBackColor = true;
            this.MinusCB.CheckedChanged += new System.EventHandler(this.MinusCB_CheckedChanged);
            // 
            // ThreeNumCB
            // 
            this.ThreeNumCB.AutoSize = true;
            this.ThreeNumCB.Location = new System.Drawing.Point(6, 127);
            this.ThreeNumCB.Name = "ThreeNumCB";
            this.ThreeNumCB.Size = new System.Drawing.Size(15, 14);
            this.ThreeNumCB.TabIndex = 2;
            this.ThreeNumCB.UseVisualStyleBackColor = true;
            this.ThreeNumCB.CheckedChanged += new System.EventHandler(this.ThreeNumCB_CheckedChanged);
            // 
            // TwoNumCB
            // 
            this.TwoNumCB.AutoSize = true;
            this.TwoNumCB.Location = new System.Drawing.Point(6, 83);
            this.TwoNumCB.Name = "TwoNumCB";
            this.TwoNumCB.Size = new System.Drawing.Size(15, 14);
            this.TwoNumCB.TabIndex = 3;
            this.TwoNumCB.UseVisualStyleBackColor = true;
            this.TwoNumCB.CheckedChanged += new System.EventHandler(this.TwoNumCB_CheckedChanged);
            // 
            // PlusCB
            // 
            this.PlusCB.AutoSize = true;
            this.PlusCB.Location = new System.Drawing.Point(75, 29);
            this.PlusCB.Name = "PlusCB";
            this.PlusCB.Size = new System.Drawing.Size(15, 14);
            this.PlusCB.TabIndex = 4;
            this.PlusCB.UseVisualStyleBackColor = true;
            this.PlusCB.CheckedChanged += new System.EventHandler(this.PlusCB_CheckedChanged);
            // 
            // MultiplyCB
            // 
            this.MultiplyCB.AutoSize = true;
            this.MultiplyCB.Location = new System.Drawing.Point(75, 137);
            this.MultiplyCB.Name = "MultiplyCB";
            this.MultiplyCB.Size = new System.Drawing.Size(15, 14);
            this.MultiplyCB.TabIndex = 5;
            this.MultiplyCB.UseVisualStyleBackColor = true;
            this.MultiplyCB.CheckedChanged += new System.EventHandler(this.MultiplyCB_CheckedChanged);
            // 
            // DivideCB
            // 
            this.DivideCB.AutoSize = true;
            this.DivideCB.Location = new System.Drawing.Point(75, 101);
            this.DivideCB.Name = "DivideCB";
            this.DivideCB.Size = new System.Drawing.Size(15, 14);
            this.DivideCB.TabIndex = 6;
            this.DivideCB.UseVisualStyleBackColor = true;
            this.DivideCB.CheckedChanged += new System.EventHandler(this.DivideCB_CheckedChanged);
            // 
            // ThreeNumPB
            // 
            this.ThreeNumPB.Image = global::MathGame2.Properties.Resources._3;
            this.ThreeNumPB.Location = new System.Drawing.Point(27, 122);
            this.ThreeNumPB.Name = "ThreeNumPB";
            this.ThreeNumPB.Size = new System.Drawing.Size(25, 25);
            this.ThreeNumPB.TabIndex = 9;
            this.ThreeNumPB.TabStop = false;
            this.MainToolTip.SetToolTip(this.ThreeNumPB, "Three-digit numbers");
            // 
            // TwoNumPB
            // 
            this.TwoNumPB.Image = global::MathGame2.Properties.Resources._2;
            this.TwoNumPB.Location = new System.Drawing.Point(27, 78);
            this.TwoNumPB.Name = "TwoNumPB";
            this.TwoNumPB.Size = new System.Drawing.Size(25, 25);
            this.TwoNumPB.TabIndex = 8;
            this.TwoNumPB.TabStop = false;
            this.MainToolTip.SetToolTip(this.TwoNumPB, "Double-digit numbers");
            // 
            // OneNumPB
            // 
            this.OneNumPB.Image = global::MathGame2.Properties.Resources._1;
            this.OneNumPB.Location = new System.Drawing.Point(27, 34);
            this.OneNumPB.Name = "OneNumPB";
            this.OneNumPB.Size = new System.Drawing.Size(25, 25);
            this.OneNumPB.TabIndex = 7;
            this.OneNumPB.TabStop = false;
            this.MainToolTip.SetToolTip(this.OneNumPB, "Single-digit numbers");
            // 
            // MinusPB
            // 
            this.MinusPB.Image = global::MathGame2.Properties.Resources.minus;
            this.MinusPB.Location = new System.Drawing.Point(96, 60);
            this.MinusPB.Name = "MinusPB";
            this.MinusPB.Size = new System.Drawing.Size(25, 25);
            this.MinusPB.TabIndex = 19;
            this.MinusPB.TabStop = false;
            this.MainToolTip.SetToolTip(this.MinusPB, "Minus");
            // 
            // DividePB
            // 
            this.DividePB.Image = global::MathGame2.Properties.Resources.divide;
            this.DividePB.Location = new System.Drawing.Point(96, 96);
            this.DividePB.Name = "DividePB";
            this.DividePB.Size = new System.Drawing.Size(25, 25);
            this.DividePB.TabIndex = 18;
            this.DividePB.TabStop = false;
            this.MainToolTip.SetToolTip(this.DividePB, "Divide");
            // 
            // MultiplyPB
            // 
            this.MultiplyPB.Image = global::MathGame2.Properties.Resources.multiply;
            this.MultiplyPB.Location = new System.Drawing.Point(96, 132);
            this.MultiplyPB.Name = "MultiplyPB";
            this.MultiplyPB.Size = new System.Drawing.Size(25, 25);
            this.MultiplyPB.TabIndex = 17;
            this.MultiplyPB.TabStop = false;
            this.MainToolTip.SetToolTip(this.MultiplyPB, "Mutiply");
            // 
            // PlusPB
            // 
            this.PlusPB.Image = global::MathGame2.Properties.Resources.plus;
            this.PlusPB.Location = new System.Drawing.Point(96, 24);
            this.PlusPB.Name = "PlusPB";
            this.PlusPB.Size = new System.Drawing.Size(25, 25);
            this.PlusPB.TabIndex = 16;
            this.PlusPB.TabStop = false;
            this.MainToolTip.SetToolTip(this.PlusPB, "Plus");
            // 
            // BackToMenuButton
            // 
            this.BackToMenuButton.Location = new System.Drawing.Point(12, 216);
            this.BackToMenuButton.Name = "BackToMenuButton";
            this.BackToMenuButton.Size = new System.Drawing.Size(143, 26);
            this.BackToMenuButton.TabIndex = 9;
            this.BackToMenuButton.Text = "Back To Menu";
            this.BackToMenuButton.UseVisualStyleBackColor = true;
            this.BackToMenuButton.Click += new System.EventHandler(this.BackToMenuButton_Click);
            // 
            // MainTimer
            // 
            this.MainTimer.Enabled = true;
            this.MainTimer.Interval = 1000;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // SkipButton
            // 
            this.SkipButton.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SkipButton.Location = new System.Drawing.Point(225, 146);
            this.SkipButton.Name = "SkipButton";
            this.SkipButton.Size = new System.Drawing.Size(67, 29);
            this.SkipButton.TabIndex = 10;
            this.SkipButton.Text = "Skip";
            this.SkipButton.UseVisualStyleBackColor = true;
            this.SkipButton.Click += new System.EventHandler(this.SkipButton_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 248);
            this.Controls.Add(this.SkipButton);
            this.Controls.Add(this.BackToMenuButton);
            this.Controls.Add(this.SettingsGroupBox);
            this.Controls.Add(this.InputButton);
            this.Controls.Add(this.StatusGroupBox);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.AnswerTB);
            this.Controls.Add(this.ExerciseLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_FormClosing);
            this.Load += new System.EventHandler(this.Game_Load);
            this.StatusGroupBox.ResumeLayout(false);
            this.StatusGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WrongPB)).EndInit();
            this.SettingsGroupBox.ResumeLayout(false);
            this.SettingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThreeNumPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TwoNumPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OneNumPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinusPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DividePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MultiplyPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlusPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExerciseLabel;
        private System.Windows.Forms.TextBox AnswerTB;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox WrongPB;
        private System.Windows.Forms.Label CorrectCounterLabel;
        private System.Windows.Forms.Label WrongCounterLabel;
        private System.Windows.Forms.GroupBox StatusGroupBox;
        private System.Windows.Forms.Button InputButton;
        private System.Windows.Forms.GroupBox SettingsGroupBox;
        private System.Windows.Forms.CheckBox OneNumCB;
        private System.Windows.Forms.CheckBox DivideCB;
        private System.Windows.Forms.CheckBox MultiplyCB;
        private System.Windows.Forms.CheckBox PlusCB;
        private System.Windows.Forms.CheckBox TwoNumCB;
        private System.Windows.Forms.CheckBox ThreeNumCB;
        private System.Windows.Forms.CheckBox MinusCB;
        private System.Windows.Forms.PictureBox ThreeNumPB;
        private System.Windows.Forms.PictureBox TwoNumPB;
        private System.Windows.Forms.PictureBox OneNumPB;
        private System.Windows.Forms.PictureBox MinusPB;
        private System.Windows.Forms.PictureBox DividePB;
        private System.Windows.Forms.PictureBox MultiplyPB;
        private System.Windows.Forms.PictureBox PlusPB;
        private System.Windows.Forms.Button BackToMenuButton;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.ToolTip MainToolTip;
        private System.Windows.Forms.Button SkipButton;
    }
}