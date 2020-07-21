using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEmporium
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Title = "Code Emporium";
            Console.WriteLine("Welcome to the Code Emporium!");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"\nHello {name}!");

            Challenges(name);
        }
        static void Challenges(string userName)
        {            
            var challenges = new List<Challenges>();
            challenges.Add(new NumberGuesser("Higher/Lower"));
            challenges.Add(new RockPaperScissorsLizardSpock("Rock, Paper, Scissors, Lizard, Spock"));
            challenges.Add(new Coin_Flip("Coin Flip"));
            challenges.Add(new AgeCalculator("Age Calculator"));
            challenges.Add(new FizzBuzz("FizzBuzz"));

            try
            {
                while (true)
                {
                    int number = 1;                    
                    foreach (var challenge in challenges)
                    {
                        Console.WriteLine($"{number++}. {challenge.Title}.");
                    }

                    Console.Write("\nType a number for the desired challenge or Press 9 to quit: ");
                    int input = Convert.ToInt32(Console.ReadLine());

                    switch (input)
                    {
                        case 1:
                            NumberGuesser.Game(userName);
                            break;
                        case 2:
                            RockPaperScissorsLizardSpock.Game(userName);
                            break;
                        case 3:
                            Coin_Flip.Challenge(userName);
                            break;
                        case 4:
                            AgeCalculator.Challenge(userName);
                            break;
                        case 5:
                            FizzBuzz.Challenge(userName);
                            break;
                        case 9:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Enter a number listed above!");
                            Console.Clear();
                            break;
                    }                    
                }
            }
            catch (FormatException e)
            {
                throw new FormatException($"Make sure to enter a number!\nError: {e}");
            }
        }
    }
}
