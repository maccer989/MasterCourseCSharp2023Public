using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TicTacToeLibrary.Models;

namespace TicTacToe
{
    public static class ConsoleMessages
    {

        public static void WelcomeMessage()
        {
            Console.WriteLine("************************");
            Console.WriteLine("*                      *");
            Console.WriteLine("* Welcome to TicTacToe *");
            Console.WriteLine("*    Created by IMCN   *");
            Console.WriteLine("*                      *");
            Console.WriteLine("************************");
            Console.WriteLine();
            Console.WriteLine("Player1 will go first and is X, Player 2 will go second and is O.");
            Console.WriteLine();
        }

        public static void CreateGrid(List<GridSpotModel> grid)
        {
            Console.WriteLine();
            Console.WriteLine($" {grid[0].GridNumber} | {grid[1].GridNumber} | {grid[2].GridNumber} ");
            Console.WriteLine("___|___|___");
            Console.WriteLine($" {grid[3].GridNumber} | {grid[4].GridNumber} | {grid[5].GridNumber} ");
            Console.WriteLine("___|___|___");
            Console.WriteLine($" {grid[6].GridNumber} | {grid[7].GridNumber} | {grid[8].GridNumber} ");
            Console.WriteLine();
        }


        public static void UpdateGrid(List<GridSpotModel> grid, int gridNumber, int playerID)
        {

            foreach (GridSpotModel gridSpot in grid) 
            {
                if (gridSpot.GridNumber == gridNumber.ToString() && playerID == 1)
                {
                    gridSpot.GridNumber = "X";

                }
                else if(gridSpot.GridNumber == gridNumber.ToString() && playerID == 2)
                {
                    gridSpot.GridNumber = "O";
                }
            }
            Console.WriteLine();
            Console.WriteLine($" {grid[0].GridNumber} | {grid[1].GridNumber} | {grid[2].GridNumber} ");
            Console.WriteLine("___|___|___");
            Console.WriteLine($" {grid[3].GridNumber} | {grid[4].GridNumber} | {grid[5].GridNumber} ");
            Console.WriteLine("___|___|___");
            Console.WriteLine($" {grid[6].GridNumber} | {grid[7].GridNumber} | {grid[8].GridNumber} ");
            Console.WriteLine();
        }


        //public static void PrintResult(GameModel game)
        //{
        //    Console.WriteLine($"Match {game.MatchNumber} out of {game.MatchTotal} matches");
        //    Console.WriteLine($"Player1:{game.Player1TotalWins}-{game.Player2TotalWins}:Player2; \n\rMatches Drawn: {game.TotalMatchesDrawn}");
        //}

        public static int SelectGridNumber(int activePlayer)
        {
            Console.Write($"Player{activePlayer}, please select a number from the grid:");
            //put loop in to check for valid number
            bool isValid = int.TryParse( Console.ReadLine(), out int gridNumber );
            return gridNumber;
        }

        public static void IdentifyWinner(string matchWinningPlayer)
        {
            Console.WriteLine($"End of match. \r\nCongratulations to Player{matchWinningPlayer} for winning");
        }
    }
}
