// Task 1 - Sum numbers between 50 & 100
// Inputs: Numbers between 50 & 100
// Output: Sum of inputs
// Process: 1. Start total at 50
// 2. increment count number to 51
// 3. add to total
// 4. repeat steps 2 - 3 Until count number reaches 100
// 5. display the total to the user
// Test data: numbers from 50 to 100
// Expected Output: 

using System;
class Sum
{
    public int sumNumbers(int start, int stop)
    {
        int total = 0;
        for (int count= start; count < stop+1; count++)
        {
            total += count;
        }
        return total;
    }

    public static void Main(string [] args)
    {
        /*
        Sum MySum = new Sum();

        int total = MySum.sumNumbers(50, 100);
        Console.WriteLine(total);
        */
        Floats flt = new Floats();
        Console.WriteLine("Enter five floating values to find the average");
        Console.Write("Float 1: ");
        flt.f1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Float 2: ");
        flt.f2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Float 3: ");
        flt.f3 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Float 4: ");
        flt.f4 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Float 5: ");
        flt.f5 = Convert.ToDouble(Console.ReadLine());

        double average = flt.floatAverage();
        Console.WriteLine("The average of the floats is " + string.Format("{0:0.00}", average));
    }
}