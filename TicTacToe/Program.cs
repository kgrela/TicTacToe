using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            // create two boards - with starting and with current fields
            char[,] startBoard = {
                { '1', '2', '3' },
                { '4', '5', '6' },
                { '7', '8', '9' }
            };

            char[,] gameBoard = startBoard.Clone() as char[,];

            // flags
            bool player1Won = false;
            bool player2Won = false;
            bool nextIsPlayer1 = true; // true - player 1 move, false - player 2 move

            // loop over rounds
            for (int round = 0; round < gameBoard.Length; round++)
            {
                Console.Clear();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(gameBoard[i, j]);
                    }
                    Console.WriteLine();
                }


                if (nextIsPlayer1)
                {
                    Console.WriteLine("[P1] Where would you like to put the character?");
                    char x = Console.ReadKey().KeyChar;

                    if (x == '1')
                    {
                        if (gameBoard[0, 0] == '1') gameBoard[0, 0] = 'x';
                    }
                    else if (x == '2')
                    {
                        if (gameBoard[0, 1] == '2') gameBoard[0, 1] = 'x';
                    }
                    else if (x == '3')
                    {
                        if (gameBoard[0, 2] == '3') gameBoard[0, 2] = 'x';
                    }
                    else if (x == '4')
                    {
                        if (gameBoard[1, 0] == '4') gameBoard[1, 0] = 'x';
                    }
                    else if (x == '5')
                    {
                        if (gameBoard[1, 1] == '5') gameBoard[1, 1] = 'x';
                    }
                    else if (x == '6')
                    {
                        if (gameBoard[1, 2] == '6') gameBoard[1, 2] = 'x';
                    }
                    else if (x == '7')
                    {
                        if (gameBoard[2, 0] == '7') gameBoard[2, 0] = 'x';
                    }
                    else if (x == '8')
                    {
                        if (gameBoard[2, 1] == '8') gameBoard[2, 1] = 'x';
                    }
                    else if (x == '9')
                    {
                        if (gameBoard[2, 2] == '9') gameBoard[2, 2] = 'x';
                    }
                    else Console.WriteLine("Couldn't find the cell or the cell is already taken, you miss your turn!");

                    nextIsPlayer1 = false;
                }
                else
                {
                    Console.WriteLine("[P2] Where would you like to put the character?");
                    char x = Console.ReadKey().KeyChar;

                    if (x == '1')
                    {
                        if (gameBoard[0, 0] == '1') gameBoard[0, 0] = 'o';
                    }
                    else if (x == '2')
                    {
                        if (gameBoard[0, 1] == '2') gameBoard[0, 1] = 'o';
                    }
                    else if (x == '3')
                    {
                        if (gameBoard[0, 2] == '3') gameBoard[0, 2] = 'o';
                    }
                    else if (x == '4')
                    {
                        if (gameBoard[1, 0] == '4') gameBoard[1, 0] = 'o';
                    }
                    else if (x == '5')
                    {
                        if (gameBoard[1, 1] == '5') gameBoard[1, 1] = 'o';
                    }
                    else if (x == '6')
                    {
                        if (gameBoard[1, 2] == '6') gameBoard[1, 2] = 'o';
                    }
                    else if (x == '7')
                    {
                        if (gameBoard[2, 0] == '7') gameBoard[2, 0] = 'o';
                    }
                    else if (x == '8')
                    {
                        if (gameBoard[2, 1] == '8') gameBoard[2, 1] = 'o';
                    }
                    else if (x == '9')
                    {
                        if (gameBoard[2, 2] == '9') gameBoard[2, 2] = 'o';
                    }
                    else Console.WriteLine("Couldn't find the cell or the cell is already taken, you miss your turn!");

                    nextIsPlayer1 = true;
                }


                // check if one of players won
                if (gameBoard[0, 0] == gameBoard[0, 1] && gameBoard[0, 1] == gameBoard[0, 2])
                {
                    if (gameBoard[0, 0] == 'x') player1Won = true;
                    else player2Won = true;
                }
                else if (gameBoard[1, 0] == gameBoard[1, 1] && gameBoard[1, 1] == gameBoard[1, 2])
                {
                    if (gameBoard[1, 0] == 'x') player1Won = true;
                    else player2Won = true;
                }
                else if (gameBoard[2, 0] == gameBoard[2, 1] && gameBoard[2, 1] == gameBoard[2, 2])
                {
                    if (gameBoard[2, 0] == 'x') player1Won = true;
                    else player2Won = true;
                }
                else if (gameBoard[0, 0] == gameBoard[1, 0] && gameBoard[1, 0] == gameBoard[2, 0])
                {
                    if (gameBoard[1, 0] == 'x') player1Won = true;
                    else player2Won = true;
                }
                else if (gameBoard[0, 1] == gameBoard[1, 1] && gameBoard[1, 1] == gameBoard[2, 1])
                {
                    if (gameBoard[0, 1] == 'x') player1Won = true;
                    else player2Won = true;
                }
                else if (gameBoard[0, 2] == gameBoard[1, 2] && gameBoard[1, 2] == gameBoard[2, 2])
                {
                    if (gameBoard[0, 2] == 'x') player1Won = true;
                    else player2Won = true;
                }
                else if (gameBoard[0, 0] == gameBoard[1, 1] && gameBoard[1, 1] == gameBoard[2, 2])
                {
                    if (gameBoard[0, 0] == 'x') player1Won = true;
                    else player2Won = true;
                }
                else if (gameBoard[2, 0] == gameBoard[1, 1] && gameBoard[1, 1] == gameBoard[0, 2])
                {
                    if (gameBoard[2, 0] == 'x') player1Won = true;
                    else player2Won = true;
                }


                if (player1Won || player2Won)
                    break;
            }

            // end the game
            Console.Clear();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(gameBoard[i, j]);
                }
                Console.WriteLine();
            }

            // print result
            Console.WriteLine("Game ended!");
            if (player1Won == true) Console.WriteLine("Player 1 won!");
            else if (player2Won == true) Console.WriteLine("Player 2 won!");
            else Console.WriteLine("There is no winner!");
        }
    }
}