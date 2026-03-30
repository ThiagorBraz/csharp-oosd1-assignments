using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.OutputEncoding = Encoding.UTF8;

            double annualSalary = 24000;
            double monthlySalary = annualSalary / 12;

            Console.WriteLine("Please enter you name.");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter your total sales this month.");
            double monthlySales = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your monthly target.");
            double monthlyTarget = double.Parse(Console.ReadLine());

            double commission = CalculateCommission(monthlySales, monthlyTarget);

            double totalEarnings = monthlySalary + commission;

            double tax = CalculateTax(totalEarnings);

            double prsi = CalculatePRSI(totalEarnings);

            double retirementContribution = CalculateRetirementContribution(totalEarnings);

            double healthInsurance = CalculateHealthInsurance();

            double TotalDeduction = tax + prsi + retirementContribution + healthInsurance;

            double netSalary = totalEarnings - tax - prsi - retirementContribution - healthInsurance;

            Console.Clear();

            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            Console.WriteLine($"Payment Summary for {name}\n");
            Console.WriteLine("Earnings\n");
            Console.WriteLine($"Your montlhy basic salary is {monthlySalary:C}");
            Console.WriteLine($"This month's commission is {commission:C}");
            Console.WriteLine($"Your total earnings this month is {totalEarnings:C}\n");
            Console.WriteLine("Deductions\n");
            Console.WriteLine($"The total tax this month is {tax:C}");
            Console.WriteLine($"The total PRSI this month is {prsi:C}");
            Console.WriteLine($"The total retirement contribution this month is {retirementContribution:C}");
            Console.WriteLine($"Your fixed health insurance per month is {healthInsurance:C}");
            Console.WriteLine($"Your total deduction this month is {TotalDeduction:C}\n");
            Console.WriteLine($"Your net salary this month is {netSalary:C}");
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");


        }

        static double CalculateCommission(double sales, double target)

        {
            double commission;

            if (sales <= target)
            {
                commission = sales * 0.05;
            }
            else
            {
                commission = target * 0.05 + (sales - target) * 0.10;
            }
            return commission;

        }

        static double CalculateTax(double totalEarnings)
        {
            return totalEarnings * 0.2;
        }

        static double CalculatePRSI(double totalEarnings)
        {
            return totalEarnings * 0.04;
        }
        static double CalculateRetirementContribution(double totalEarnings)
        {
            return totalEarnings * 0.1;
        }
        static double CalculateHealthInsurance()
        {
            return 50;
        }
    }
}