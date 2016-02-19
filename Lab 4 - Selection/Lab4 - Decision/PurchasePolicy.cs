// Task 2 - Purchasing Policy

using System;

class PurchasingPolicy
{
    double lowerRange, upperRange;

    PurchasingPolicy(double lRange, double uRange)
    {
        lowerRange = lRange;
        this.upperRange = uRange;
    }

    public string determinePolicy(double cost)
    {
        string message;

        if (cost > upperRange)
        {
            message = "Tender the product.";
        }
        else if (cost >= lowerRange && cost <= upperRange)
        {
            message = "Get quotes from three different suppliers.";
        }
        else
        {
            message = "Go ahead and order the product.";
        }
        return message;
    }
    public static void Main(string[] args)
    {
        double cost;
        string message;

        Console.Write("Enter the cost of the product: ");
        cost = Convert.ToDouble(Console.ReadLine());

        PurchasingPolicy pPolicy = new PurchasingPolicy(500, 5000);

        message = pPolicy.determinePolicy(cost);

        Console.WriteLine(message);        
    }
        
}


      
        