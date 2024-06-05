using System;
using System.Diagnostics.Eventing.Reader;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class FrmMinesweeperStart : Form
    {
        private GameConfig config = new GameConfig();

        public FrmMinesweeperStart()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            config.BoardSize = TrkbSize.Value;

        }

        public void UpdateGameConfig(int boardSize)
        {
            if (RadbEasy.Checked)
            {
                config.SelectedLevel = 0;
                config.BombCount = Convert.ToInt32((TrkbSize.Value * TrkbSize.Value) / 8);
                config.LifeCount = 4;
                config.BoardSize = TrkbSize.Value;
            }
            else if (RadbMedium.Checked) {
                config.SelectedLevel = 1;
                config.BombCount = Convert.ToInt32((TrkbSize.Value * TrkbSize.Value) / 5);
                config.LifeCount = 3;
                config.BoardSize = TrkbSize.Value;
            }
            else
            {
                config.SelectedLevel = 2;
                config.BombCount = Convert.ToInt32((TrkbSize.Value * TrkbSize.Value) / 3);
                config.LifeCount = 1;
                config.BoardSize = TrkbSize.Value;
            }
        }

        private void RadbEasy_CheckedChanged(object sender, EventArgs e)
        {
            if (RadbEasy.Checked)
            {
                UpdateGameConfig(TrkbSize.Value);
            }
        }

        private void RadbMedium_CheckedChanged(object sender, EventArgs e)
        {
            if (RadbMedium.Checked)
            {
                UpdateGameConfig(TrkbSize.Value);
            }
        }

        private void RadbHard_CheckedChanged(object sender, EventArgs e)
        {
            if (RadbHard.Checked)
            {
                UpdateGameConfig(TrkbSize.Value);
            }
        }

        private void TrkbSize_Scroll(object sender, EventArgs e)
        {
            int remainder = TrkbSize.Value % TrkbSize.TickFrequency;
            int newValue = TrkbSize.Value - remainder;
            if (remainder > TrkbSize.TickFrequency)
            {
                newValue += TrkbSize.TickFrequency;
            }
            TrkbSize.Value = newValue;

            LblMin.Text = TrkbSize.Minimum.ToString();
            LblMax.Text = TrkbSize.Maximum.ToString();
            LblValue.Text = TrkbSize.Value.ToString();

            UpdateGameConfig(TrkbSize.Value);
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
