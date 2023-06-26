using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeLibrary.Models;

namespace TicTacToeLibrary
{
    public static class GameLogic
    {

        public static List<GridSpotModel>  InitialiseGrid()
        {
            List<GridSpotModel> grid = new List<GridSpotModel>();

            for (int i = 1; i < 10; i++)
            {
                GridSpotModel spot = new GridSpotModel
                {
                    GridNumber = i.ToString(),
                };

                grid.Add(spot);

            }
            return grid;

        }



        public static GameModel CreateGame()
        {
            GameModel game = new GameModel
            {                
                MatchWinningPlayer = "",                
    
            };
            return game;


        }
 
        public static bool DetermineWin(List<GridSpotModel> grid)
        {
            //check rows
            if 
                (
                grid[0].GridNumber == grid[1].GridNumber && grid[1].GridNumber == grid[2].GridNumber ||
                grid[3].GridNumber == grid[4].GridNumber && grid[4].GridNumber == grid[5].GridNumber ||
                grid[6].GridNumber == grid[7].GridNumber && grid[7].GridNumber == grid[8].GridNumber
                )
            {
                return true;
            }

            ////check columns
            if
                (
                grid[0].GridNumber == grid[3].GridNumber && grid[3].GridNumber == grid[6].GridNumber ||
                grid[1].GridNumber == grid[4].GridNumber && grid[4].GridNumber == grid[7].GridNumber ||
                grid[2].GridNumber == grid[5].GridNumber && grid[5].GridNumber == grid[8].GridNumber
                )
            {
                return true;
            }

            ////check diagonals
            if
                (
                grid[0].GridNumber == grid[4].GridNumber && grid[4].GridNumber == grid[8].GridNumber ||
                grid[6].GridNumber == grid[4].GridNumber && grid[4].GridNumber == grid[2].GridNumber 
                )
            {
                return true;
            }
            return false;
        }

        public static (bool, string) DoesMatchEnd(List<GridSpotModel> grid)
        {
            if (DetermineWin(grid))
            {
                    return (true, "win");
            }
            else if(DetermineDraw(grid))
            {
                return (true, "draw");
            }

            return (false, "none")  ;
        }

        private static bool DetermineDraw(List<GridSpotModel> grid)
        {
            foreach (var item in grid)
            {
                if (item.GridNumber != "X" && item.GridNumber != "O")
                {
                    return false;
                }
            }
            return true;

        }
    }
}
