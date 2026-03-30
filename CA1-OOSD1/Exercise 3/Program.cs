using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please type your awarded grade.");
            double AwardedGrade = int.Parse(Console.ReadLine());

            AwardedGrade = CalculateRevisedGrade(AwardedGrade);

            Console.WriteLine($"Your revised grade is {AwardedGrade:F0}");

        }


        static double CalculateRevisedGrade(double awardedGrade)

        {
            double RevisedGrade = awardedGrade * 1.15;

            return RevisedGrade;
        }

    }



}
