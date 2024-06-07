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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMinesweeperStart));
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
            this.LblTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblTitle.Font = new System.Drawing.Font("ROG Fonts", 20F, System.Drawing.FontStyle.Bold);
            this.LblTitle.Location = new System.Drawing.Point(63, 53);
            this.LblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(1006, 65);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "Welcome to Minesweeper";
            // 
            // RadbEasy
            // 
            this.RadbEasy.AutoSize = true;
            this.RadbEasy.BackColor = System.Drawing.Color.Transparent;
            this.RadbEasy.Font = new System.Drawing.Font("ROG Fonts", 8.5F);
            this.RadbEasy.Location = new System.Drawing.Point(128, 252);
            this.RadbEasy.Margin = new System.Windows.Forms.Padding(4);
            this.RadbEasy.Name = "RadbEasy";
            this.RadbEasy.Size = new System.Drawing.Size(122, 32);
            this.RadbEasy.TabIndex = 1;
            this.RadbEasy.TabStop = true;
            this.RadbEasy.Text = "Easy";
            this.RadbEasy.UseVisualStyleBackColor = false;
            this.RadbEasy.CheckedChanged += new System.EventHandler(this.RadbEasy_CheckedChanged);
            // 
            // RadbMedium
            // 
            this.RadbMedium.AutoSize = true;
            this.RadbMedium.BackColor = System.Drawing.Color.Transparent;
            this.RadbMedium.Font = new System.Drawing.Font("ROG Fonts", 8.5F);
            this.RadbMedium.Location = new System.Drawing.Point(360, 252);
            this.RadbMedium.Margin = new System.Windows.Forms.Padding(4);
            this.RadbMedium.Name = "RadbMedium";
            this.RadbMedium.Size = new System.Drawing.Size(154, 32);
            this.RadbMedium.TabIndex = 2;
            this.RadbMedium.TabStop = true;
            this.RadbMedium.Text = "Medium";
            this.RadbMedium.UseVisualStyleBackColor = false;
            this.RadbMedium.CheckedChanged += new System.EventHandler(this.RadbMedium_CheckedChanged);
            // 
            // RadbHard
            // 
            this.RadbHard.AutoSize = true;
            this.RadbHard.BackColor = System.Drawing.Color.Transparent;
            this.RadbHard.Font = new System.Drawing.Font("ROG Fonts", 8.5F);
            this.RadbHard.Location = new System.Drawing.Point(600, 252);
            this.RadbHard.Margin = new System.Windows.Forms.Padding(4);
            this.RadbHard.Name = "RadbHard";
            this.RadbHard.Size = new System.Drawing.Size(337, 32);
            this.RadbHard.TabIndex = 3;
            this.RadbHard.TabStop = true;
            this.RadbHard.Text = "Super Duper Hard";
            this.RadbHard.UseVisualStyleBackColor = false;
            this.RadbHard.CheckedChanged += new System.EventHandler(this.RadbHard_CheckedChanged);
            // 
            // LblLevel
            // 
            this.LblLevel.AutoSize = true;
            this.LblLevel.BackColor = System.Drawing.Color.Transparent;
            this.LblLevel.Font = new System.Drawing.Font("ROG Fonts", 10F);
            this.LblLevel.Location = new System.Drawing.Point(124, 193);
            this.LblLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblLevel.Name = "LblLevel";
            this.LblLevel.Size = new System.Drawing.Size(373, 32);
            this.LblLevel.TabIndex = 4;
            this.LblLevel.Text = "Select your Level";
            // 
            // TrkbSize
            // 
            this.TrkbSize.BackColor = System.Drawing.Color.Goldenrod;
            this.TrkbSize.LargeChange = 2;
            this.TrkbSize.Location = new System.Drawing.Point(128, 421);
            this.TrkbSize.Margin = new System.Windows.Forms.Padding(4);
            this.TrkbSize.Maximum = 20;
            this.TrkbSize.Minimum = 8;
            this.TrkbSize.Name = "TrkbSize";
            this.TrkbSize.Size = new System.Drawing.Size(688, 90);
            this.TrkbSize.TabIndex = 2;
            this.TrkbSize.TickFrequency = 2;
            this.TrkbSize.Value = 8;
            this.TrkbSize.Scroll += new System.EventHandler(this.TrkbSize_Scroll);
            // 
            // LblSize
            // 
            this.LblSize.AutoSize = true;
            this.LblSize.BackColor = System.Drawing.Color.Transparent;
            this.LblSize.Font = new System.Drawing.Font("ROG Fonts", 10F);
            this.LblSize.Location = new System.Drawing.Point(124, 363);
            this.LblSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSize.Name = "LblSize";
            this.LblSize.Size = new System.Drawing.Size(250, 32);
            this.LblSize.TabIndex = 6;
            this.LblSize.Text = "Select Size:";
            // 
            // LblMin
            // 
            this.LblMin.AutoSize = true;
            this.LblMin.BackColor = System.Drawing.Color.Transparent;
            this.LblMin.Font = new System.Drawing.Font("ROG Fonts", 8.5F);
            this.LblMin.Location = new System.Drawing.Point(139, 496);
            this.LblMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMin.Name = "LblMin";
            this.LblMin.Size = new System.Drawing.Size(33, 28);
            this.LblMin.TabIndex = 7;
            this.LblMin.Text = "8";
            // 
            // LblMax
            // 
            this.LblMax.AutoSize = true;
            this.LblMax.BackColor = System.Drawing.Color.Transparent;
            this.LblMax.Font = new System.Drawing.Font("ROG Fonts", 8.5F);
            this.LblMax.Location = new System.Drawing.Point(774, 496);
            this.LblMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMax.Name = "LblMax";
            this.LblMax.Size = new System.Drawing.Size(51, 28);
            this.LblMax.TabIndex = 9;
            this.LblMax.Text = "20";
            // 
            // LblValue
            // 
            this.LblValue.AutoSize = true;
            this.LblValue.BackColor = System.Drawing.Color.Transparent;
            this.LblValue.Font = new System.Drawing.Font("ROG Fonts", 10F);
            this.LblValue.Location = new System.Drawing.Point(396, 363);
            this.LblValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblValue.Name = "LblValue";
            this.LblValue.Size = new System.Drawing.Size(39, 32);
            this.LblValue.TabIndex = 10;
            this.LblValue.Text = "8";
            // 
            // BtnPlay
            // 
            this.BtnPlay.BackgroundImage = global::Minesweeper.Properties.Resources.play2;
            this.BtnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnPlay.Location = new System.Drawing.Point(130, 584);
            this.BtnPlay.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(196, 87);
            this.BtnPlay.TabIndex = 11;
            this.BtnPlay.UseVisualStyleBackColor = true;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlayStart_Click);
            // 
            // FrmMinesweeperStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(1112, 737);
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
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMinesweeperStart";
            this.Text = "Minesweeper Start";
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