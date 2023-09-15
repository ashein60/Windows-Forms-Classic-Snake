using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Classic_Snake
{
    class Decoration
    {
        private static int points = 0;

        public static void AddPoints(Label pointsLabel)
        {
            points++;
            pointsLabel.Text = "Points: " + points;
        }

        public static void ResetPoints(Label pointsLabel)
        {
            points = 0;
            pointsLabel.Text = "Points: " + points;
        }
    }
}
