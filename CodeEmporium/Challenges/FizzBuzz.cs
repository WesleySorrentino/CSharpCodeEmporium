﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEmporium
{
    //Write a program that prints the numbers from 1 to 100. But for multiples of three print "Fizz" instead of the number 
    //and for the multiples of five print "Buzz". For numbers which are multiples of both three and five print "FizzBuzz".
    class FizzBuzz : Challenges
    {
        public FizzBuzz(string title) 
            : base(title)
        {
        }
        public static void Challenge(string userName)
        {
            Console.WriteLine($"Hello {userName}, Welcome to FizzBuzz.");
            FizzBuzzCalculation();
        }
        private static void FizzBuzzCalculation()
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");   
            }
            Console.ReadLine();
        }
    }
}
