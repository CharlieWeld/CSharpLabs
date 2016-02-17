// Task 3 - Motor Tax
using System;

class MotorTax
{
    int[] motorTaxRange = { 1000, 1200, 1400, 1600, 1800, 2000 };
    int[] costRange = { 150, 175, 200, 250, 300, 350, 500 };

    public int determineTax(int engine_size)
    {
        int cost;
        if (engine_size <= this.motorTaxRange[0])
        {
            cost = costRange[0];
        }
        else if (engine_size > motorTaxRange[0] && engine_size <= this.motorTaxRange[1])
        {
            cost = costRange[1];
        }
        else if (engine_size > motorTaxRange[1] && engine_size <= motorTaxRange[2])
        {
            cost = costRange[2];
        }
        else if (engine_size > motorTaxRange[2] && engine_size <= motorTaxRange[3])
        {
            cost = costRange[3];
        }
        else if (engine_size > motorTaxRange[3] && engine_size <= motorTaxRange[4])
        {
            cost = costRange[4];
        }
        else if (engine_size > motorTaxRange[4] && engine_size <= motorTaxRange[5])
        {
            cost = costRange[5];
        }
        else
        {
            cost = costRange[6];
        }

        return cost;
        
    }
    public static void Main(string[] args)
    {
        int engine_size, cost;
        Console.Write("Enter the size of your engine in cc: ");
        engine_size = int.Parse(Console.ReadLine());
        MotorTax myTax = new MotorTax();
        cost = myTax.determineTax(engine_size);

        Console.WriteLine("The cost of your motor tax is {0}", cost);
    }
}
