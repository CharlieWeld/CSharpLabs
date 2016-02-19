using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sales;

class Program
{
    static void Main(string[] args)
    {
        int noSalesMen;

        Console.Write("Enter the number of salesmen: ");
        noSalesMen = int.Parse(Console.ReadLine());

        // Create a new Salesman object with the number of sales men in the array
        Salesman salesman = new Salesman(noSalesMen);

        // Enter the details about each salesman
        for (int i = 0; i < noSalesMen; i++)
        {
            Console.Write("Enter the name of the salesman " + (i + 1) + ": ");
            salesman.Names[i] = Console.ReadLine();
            Console.Write("Enter the sales made by this salesman: ");
            salesman.Sales[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Calculating total sales and selecting the best salesman updates
        // the instance variables of 'salesman' which can then be accessed
        // using properties
        salesman.calcTotalSales();
        salesman.bestSalesMan();
        Console.WriteLine(String.Format("\nThe total sales is {0:0.00}", salesman.TotalSales));
        Console.WriteLine("The best salesman is " + salesman.BestSalesMan);

    }
}

