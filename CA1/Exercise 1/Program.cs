using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1_Thiago_Braz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SETUP
            string Name;
            int DayOfBirth, MonthOfBirth, YearOfBirth, AgeinDays;

            //INPUT
            Console.WriteLine("Please enter your name.");
            Name = Console.ReadLine();

            Console.WriteLine("Please enter your day of birth.");
            DayOfBirth = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your month of birth.");
            MonthOfBirth = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your year of birth.");
            YearOfBirth = int.Parse(Console.ReadLine());

            //PROCESSING
            DateTime BirthDate = new DateTime(YearOfBirth, MonthOfBirth, DayOfBirth);
            DateTime TodayDate = DateTime.Now;

            TimeSpan DateDifference = TodayDate - BirthDate;
            AgeinDays = DateDifference.Days;

            //OUTPUT
            Console.WriteLine("Hello {0}! You are {1} days old.", Name, AgeinDays);

        }
    }
}
