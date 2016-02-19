using System;

// This class implements the IPrintRainfall interface
// which is used by the Rainfall program to print to the Console

public class PrintRainfallConsole:IPrintRainfall
{
    public void printAvgRainfall(double[] avgRainfallArray)
    {
        for (int i=0; i<avgRainfallArray.Length; i++)
        {
            Console.WriteLine("The average rainfall in region " + (i+1) + " was: " + String.Format("{0:0.00}",avgRainfallArray[i]));
        }
        Console.WriteLine();
    }

    public void printRainfall(double[,] rainfallArray)
    {
        Console.WriteLine(rainfallArray.GetLength(0) + " " + rainfallArray.LongLength);
        for (int i = 0; i<rainfallArray.GetLength(0); i++)
        {
            
            for (int j = 0; j<rainfallArray.GetLength(1); j++)
            {
                Console.WriteLine("Rainfall in region " + (i+1) + " month " + (j+1) + ": " + String.Format("{0:0.00}",rainfallArray[i, j]));
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public void printText(string text)
    {
        Console.WriteLine(text);
    }
}