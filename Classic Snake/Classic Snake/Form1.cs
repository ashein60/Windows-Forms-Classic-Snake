using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Threading;

namespace Classic_Snake
{
    public partial class mainForm : Form
    {
        public static Grid Grid1 = new Grid();
        public static List<Snake> Snakes = new List<Snake>();

        public static System.Timers.Timer moveTimer; //timer used to move the snake

        private static bool gameStart = false; //tests if game is being played

        public static bool GameStart
        {
            set { gameStart = value; }
        }

        public mainForm()
        {
            InitializeComponent();

            CreateTimer(); //Creates and starts the timer to move the snake keep lasts
        }

        public void StartGame()
        {
            gameName.Hide();
            easy.Hide();
            medium.Hide();
            hard.Hide();
            insane.Hide();

            gameName.Enabled = false;
            easy.Enabled = false;
            medium.Enabled = false;
            hard.Enabled = false;
            insane.Enabled = false;

            Decoration.ResetPoints(pointsLabel);
            Snakes.Add(new Snake(Grid1, Grid.Size / 2, Grid.Size / 2)); //creates the head
            Fruit.CreateFruit(Grid1); //creates the first fruit

            gameStart = true;
            moveTimer.Enabled = true;
        }

        public void StopGame()
        {
            Thread.Sleep(1000); //gives the user to look at their score before returned to the main menu

            gameName.Show();
            easy.Show();
            medium.Show();
            hard.Show();
            insane.Show();

            gameName.Enabled = true;
            easy.Enabled = true;
            medium.Enabled = true;
            hard.Enabled = true;
            insane.Enabled = true;

            gameStart = false;
            moveTimer.Enabled = false;

            Snakes.RemoveRange(0, Snakes.Count);
            Grid.ResetDefault(Grid1);
            Snake.Direction = "0";
            this.Invalidate();

        }

        public void CreateTimer()
        {
            moveTimer = new System.Timers.Timer();
            moveTimer.Elapsed += MoveSnake;
            moveTimer.AutoReset = true;
        }

        private void MoveSnake(object sender, ElapsedEventArgs e)
        {
            if (gameStart == false)
            {
                StopGame();
            }

            Snake.MoveSnake(Grid1, Snakes, pointsLabel);

            this.Invalidate();
        }

        private void Key_Down(object sender, KeyEventArgs e) //Key_Down event changes snake direction
        {
            if (gameStart == true)
            {
                if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
                {
                    Snake.Direction = "North";
                }
                else if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
                {
                    Snake.Direction = "South";
                }
                else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
                {
                    Snake.Direction = "East";
                }
                else if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
                {
                    Snake.Direction = "West";
                }
                else if (e.KeyCode == Keys.Z)
                {
                    Snake.Direction = "0";
                }
            }
        }

        private void Paint_mainForm(object sender, PaintEventArgs e) //Painting
        {
                Grid1.Paint(e);
        }

        private void Click_easy(object sender, EventArgs e)
        {
            moveTimer.Interval = 300;
            StartGame();
        }

        private void Click_medium(object sender, EventArgs e)
        {
            moveTimer.Interval = 200;
            StartGame();
        }

        private void Click_hard(object sender, EventArgs e)
        {
            moveTimer.Interval = 100;
            StartGame();
        }

        private void Click_insane(object sender, EventArgs e)
        {
            moveTimer.Interval = 50;
            StartGame();
        }
    }
}
