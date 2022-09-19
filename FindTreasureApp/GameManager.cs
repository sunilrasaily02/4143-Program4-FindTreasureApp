using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTreasureApp
{
    public static class GameManager
    {
        public static List<GridCell> gridCells;
        public static int Score { get; private set; }

        private static Point islandLocation = new Point(0, 0);
        private static bool northSouth = true;

        public static void GenerateIslandLocation(int numRows, int numCols)
        {
            Random randomizer = new Random();
            islandLocation.X = randomizer.Next(numCols);
            islandLocation.Y = randomizer.Next(numRows);
            Debug.WriteLine($"Island location({islandLocation.X},{islandLocation.Y})");
        }

        public static char DetermineIslandDirection(Point cellLocation)
        {
            char rtn;
            if (northSouth)
            {
                if (cellLocation == islandLocation)
                {
                    rtn = 'I';
                }
                else if (cellLocation.Y == islandLocation.Y)
                {
                    rtn = 'R';
                }
                else if (cellLocation.Y > islandLocation.Y)
                {
                    rtn = 'N';
                }
                else
                {
                    rtn = 'S';
                }

                northSouth = false;
            }
            else
            {
                if (cellLocation == islandLocation)
                {
                    rtn = 'I';
                }
                else if (cellLocation.X == islandLocation.X)
                {
                    rtn = 'C';
                }
                else if (cellLocation.X > islandLocation.X)
                {
                    rtn = 'W';
                }
                else
                {
                    rtn = 'E';
                }

                northSouth = true;
            }
            return rtn;
        }

        public static void ResetScore()
        {
            Score = 0;
        }
        
        public static void AddToScore(int s = 1)
        {
            Score += s;
        }
    }
}
