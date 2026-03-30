using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Exercise5
{
    public class Product
    {
        //properties
        public string ProductName { get; set; }
        public int ProductID { get; set; }
        public double Price {  get; set; }
        public string Category { get; set; }

        //constructors
        public Product(string productName, int productID, double price, string category)
        {
            ProductName = productName;
            ProductID = productID;
            Price = price;
            Category = category;
        }
        
        //methods
        public void PrintProductDetails()
        {
            Console.WriteLine($"The product {ProductName}, ID number {ProductID}, costs {Price:C} and belongs to the category {Category}");
        }

        public void ApplyDiscount(double discount)
        {
            Price -= Price * (discount / 100);
        }

    }
}
