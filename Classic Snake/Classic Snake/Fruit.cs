using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Classic_Snake
{  
    public class Fruit
    {
        static Random fruitPosition = new Random();

        private static int value; //holds the value of fruitPosition

        public static void CreateFruit(Grid Grid1)
        {
            value = fruitPosition.Next(1, Square.EmptySquares); //inclusive, exclusive

            for (int y = 0; y < Grid.Size; y++)
            {
                for (int x = 0; x < Grid.Size; x++)
                {
                    if (Grid1.Squares[y, x].AssignNumber == value) //creates the fruit 
                    {
                        Grid1.Squares[y, x].Status = "fruit";
                        break;
                    }
                }
            }
        }
    }
}
