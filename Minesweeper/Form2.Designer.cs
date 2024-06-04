namespace Minesweeper
{
    partial class FrmMinesweeperStart
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
            this.LblTitle = new System.Windows.Forms.Label();
            this.RadbEasy = new System.Windows.Forms.RadioButton();
            this.RadbMedium = new System.Windows.Forms.RadioButton();
            this.RadbHard = new System.Windows.Forms.RadioButton();
            this.LblLevel = new System.Windows.Forms.Label();
            this.TrkbSize = new System.Windows.Forms.TrackBar();
            this.LblSize = new System.Windows.Forms.Label();
            this.LblMin = new System.Windows.Forms.Label();
            this.LblMax = new System.Windows.Forms.Label();
            this.LblValue = new System.Windows.Forms.Label();
            this.BtnPlay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TrkbSize)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LblTitle.Location = new System.Drawing.Point(143, 40);
            this.LblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(238, 25);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Welcome to Minesweeper";
            // 
            // RadbEasy
            // 
            this.RadbEasy.AutoSize = true;
            this.RadbEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.RadbEasy.Location = new System.Drawing.Point(64, 131);
            this.RadbEasy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadbEasy.Name = "RadbEasy";
            this.RadbEasy.Size = new System.Drawing.Size(48, 17);
            this.RadbEasy.TabIndex = 1;
            this.RadbEasy.TabStop = true;
            this.RadbEasy.Text = "Easy";
            this.RadbEasy.UseVisualStyleBackColor = true;
            this.RadbEasy.CheckedChanged += new System.EventHandler(this.RadbEasy_CheckedChanged);
            // 
            // RadbMedium
            // 
            this.RadbMedium.AutoSize = true;
            this.RadbMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.RadbMedium.Location = new System.Drawing.Point(180, 131);
            this.RadbMedium.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadbMedium.Name = "RadbMedium";
            this.RadbMedium.Size = new System.Drawing.Size(62, 17);
            this.RadbMedium.TabIndex = 2;
            this.RadbMedium.TabStop = true;
            this.RadbMedium.Text = "Medium";
            this.RadbMedium.UseVisualStyleBackColor = true;
            this.RadbMedium.CheckedChanged += new System.EventHandler(this.RadbMedium_CheckedChanged);
            // 
            // RadbHard
            // 
            this.RadbHard.AutoSize = true;
            this.RadbHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.RadbHard.Location = new System.Drawing.Point(300, 131);
            this.RadbHard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadbHard.Name = "RadbHard";
            this.RadbHard.Size = new System.Drawing.Size(110, 17);
            this.RadbHard.TabIndex = 3;
            this.RadbHard.TabStop = true;
            this.RadbHard.Text = "Super Duper Hard";
            this.RadbHard.UseVisualStyleBackColor = true;
            this.RadbHard.CheckedChanged += new System.EventHandler(this.RadbHard_CheckedChanged);
            // 
            // LblLevel
            // 
            this.LblLevel.AutoSize = true;
            this.LblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.LblLevel.Location = new System.Drawing.Point(62, 95);
            this.LblLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblLevel.Name = "LblLevel";
            this.LblLevel.Size = new System.Drawing.Size(89, 13);
            this.LblLevel.TabIndex = 4;
            this.LblLevel.Text = "Select your Level";
            // 
            // TrkbSize
            // 
            this.TrkbSize.LargeChange = 2;
            this.TrkbSize.Location = new System.Drawing.Point(64, 219);
            this.TrkbSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TrkbSize.Maximum = 20;
            this.TrkbSize.Minimum = 8;
            this.TrkbSize.Name = "TrkbSize";
            this.TrkbSize.Size = new System.Drawing.Size(344, 45);
            this.TrkbSize.TabIndex = 2;
            this.TrkbSize.TickFrequency = 2;
            this.TrkbSize.Value = 8;
            this.TrkbSize.Scroll += new System.EventHandler(this.TrkbSize_Scroll);
            // 
            // LblSize
            // 
            this.LblSize.AutoSize = true;
            this.LblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.LblSize.Location = new System.Drawing.Point(62, 189);
            this.LblSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblSize.Name = "LblSize";
            this.LblSize.Size = new System.Drawing.Size(63, 13);
            this.LblSize.TabIndex = 6;
            this.LblSize.Text = "Select Size:";
            // 
            // LblMin
            // 
            this.LblMin.AutoSize = true;
            this.LblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.LblMin.Location = new System.Drawing.Point(62, 258);
            this.LblMin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblMin.Name = "LblMin";
            this.LblMin.Size = new System.Drawing.Size(13, 13);
            this.LblMin.TabIndex = 7;
            this.LblMin.Text = "8";
            // 
            // LblMax
            // 
            this.LblMax.AutoSize = true;
            this.LblMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.LblMax.Location = new System.Drawing.Point(388, 258);
            this.LblMax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblMax.Name = "LblMax";
            this.LblMax.Size = new System.Drawing.Size(19, 13);
            this.LblMax.TabIndex = 9;
            this.LblMax.Text = "20";
            // 
            // LblValue
            // 
            this.LblValue.AutoSize = true;
            this.LblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.LblValue.Location = new System.Drawing.Point(139, 189);
            this.LblValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblValue.Name = "LblValue";
            this.LblValue.Size = new System.Drawing.Size(13, 13);
            this.LblValue.TabIndex = 10;
            this.LblValue.Text = "8";
            // 
            // BtnPlay
            // 
            this.BtnPlay.Location = new System.Drawing.Point(64, 316);
            this.BtnPlay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(66, 25);
            this.BtnPlay.TabIndex = 11;
            this.BtnPlay.Text = "Play";
            this.BtnPlay.UseVisualStyleBackColor = true;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlayStart_Click);
            // 
            // FrmMinesweeperStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 383);
            this.Controls.Add(this.BtnPlay);
            this.Controls.Add(this.LblValue);
            this.Controls.Add(this.LblMax);
            this.Controls.Add(this.LblMin);
            this.Controls.Add(this.LblSize);
            this.Controls.Add(this.TrkbSize);
            this.Controls.Add(this.LblLevel);
            this.Controls.Add(this.RadbHard);
            this.Controls.Add(this.RadbMedium);
            this.Controls.Add(this.RadbEasy);
            this.Controls.Add(this.LblTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmMinesweeperStart";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.TrkbSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.RadioButton RadbEasy;
        private System.Windows.Forms.RadioButton RadbMedium;
        private System.Windows.Forms.RadioButton RadbHard;
        private System.Windows.Forms.Label LblLevel;
        private System.Windows.Forms.TrackBar TrkbSize;
        private System.Windows.Forms.Label LblSize;
        private System.Windows.Forms.Label LblMin;
        private System.Windows.Forms.Label LblMax;
        private System.Windows.Forms.Label LblValue;
        private System.Windows.Forms.Button BtnPlay;
    }
}