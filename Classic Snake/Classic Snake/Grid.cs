using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Classic_Snake
{
    public class Grid
    {
        private static int size = 21; //keep odd
        public Square[,] Squares = new Square[size, size];

        public static int Size
        {
            get { return size; }
        }

        public Grid()
        {
            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    Squares[y, x] = new Square(x * Square.Size + 1, y * Square.Size + 2 + 50); //creates distance with size
                }
            }
        }

        public static void ResetNumber(Grid Grid1) //resets number positions if number != -1
        {
            int counter = 1; //starts at 1 up unto emptySquares amount

            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    if (Grid1.Squares[y, x].AssignNumber != -1)
                    {
                        Grid1.Squares[y, x].AssignNumber = counter;
                        counter++;
                    }
                }
            }

            counter = 1; //reset! 
        }

        public static void ResetDefault(Grid Grid1) //new Game
        {
            int counter = 1;

            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    Grid1.Squares[y, x].Status = "empty";
                    Grid1.Squares[y, x].AssignNumber = counter;
                    counter++;
                }
            }
            counter = 1; //reset! 
        }

        public void Paint(PaintEventArgs e)
        {
            foreach (Square i in Squares)
            {
                i.Paint(e);
            }
        }
    }
}
