using System;


// Lab 3 - Task 3 - calculate total seconds from hours:minutes:seconds
// Inputs: hours, minutes, seconds
// Outputs: total time in seconds
// Steps: 1. get hours, minutes and seconds
// 2. multiple hours by 3600 to get seconds
// 3. multiple minutes by 60 to get seconds
// 4. sum all seconds together and display result

class TimeReversed
{
    int convertTimetoSecs(int h, int m, int s)
    {
        int totalSecs = 0;
        totalSecs += h * 3600;
        totalSecs += m * 60;
        totalSecs += s;
        return totalSecs;
    }
        public static void Main()
        {
        int hours, minutes, seconds, totalSecs;
        Console.Write("Enter the time to convert it to seconds\n" +
            "Hours: ");
        hours = int.Parse(Console.ReadLine());
        Console.Write("Minutes: ");
        minutes = int.Parse(Console.ReadLine());
        Console.Write("Seconds: ");
        seconds = int.Parse(Console.ReadLine());

        TimeReversed tr1 = new TimeReversed();
        totalSecs = tr1.convertTimetoSecs(hours, minutes, seconds);

        Console.WriteLine("The time in seconds is " + totalSecs);

        }
}

