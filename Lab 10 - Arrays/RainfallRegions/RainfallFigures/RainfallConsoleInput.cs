using System;

// This class implements the input interface for Rainfall
// The input is taken from the Console

public class RainfallConsoleInput:IRainfallInput
{
    public int[] getRegions()
    {
        int[] regions = new int[2];

        Console.Write("Enter the number of regions being sampled: ");
        regions[0] = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of months being sampled: ");
        regions[1] = int.Parse(Console.ReadLine());

        return regions;
    }

    public double[,] getRainfall(int x, int y)
    {
        double[,] tempArr = new double[x, y];

        for (int i=0; i< x; i++)
        {
            for(int k=0; k< y; k++)
            {
                Console.Write("Enter " + i + "->" + k + ": ");
                tempArr[i, k] = Double.Parse(Console.ReadLine());
            }
        }

        return tempArr;
    }
}

