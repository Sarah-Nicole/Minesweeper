using System;
using System.Drawing;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class FrmMinesweeperMain : Form
    {
        

        private Timer timer;
        private DateTime startTime;

        // noch dynamisch machen
        private GameConfig _config;
        int lifeCount;
        int boardSize;

        private Button[,] buttons; 


        string winMessage = "You won! Want to try again?";
        string loseMessage = "You lost! :( Want to try again?";

        public FrmMinesweeperMain(GameConfig config)
        {
            InitializeComponent();
            _config = config;
            lifeCount = _config.LifeCount;
            boardSize = _config.BoardSize;
            TxtbLife.Text = _config.LifeCount.ToString();
            StartPosition = FormStartPosition.CenterScreen;

            CreateGameBoard();
            CreateTimer();

            PlaceBombs();
        }

        #region Inizialisierung Komponenten
        public void CreateGameBoard()
        {
            buttons = new Button[boardSize, boardSize];

            int newX = 32;
            int newY = 80;
            int offset = 5;
            int buttonWidth = 40;
            int buttonHeight = 40;

            for (int y = 0; y <= buttons.GetUpperBound(1); y++)
            {
                newX = 0;
                for (int x = 0; x <= buttons.GetUpperBound(0); x++)
                {
                    newX += offset + buttonWidth;
                    buttons[x, y] = new Button()
                    {
                        Location = new Point(newX, newY),
                        Size = new Size(buttonWidth, buttonHeight),
                        Name = x + ":" + y,
                        Tag = new ButtonInfo() { HasBomb = false },
                        TabStop = false,
                    };
                    buttons[x, y].Click += new EventHandler(MyButtonHandler_Click);
                    Controls.Add(buttons[x, y]);
                }
                newY += offset + buttonHeight;
            }
        }

        public void CreateTimer()
        {
            startTime = DateTime.Now;
            timer = new Timer()
            {
                Interval = 1000,
            };
            timer.Tick += OnTimerTick;
            timer.Start();
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            TimeSpan elapsedTime = DateTime.Now - startTime;
            TxtbTimer.Text = elapsedTime.ToString("hh\\:mm\\:ss");
        }

        #endregion


        private void PlaceBombs()
        {
            Random rnd = new Random();

            for (int i = 0; i < _config.BombCount; i++)
            {
                bool placedBomb = false;

                while (!placedBomb)
                {
                    int x = rnd.Next(0, boardSize);
                    int y = rnd.Next(0, boardSize);

                    if (!((ButtonInfo)buttons[x, y].Tag).HasBomb)
                    {
                        buttons[x, y].Tag = new ButtonInfo() { HasBomb = true };
                        buttons[x, y].Text = "B"; // noch entfernen für Produktion
                        placedBomb = true;
                    }
                }
            }
        }

        private bool CheckIfBomb(Button clickedButton)
        {
            return ((ButtonInfo)clickedButton.Tag).HasBomb;
        }

        private bool CheckIfWon()
        {
            // Check if all non-bomb buttons are disabled
            int nonBombCount = buttons.GetLength(0) * buttons.GetLength(1) - _config.BombCount;
            int emptyFieldCount = 0;

            for (int y = 0; y <= buttons.GetUpperBound(1); y++)
            {
                for (int x = 0; x <= buttons.GetUpperBound(0); x++)
                {
                    if (!((ButtonInfo)buttons[x, y].Tag).HasBomb && !buttons[x, y].Enabled)
                    {
                        emptyFieldCount++;
                    }
                }
            }

            return emptyFieldCount == nonBombCount;
        }

        private void StartNewGame()
        {
            // Reset timer
            timer.Start();
            startTime = DateTime.Now;
            TxtbTimer.Text = "00:00:00";

            // Reset lifeCount
            lifeCount = _config.LifeCount; 
            TxtbLife.Text = _config.LifeCount.ToString();

            // Reset buttons
            for (int y = 0; y <= buttons.GetUpperBound(1); y++)
            {
                for (int x = 0; x <= buttons.GetUpperBound(0); x++)
                {
                    buttons[x, y].Text = ""; // Clear button text, später noch raus nehmen

                    ((ButtonInfo)buttons[x, y].Tag).HasBomb = false;
                    buttons[x, y].Enabled = true;
                }
            }

            PlaceBombs();
        }

        private int CountAdjurningBombs(int clickedButtonX, int clickedButtonY)
        {
            int bombCount = 0;

            // Durch die Buttons iterieren inkl. Edges
            for (int y = Math.Max(clickedButtonY - 1, 0); y <= Math.Min(clickedButtonY + 1, buttons.GetUpperBound(1)); y++)
            {
                for (int x = Math.Max(clickedButtonX - 1, 0); x <= Math.Min(clickedButtonX + 1, buttons.GetUpperBound(0)); x++)
                {
                    // Den geklickten Button skipen
                    if (x == clickedButtonX && y == clickedButtonY) continue;

                    if (((ButtonInfo)buttons[x, y].Tag).HasBomb)
                    {
                        bombCount++;
                    }
                }
            }

            return bombCount;
        }

        #region EventHandler

        public void MyButtonHandler_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            // Im Name ist die Position gemerkt. Anzeigen raus löschen für Produktion
            b.Text = $"{b.Name}";

            // Eventuell bessere Lösung (in Tag speichern als Flag (isClicked))
            b.Enabled = false;

            bool isBomb = CheckIfBomb(b);
            if (isBomb)
            {
                // Sound einfügen 
                lifeCount--;
                TxtbLife.Text = lifeCount.ToString();
            }
            else
            {
                // Ev. CountAdjuringBombs gerade Wert zurück geben
                string[] nameParts = b.Name.Split(':');
                int clickedButtonX = Convert.ToInt32(nameParts[0]);
                int clickedButtonY = Convert.ToInt32(nameParts[1]);
                int adjoiningBombs = CountAdjurningBombs(clickedButtonX, clickedButtonY);

                // Update ButtonInfo with adjoining bomb count
                ((ButtonInfo)b.Tag).NumberOfAdjurningBombs = adjoiningBombs;
                b.Text = adjoiningBombs.ToString();
            }

            if(lifeCount == 0)
            {
                timer.Stop();

                // Message Box noch in der Mitte der Applikation setzen. 
                var result = MessageBox.Show(loseMessage, "Looser!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    StartNewGame();
                }
                else
                {
                    // Programm schliessen / bzw dann zurück zur auswahl
                    FrmMinesweeperMain.ActiveForm.Close();
                }
            }

            if (CheckIfWon())
            {
                var result = MessageBox.Show(winMessage, "Winner!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
               
                if (result == DialogResult.Yes)
                {
                    StartNewGame();
                }
                else
                {
                    // Programm schliessen / bzw dann zurück zur auswahl
                    FrmMinesweeperMain.ActiveForm.Close();
                }
            }
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            StartNewGame();
            // 2te Option: Timer erst starten wenn auf Play gedrückt & alle Buttons im initialize disabled zuerst und erst hier enablen. 
        }

        #endregion

    }
}
