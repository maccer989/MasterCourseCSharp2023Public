// TicTacToe Application
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using TicTacToe;
using TicTacToeLibrary;
using TicTacToeLibrary.Models;

ConsoleMessages.WelcomeMessage();
List<GridSpotModel> grid =GameLogic.InitialiseGrid();
GameModel game = GameLogic.CreateGame();

ConsoleMessages.CreateGrid(grid);

int gridNumber = 0;
int activePlayerID = 1;
int opponentPlayerID = 2;
game.MatchWinningPlayer = null;
bool doesMatchStop = false;
string matchResult = "";


do
    {
        gridNumber = ConsoleMessages.SelectGridNumber(activePlayerID);
        ConsoleMessages.UpdateGrid(grid, gridNumber, activePlayerID);

        (doesMatchStop,matchResult) = GameLogic.DoesMatchEnd(grid);
    

    if (doesMatchStop == false)
    {
        (activePlayerID, opponentPlayerID) = (opponentPlayerID, activePlayerID);

    }
    else if (matchResult == "win")
    {
        game.MatchWinningPlayer = activePlayerID.ToString();
        ConsoleMessages.IdentifyWinner(game.MatchWinningPlayer);
    }
    else if(matchResult == "draw")
    {
        Console.WriteLine("End of match. \r\nMatch is a draw.");
    } 

} while (doesMatchStop == false);

 
 




