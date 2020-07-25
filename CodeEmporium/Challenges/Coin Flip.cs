using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CodeEmporium
{
    class Coin_Flip : Challenges
    {
        public Coin_Flip(string title) : base(title)
        {
        }
        public static void Challenge(string userName)
        {
            //Ask's user to enter their heads and tails arguement
            Console.WriteLine($"Welcome to the Coin flip program {userName}!");
            Console.Write("Enter your heads arguement: ");
            string heads = Console.ReadLine();
            Console.Write("Enter your tails arguement: ");
            string tails = Console.ReadLine();
            DisplayResult(heads, tails, CoinFlip());
            Thread.Sleep(4000);
        }
        private static string CoinFlip()
        {
            //Flips coin and returns what the result is
            var random = new Random();
            string[] coinSides = { "Heads", "Tails" };

            int flip = random.Next(0, coinSides.Length);
            string result = coinSides[flip].ToString();

            return result;
        }
        private static void DisplayResult(string headsArg, string tailsArg, string result)
        {
            //Display's the result
            switch (result)
            {
                case "Heads":
                    Console.WriteLine($"You got {result} {headsArg}");
                    break;
                case "Tails":
                    Console.WriteLine($"You got {result} {tailsArg}");
                    break;
                default:
                    break;
            }
        }
    }
}
