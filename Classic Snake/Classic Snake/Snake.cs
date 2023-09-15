using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Classic_Snake
{
    public class Snake
    {
        private static string direction = "0"; //direction of movement North, South, East, West

        private int positionX;
        private int positionY;

        public static string Direction
        {
            get { return direction; }
            set { direction = value; }
        }

        public int PositionX
        {
            get { return positionX; }
            set { positionX = value; }
        }

        public int PositionY
        {
            get { return positionY; }
            set { positionY = value; }
        }

        public Snake(Grid Grid1, int positionX, int positionY)
        {
            this.positionX = positionX;
            this.positionY = positionY;

            Grid1.Squares[positionY, positionX].Status = "snake";
            Grid1.Squares[positionY, positionX].AssignNumber = -1;
            Square.EmptySquares--;

        }

        public static void MoveSnake(Grid Grid1, List<Snake> Snakes, Label pointsLabel)
        {
            if (SnakeCollision(Snakes) == false && direction == "North" && Snakes[0].positionY > 0)
            {
                KeepSnakeLength(Grid1, Snakes, pointsLabel, 0, -1);

                Snakes[0].positionY--; //keeps Snake List position
            }
            else if (SnakeCollision(Snakes) == false && direction == "South" && Snakes[0].positionY < Grid.Size - 1)
            {
                KeepSnakeLength(Grid1, Snakes, pointsLabel, 0, 1);

                Snakes[0].positionY++;
            }
            else if (SnakeCollision(Snakes) == false && direction == "East" && Snakes[0].positionX < Grid.Size - 1)
            {
                KeepSnakeLength(Grid1, Snakes, pointsLabel, 1, 0);

                Snakes[0].positionX++;
            }
            else if (SnakeCollision(Snakes) == false && direction == "West" && Snakes[0].positionX > 0)
            {

                KeepSnakeLength(Grid1, Snakes, pointsLabel, - 1, 0);

                Snakes[0].positionX--;
            }
            else if (direction == "0")
            {
                //nothing happens, need it to allow a game pause
            }
            else //Game Over
            {
                mainForm.GameStart = false;
            }
        }

        public static void KeepSnakeLength(Grid Grid1, List<Snake> Snakes, Label pointsLabel,int valueX, int valueY) 
        {
            if (Grid1.Squares[Snakes[0].positionY + valueY, Snakes[0].positionX + valueX].Status == "fruit") //eat fruit
            {
                Grid1.Squares[Snakes[0].positionY + valueY, Snakes[0].positionX + valueX].Status = "snake";
                Grid1.Squares[Snakes[0].positionY + valueY, Snakes[0].positionX + valueX].AssignNumber = -1;

                Snakes.Add(new Snake(Grid1, Snakes[Snakes.Count - 1].positionX, Snakes[Snakes.Count - 1].positionY)); //adds snake piece that normally becomes "empty"

                Grid.ResetNumber(Grid1); //every new food
                Fruit.CreateFruit(Grid1); //creates fruit if eaten

                Decoration.AddPoints(pointsLabel);
            }
            else
            {
                Grid1.Squares[Snakes[Snakes.Count - 1].positionY, Snakes[Snakes.Count - 1].positionX].Status = "empty"; //sets the current tail piece as empty
                Grid1.Squares[Snakes[Snakes.Count - 1].positionY, Snakes[Snakes.Count - 1].positionX].AssignNumber = 0; //placeholder

                Grid1.Squares[Snakes[0].positionY + valueY, Snakes[0].positionX + valueX].Status = "snake"; //creates new snake head
                Grid1.Squares[Snakes[0].positionY + valueY, Snakes[0].positionX + valueX].AssignNumber = -1; //snake number = -1
            }

            for (int i = Snakes.Count - 1; i > 0; i--) //keeps track of list of snake positions
            {
                Snakes[i].positionX = Snakes[i - 1].positionX;
                Snakes[i].positionY = Snakes[i - 1].positionY;
            }
        }

        public static bool SnakeCollision(List<Snake> Snakes) //tests snake hits itself
        {
            bool collision = false; //default = false

            if (Snakes.Count > 0)
            {
                for (int i = 1; i < Snakes.Count; i++)
                {
                    if (Snakes[0].positionY == Snakes[i].positionY && Snakes[0].positionX == Snakes[i].positionX)
                    {
                        collision = true;
                        break;
                    }
                }
            }

            return collision;
        }
    }
}
