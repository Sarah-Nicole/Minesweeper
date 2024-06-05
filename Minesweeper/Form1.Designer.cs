namespace Minesweeper
{
    partial class FrmMinesweeperMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMinesweeperMain));
            this.TxtbTimer = new System.Windows.Forms.TextBox();
            this.TxtbLife = new System.Windows.Forms.TextBox();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtbTimer
            // 
            this.TxtbTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtbTimer.BackColor = System.Drawing.Color.White;
            this.TxtbTimer.Font = new System.Drawing.Font("ROG Fonts", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbTimer.Location = new System.Drawing.Point(546, 42);
            this.TxtbTimer.Margin = new System.Windows.Forms.Padding(20, 19, 20, 19);
            this.TxtbTimer.Name = "TxtbTimer";
            this.TxtbTimer.ReadOnly = true;
            this.TxtbTimer.Size = new System.Drawing.Size(250, 55);
            this.TxtbTimer.TabIndex = 7;
            this.TxtbTimer.TabStop = false;
            this.TxtbTimer.Text = "00:00:00";
            // 
            // TxtbLife
            // 
            this.TxtbLife.BackColor = System.Drawing.Color.White;
            this.TxtbLife.Font = new System.Drawing.Font("ROG Fonts", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbLife.Location = new System.Drawing.Point(80, 42);
            this.TxtbLife.Margin = new System.Windows.Forms.Padding(20, 19, 20, 19);
            this.TxtbLife.Name = "TxtbLife";
            this.TxtbLife.ReadOnly = true;
            this.TxtbLife.Size = new System.Drawing.Size(250, 55);
            this.TxtbLife.TabIndex = 6;
            this.TxtbLife.TabStop = false;
            // 
            // BtnPlay
            // 
            this.BtnPlay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPlay.BackgroundImage")));
            this.BtnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnPlay.Location = new System.Drawing.Point(351, 35);
            this.BtnPlay.Margin = new System.Windows.Forms.Padding(20, 19, 20, 19);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(177, 77);
            this.BtnPlay.TabIndex = 5;
            this.BtnPlay.TabStop = false;
            this.BtnPlay.UseVisualStyleBackColor = true;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // FrmMinesweeperMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(900, 975);
            this.Controls.Add(this.TxtbTimer);
            this.Controls.Add(this.TxtbLife);
            this.Controls.Add(this.BtnPlay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMinesweeperMain";
            this.Padding = new System.Windows.Forms.Padding(80, 81, 80, 81);
            this.Text = "Minesweeper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtbTimer;
        private System.Windows.Forms.TextBox TxtbLife;
        private System.Windows.Forms.Button BtnPlay;
    }
}

