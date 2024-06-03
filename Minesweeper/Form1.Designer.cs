namespace Minesweeper
{
    partial class FrmMinesweeper
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
            this.TxtbTimer = new System.Windows.Forms.TextBox();
            this.TxtbLife = new System.Windows.Forms.TextBox();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtbTimer
            // 
            this.TxtbTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TxtbTimer.Location = new System.Drawing.Point(300, 11);
            this.TxtbTimer.Margin = new System.Windows.Forms.Padding(2);
            this.TxtbTimer.Name = "TxtbTimer";
            this.TxtbTimer.ReadOnly = true;
            this.TxtbTimer.Size = new System.Drawing.Size(127, 30);
            this.TxtbTimer.TabIndex = 7;
            this.TxtbTimer.TabStop = false;
            this.TxtbTimer.Text = "00:00:00";
            // 
            // TxtbLife
            // 
            this.TxtbLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TxtbLife.Location = new System.Drawing.Point(28, 11);
            this.TxtbLife.Margin = new System.Windows.Forms.Padding(2);
            this.TxtbLife.Name = "TxtbLife";
            this.TxtbLife.ReadOnly = true;
            this.TxtbLife.Size = new System.Drawing.Size(127, 30);
            this.TxtbLife.TabIndex = 6;
            this.TxtbLife.TabStop = false;
            // 
            // BtnPlay
            // 
            this.BtnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnPlay.Location = new System.Drawing.Point(194, 11);
            this.BtnPlay.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(60, 28);
            this.BtnPlay.TabIndex = 5;
            this.BtnPlay.TabStop = false;
            this.BtnPlay.Text = ">";
            this.BtnPlay.UseVisualStyleBackColor = true;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // FrmMinesweeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 507);
            this.Controls.Add(this.TxtbTimer);
            this.Controls.Add(this.TxtbLife);
            this.Controls.Add(this.BtnPlay);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMinesweeper";
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

