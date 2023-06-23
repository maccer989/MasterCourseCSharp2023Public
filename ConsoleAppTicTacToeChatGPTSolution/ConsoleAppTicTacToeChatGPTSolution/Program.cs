//This is the ChatGPT Solution to create TICTACTOE

char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
char currentPlayer = 'X';

bool gameEnded = false;

while (!gameEnded)
{
    DrawBoard(board);
    int move = GetPlayerMove(board, currentPlayer);
    board[move - 1] = currentPlayer;
    gameEnded = CheckGameEnd(board, currentPlayer);

    if (!gameEnded)
    {
        currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
    }
}

DrawBoard(board);
Console.WriteLine("Game over!");

static void DrawBoard(char[] board)
{
    Console.Clear();
    Console.WriteLine("   |   |   ");
    Console.WriteLine(" {0} | {1} | {2} ", board[0], board[1], board[2]);
    Console.WriteLine("___|___|___");
    Console.WriteLine("   |   |   ");
    Console.WriteLine(" {0} | {1} | {2} ", board[3], board[4], board[5]);
    Console.WriteLine("___|___|___");
    Console.WriteLine("   |   |   ");
    Console.WriteLine(" {0} | {1} | {2} ", board[6], board[7], board[8]);
    Console.WriteLine("   |   |   ");
}

static int GetPlayerMove(char[] board, char currentPlayer)
{
    int move = 0;
    bool validMove = false;

    while (!validMove)
    {
        Console.Write($"Player {currentPlayer}, enter your move (1-9): ");
        if (int.TryParse(Console.ReadLine(), out move))
        {
            if (move >= 1 && move <= 9 && board[move - 1] != 'X' && board[move - 1] != 'O')
            {
                validMove = true;
            }
            else
            {
                Console.WriteLine("Invalid move. Please try again.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number (1-9).");
        }
    }

    return move;
}

static bool CheckGameEnd(char[] board, char currentPlayer)
{
    if (CheckWin(board))
    {
        Console.WriteLine($"Player {currentPlayer} wins!");
        return true;
    }
    else if (CheckDraw(board))
    {
        Console.WriteLine("It's a draw!");
        return true;
    }

    return false;
}

static bool CheckWin(char[] board)
{
    // Check rows
    if ((board[0] == board[1] && board[1] == board[2]) ||
        (board[3] == board[4] && board[4] == board[5]) ||
        (board[6] == board[7] && board[7] == board[8]))
    {
        return true;
    }

    // Check columns
    if ((board[0] == board[3] && board[3] == board[6]) ||
        (board[1] == board[4] && board[4] == board[7]) ||
        (board[2] == board[5] && board[5] == board[8]))
    {
        return true;
    }

    // Check diagonals
    if ((board[0] == board[4] && board[4] == board[8]) ||
        (board[2] == board[4] && board[4] == board[6]))
    {
        return true;
    }

    return false;
}

static bool CheckDraw(char[] board)
{
    foreach (char cell in board)
    {
        if (cell != 'X' && cell != 'O')
        {
            return false;
        }
    }

    return true;
}