using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Objects
            Product product1 = new Product("Christmas Tree", 1001, 100, "Christmas Decorations");

            Product product2 = new Product("Easter Bunny L", 3002, 50, "Easter Decorations");


            //Display product details before discount
            product1.PrintProductDetails();

            product2.PrintProductDetails();

            Console.WriteLine();

            //Applying discount
            product1.ApplyDiscount(10);

            product2.ApplyDiscount(10);


            //Display product details after discount
            Console.WriteLine("We can offer you a discount! The products details' with the new price are:");

            Console.WriteLine();

            product1.PrintProductDetails();

            product2.PrintProductDetails();
        }
    }
}
