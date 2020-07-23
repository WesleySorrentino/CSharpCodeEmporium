using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CodeEmporium
{
    class RockPaperScissorsLizardSpock : Challenges
    {
        public RockPaperScissorsLizardSpock(string title)
            : base(title)
        {
        }
        public static void Game(string userName)
        {
            bool gameOn = true;
            Console.WriteLine($"Hello {userName}, Welcome to Rock, Paper, Scissors, Lizard, Spock!");

            while (gameOn)
            {
                if (CheckWin(Input(), cpuMove()))
                {
                    gameOn = false;
                    Thread.Sleep(4000);
                }

            }
        }
        private static string Input()
        {
            Console.Write("Rock | Paper | Scissors | Lizard | Spock: ");
            string input = Console.ReadLine();

            return input;
        }
        private static string cpuMove()
        {
            var cpuMoves = new Random();

            string[] moves =
            {
                "Rock",
                "Paper",
                "Scissors",
                "Lizard",
                "Spock"
            };

            int move = cpuMoves.Next(0,moves.Length);
            string cpuMove = moves[move].ToString();

            return cpuMove;
        }
        private static bool CheckWin(string input, string cpuMove)
        {
            if ((input == "Rock" && cpuMove == "Scissors") || (input == "Rock" && cpuMove == "Lizard"))
            {
                Console.WriteLine($"You won! Cpu chose {cpuMove}!");
                return true;
            }
            else if ((input == "Scissors" && cpuMove == "Paper") || (input == "Scissors" && cpuMove == "Lizard"))
            {
                Console.WriteLine($"You won! Cpu chose {cpuMove}!");
                return true;
            }
            else if ((input == "Paper" && cpuMove == "Rock") || (input == "Paper" && cpuMove == "Spock"))
            {
                Console.WriteLine($"You won! Cpu chose {cpuMove}!");
                return true;
            }
            else if ((input == "Lizard" && cpuMove == "Paper") || (input == "Lizard" && cpuMove == "Spock"))
            {
                Console.WriteLine($"You won! Cpu chose {cpuMove}!");
                return true;
            }
            else if ((input == "Spock" && cpuMove == "Rock") || (input == "Spock" && cpuMove == "Scissors"))
            {
                Console.WriteLine($"You won! Cpu chose {cpuMove}!");
                return true;
            }
            else if (input == cpuMove)
            {
                Console.WriteLine("It's a Draw!");
                return false;
            }
            else
            {
                Console.WriteLine($"You loose! Cpu chose {cpuMove}");
                return false;
            }
        }
    }
}
