using System;
using System.Drawing;

namespace Rock_Paper_Scissors_Game
{
    internal class Program
    {
        const string Rock = "Rock";
        const string Paper = "Paper";
        const string Scissor = "Scissor";

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Welcome to the [Rock-Paper-Scissor] game!");
            Console.WriteLine("You are playing versus the computer.");
            Console.WriteLine("Do yo want to play: [y]es or [n]o:");
            string playing = Console.ReadLine();
            Console.WriteLine();

            int playerPoints = 0;
            int computerPoints = 0;
            bool isEnd = false;
            while (playing != "n" && playing != "no")
            {
                //Computer random move:
                string computerMove = string.Empty;
                Random random = new Random();
                int computerRandomNumber = random.Next(1, 4);

                //Start the game.
                Console.WriteLine("Please choose one of the following options:");
                Console.WriteLine("Choose: [r]ock, [p]aper or [s]cissor:");
                string playerMove = Console.ReadLine();

                //Player move options:
                if (playerMove == "r" || playerMove == "rock")
                {
                    playerMove = Rock;
                }
                else if (playerMove == "p" || playerMove == "paper")
                {
                    playerMove = Paper;
                }
                else if (playerMove == "s" || playerMove == "scissor")
                {
                    playerMove = Scissor;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid move.");
                    Console.ResetColor();
                    continue;
                }

                //Computer move options:
                switch (computerRandomNumber)
                {
                    case 1:
                        computerMove = Rock;
                        break;

                    case 2:
                        computerMove = Paper;
                        break;

                    case 3:
                        computerMove= Scissor;
                        break;
                }

                if (playerMove == Rock && computerMove == Rock ||
                    playerMove == Paper && computerMove == Paper ||
                    playerMove == Scissor && computerMove == Scissor)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Draw!");
                    Console.WriteLine($"Player [{playerMove}] draw Computer [{computerMove}]");
                    Console.ResetColor();
                }
                else if (playerMove == Rock && computerMove == Scissor ||
                    playerMove == Scissor && computerMove == Paper ||
                    playerMove == Paper && computerMove == Rock)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("You win!");
                    Console.WriteLine($"Player [{playerMove}] beats Computer [{computerMove}]");
                    Console.ResetColor();
                    playerPoints++;
                    
                }
                else
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("You lose!");
                    Console.WriteLine($"Computer [{computerMove}] beats Player [{playerMove}]");
                    Console.ResetColor();
                    computerPoints++;
                }
                Console.WriteLine($"Player points: [{playerPoints}] vs Computer points [{computerPoints}]");

                Console.WriteLine();
                Console.WriteLine("Do yo want to play: [y]es or [n]o:");
                playing = Console.ReadLine();

                if (playing == "y" || playing == "yes")
                {
                    Console.WriteLine();
                    continue;
                }
                else
                {
                    isEnd = true;
                    break;
                }
            }

            if (isEnd || playing == "n" || playing == "no")
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Game over! Let's play again!");
                Console.ResetColor();
            }
        }
    }
}
