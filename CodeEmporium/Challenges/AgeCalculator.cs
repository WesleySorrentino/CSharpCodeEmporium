using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CodeEmporium
{
    class AgeCalculator : Challenges
    {
        public AgeCalculator(string title) 
            : base(title)
        {
        }
        public static void Challenge(string userName)
        {
            Console.Clear();
            Console.WriteLine($"Hello {userName}, Welcome to the Age Calculator!");
            Calculation(Input());
            Console.ReadLine();
        }
        private static DateTime Input()
        {
            Console.Write("Enter your date of birth seperated by '/': ");
            var birthdate = Convert.ToDateTime(Console.ReadLine());

            return birthdate;
        }
        private static void Calculation(DateTime birthDate)
        {

            var today = DateTime.Now;

            var calculation = today - birthDate;

            string text = "You have been alive for:\n" +
                $"Days: {Convert.ToInt32(calculation.TotalDays)}\n" +
                $"Hours: {Convert.ToInt32(calculation.TotalHours)}\n" + 
                $"Minutes: {Convert.ToInt32(calculation.TotalMinutes)}\n" +
                $"Seconds: {Convert.ToInt32(calculation.TotalSeconds)}\n";

            Console.WriteLine(text);
        }
    }
}
