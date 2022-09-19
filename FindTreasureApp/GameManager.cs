using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTreasureApp
{
    public static class GameManager
    {
        private static Point islandLocation = new Point(0,0);
        public static int Score { get; private set; }

        public static void GenerateIslandLocation(int numRows, int numCols)
        {

        }

        public static char DetermineIslandDirection(Point cellLocation)
        {
            if(cellLocation == islandLocation)
            {
                return 'I';
            }
            else if(cellLocation.X == islandLocation.X)
            {
                return 'C';
            }
            else if(cellLocation.Y == islandLocation.Y)
            {
                return 'R';
            }
            else if(cellLocation.Y > islandLocation.Y)
            {
                return 'N';
            }
            else if(cellLocation.Y < islandLocation.Y)
            {
                return 'S';
            }
            else if(cellLocation.X > islandLocation.X)
            {
                return 'E';
            }
            else
            {
                return 'W';
            }
        }
    }
}
