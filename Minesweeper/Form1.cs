using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Minesweeper
{
    public partial class FrmMinesweeper : Form
    {
        private Button[,] buttons = new Button[8, 8];
        
        Panel disablePanel;

        private Timer timer;
        private DateTime startTime;

        // noch dynamisch machen
        int bombCount = 10;
        int lifeCount = 3;

        string winMessage = "You won!";
        string loseMessage = "You lost! :(, Want to try again?"; 

        public FrmMinesweeper()
        {
            InitializeComponent();
            CreateGameBoard();
            TxtbLife.Text = lifeCount.ToString();
            CreateTimer();

            PlaceBombs();
        }

        #region Inizialisierung Komponenten
        public void CreateGameBoard()
        {
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
                        Tag = 0,
                        TabStop = false,
                    };   
                    buttons[x, y].Click += new EventHandler(MyButtonHandler_Click);
                    Controls.Add(buttons[x, y]);
                }
                newY += offset + buttonHeight;
            }
        }

        public void CreateDisablePanel()
        {
            disablePanel = new Panel()
            {
                Size = this.ClientSize,
                Location = new Point(0, 0),
                Visible = false,
            };
            Controls.Add(disablePanel);
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

            for (int i = 0; i < bombCount; i++)
            {
                int x = rnd.Next(0, 7);
                int y = rnd.Next(0, 7);

                // 1 = BOMB, 0 = leer
                buttons[x, y].Tag = 1;
                buttons[x, y].Text = "B";
            }
        }
       
        private bool CheckIfBomb(Button clickedButton)
        {
            if (Convert.ToInt32(clickedButton.Tag) == 1)
            {
                return true;
            }

            return false;
        }

        private bool CheckIfWon()
        {
            // check if from all the buttons that are disabled, there are the correct buttons with Tag 0
            int nonBombCount = buttons.GetLength(0) * buttons.GetLength(1) - bombCount;
            int emptyFieldCount = -1; 

            for (int y = 0; y <= buttons.GetUpperBound(1); y++)
            {
                for (int x = 0; x <= buttons.GetUpperBound(0); x++)
                {
                    if (Convert.ToInt32(buttons[x, y].Tag) == 0 && !buttons[x, y].Enabled)
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

            //noch dynamisch machen und input-wert nehmen
            lifeCount = 3;
            TxtbLife.Text = lifeCount.ToString();

            // Reset buttons
            for (int y = 0; y <= buttons.GetUpperBound(1); y++)
            {
                for (int x = 0; x <= buttons.GetUpperBound(0); x++)
                {
                    buttons[x, y].Text = ""; // Clear button text, später noch raus nehmen
                    buttons[x, y].Tag = 0;
                    buttons[x, y].Enabled = true;
                }
            }

            PlaceBombs();
        }

        public void DisableAll()
        {

            CreateDisablePanel();

            // Panel darüber legen und dieses disablen. 
            disablePanel.Visible = true; 
            disablePanel.Enabled = false;
           // disablePanel.BringToFront();

        }


        #region EventHandler

        public void MyButtonHandler_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            // Im Name ist die Position gemerkt. Anzeigen raus löschen
            b.Text = $"{b.Name} - {b.Tag}";
            // In Tag definieren ob Bombe oder nicht.

            // Eventuell bessere Lösung (in Tag speichern als Flag (isClicked))
            b.Enabled = false;

            bool isBomb = CheckIfBomb(b);
            if (isBomb)
            {
                // Sound einfügen 
                lifeCount--;
            }
            TxtbLife.Text = lifeCount.ToString();

            if(lifeCount == 0)
            {
                // Disabled alles: nochmals überarbeiten.
                //  DisableAll();

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
                    FrmMinesweeper.ActiveForm.Close();
                }
            }

            // muss noch überarbeitet werden:
            
                if (CheckIfWon())
                {
                    MessageBox.Show(winMessage, "Winner!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
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
