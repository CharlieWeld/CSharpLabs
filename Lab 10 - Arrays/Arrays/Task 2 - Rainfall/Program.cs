using System;
using Rainfall;

class Program
{
        static void Main(string[] args)
        {
        RainfallRecorder recorder = new RainfallRecorder();

        double[] rainArr = new double[7] { 1.2, 3.4, 1.2, 2.0, 2.3, 5.5, 3.4 };

        recorder.RainfallArray = rainArr;

        double total = recorder.calcTotalRainfall();
        double average = recorder.calcAverageRainfall();

        Console.WriteLine("Total rainfall for the week is " + total);
        Console.WriteLine("Average rainfall for the week is " + average);

        if (recorder.overLimit())
        {
            Console.WriteLine("The rainfall exceeding the maximum daily limit!");
        }
        }
}
