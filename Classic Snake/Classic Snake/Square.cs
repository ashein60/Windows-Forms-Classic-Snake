using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Classic_Snake
{
    public class Square
    {
        private static int size = 25; //size of square blocks

        private static int emptySquares = 1; //used spawning the fruit
        private int assignedNumber; //-1 if snake part, otherwise used for the random number generator of fruit

        private int positionX; //holds position values
        private int positionY;

        private string status; //snake, fruit, or empty

        public static int Size
        {
            get { return size; }
        }

        public static int EmptySquares
        {
            get { return emptySquares; }
            set { emptySquares = value; }
        }

        public int AssignNumber
        {
            get { return assignedNumber; }
            set { assignedNumber = value; }
        }

        public int PositionX
        {
            get { return positionX; }
        }

        public int PositionY
        {
            get { return positionY; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
       
        public Square (int positionX, int positionY)
        {
            this.positionX = positionX;
            this.positionY = positionY;

            assignedNumber = emptySquares;
            emptySquares++;
        }

        public void Paint(PaintEventArgs e)
        {
            Brush squareBrush;

            if (status == "snake")
            {
                squareBrush = new SolidBrush(Color.Black);
            }
            else if (status == "fruit")
            {
                squareBrush = new SolidBrush(Color.Orange);
            }
            else //if (status == "empty)
            {
                squareBrush = new SolidBrush(Color.LimeGreen);
            }

            e.Graphics.FillRectangle(squareBrush, positionX, positionY, size - 2, size - 2);
            squareBrush.Dispose(); //Don't allow a hole in the program
        }
    }
}
