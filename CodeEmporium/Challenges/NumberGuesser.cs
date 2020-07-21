using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CodeEmporium;

namespace CodeEmporium
{
    class NumberGuesser : Challenges
    {
        public NumberGuesser(string title) 
            : base(title)
        {

        }
        public static void Game(string userName)
        {
            bool gameOn = true;
            int guesses = 0;
            int number = RandomNumber(1, 100);
            Console.WriteLine($"Hello {userName}, Welcome to the Higher Lower game!");
            Console.WriteLine("How to play: Choose a number from 1 - 100.");
            while (gameOn)
            {
                if (CheckWin(Input(), number))
                {
                    Console.WriteLine($"You Win! You got it in {guesses} guesses!");
                    gameOn = false;
                    Thread.Sleep(4000);
                }
                else
                {
                    Console.WriteLine("Try again!");
                    guesses++;
                }                
            }
        }
        private static int Input()
        {
            Console.Write("Enter a number: ");
            int guess = Convert.ToInt32(Console.ReadLine());

            return guess;
        }
        private static int RandomNumber(int lowNum, int highNum)
        {
            var random = new Random();
            var number = random.Next(lowNum, highNum);

            return number;
        }
        private static bool CheckWin(int input, int number)
        {
            if (input == number)
                return true;
            else if (input > number)
            {
                Console.WriteLine("Your guess is Higher than number!");
                return false;
            }

            else if (input < number)
            {
                Console.WriteLine("Your guess is Lower than number!");
                return false;
            }
            else
                return false;
        }
    }
}
