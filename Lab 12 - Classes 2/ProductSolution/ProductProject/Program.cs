using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Products;

namespace ProductsMain
{ 
    class Program
    {
        static void Main(string[] args)
        {
            // 1. create product with details
            Product p1 = new Product(123, "Banana", 3.0, 2.0);

            // 2. buy 100 units
            p1.RenewalStockLevel(100);
            p1.printProduct();


            // 3. sell to user and display accumulated profit
            string input;
            bool success;
            int quantity;

            do
            {
                Console.Write("buy / exit: ");
                input = Console.ReadLine();

                if (input.Equals("buy"))
                {
                    Console.Write("Enter the number of products to buy: ");
                    quantity = int.Parse(Console.ReadLine());

                    success = p1.Sell(quantity);

                    if (success)
                    {
                        Console.WriteLine("Thank you for your purchase\n");
                        p1.printProfit();
                    }
                    else
                        Console.WriteLine("We do not have that many in stock!\n");
                }
            }
            while (input.Equals("buy"));
        }
    }
}
