using System;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class FrmMinesweeperStart : Form
    {
       // int selectedLevel = 0;
       // int boardSize = 8;

        private GameConfig config = new GameConfig();

        public FrmMinesweeperStart()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            config.BoardSize = TrkbSize.Value;

        }

        private void RadbEasy_CheckedChanged(object sender, EventArgs e)
        {
            if (RadbEasy.Checked)
            {
                config.SelectedLevel = 0;
                config.BombCount = 5;
                config.LifeCount = 4;
            }
        }

        private void RadbMedium_CheckedChanged(object sender, EventArgs e)
        {
            if (RadbMedium.Checked)
            {
                config.SelectedLevel = 1;
                config.BombCount = 10;
                config.LifeCount = 3;
            }
        }

        private void RadbHard_CheckedChanged(object sender, EventArgs e)
        {
            if (RadbHard.Checked)
            {
                config.SelectedLevel = 2;
                config.BombCount = 15;
                config.LifeCount = 1;
            }
        }

        private void TrkbSize_Scroll(object sender, EventArgs e)
        {
            int remainder = TrkbSize.Value % TrkbSize.TickFrequency;
            int newValue = TrkbSize.Value - remainder;
            if (remainder > (TrkbSize.TickFrequency / 2))
            {
                newValue += TrkbSize.TickFrequency;
            }
            TrkbSize.Value = newValue;

            LblMin.Text = TrkbSize.Minimum.ToString();
            LblMax.Text = TrkbSize.Maximum.ToString();
            LblValue.Text = TrkbSize.Value.ToString();

            config.BoardSize = TrkbSize.Value;
        }

        private void BtnPlayStart_Click(object sender, EventArgs e)
        {
            FrmMinesweeperMain mainForm = new FrmMinesweeperMain(config);
            mainForm.FormClosed += OnMainFormClosed; 
            mainForm.Show();
            Hide();
        }

        private void OnMainFormClosed(object sender, FormClosedEventArgs e)
        {
            Show(); 
        }

        
    }
}
