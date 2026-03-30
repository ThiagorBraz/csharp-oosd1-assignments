using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.UTF8;

            //SETUP
            decimal BasicSeatCost, TotalFlightTicket;
            int TotalNumberOfSeats, TotalBags10kg, TotalBags20kg, TotalMeal;
            const int
                PriceBags10kg = 20,
                PriceBags20kg = 30,
                PriceMeal = 10,
                PriceReservedSeat = 5;

            //INPUT
            Console.WriteLine("Please insert the basic seat cost for you flight.");
            BasicSeatCost = decimal.Parse(Console.ReadLine());

            Console.WriteLine("How many 10kg checked bags do you require? (Price per bag is EUR 20,00)");
            TotalBags10kg = int.Parse(Console.ReadLine()) * PriceBags10kg;

            Console.WriteLine("How many 20kg checked bags do you require? (Price per bag is EUR 30,00)");
            TotalBags20kg = int.Parse(Console.ReadLine()) * PriceBags20kg;

            Console.WriteLine("How many on board meals do you require? (Price per meal is EUR 10,00)");
            TotalMeal = int.Parse(Console.ReadLine()) * PriceMeal;

            Console.WriteLine("How many reserved seats do you require? (Price per reserved seat is EUR 5,00)");
            TotalNumberOfSeats = int.Parse(Console.ReadLine()) * PriceReservedSeat;

            //PROCESSING
            TotalFlightTicket = BasicSeatCost + TotalBags10kg + TotalBags20kg + TotalMeal + TotalNumberOfSeats;

            //OUTPUT
            Console.WriteLine($"The total amount for your flight ticket is {TotalFlightTicket:C}.");

        }
    }
}
