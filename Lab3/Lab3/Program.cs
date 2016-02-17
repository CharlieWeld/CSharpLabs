// Lab 3 - Console I/O and Strings
// Task 1
// a. Calculates the hours and minutes per day spent on dressing
// eating 3 times, driving 2 times and having 4 classes

// b. Class - Schedule
// void Main, int Dress, int Eat, int Drive, int Class
// int totalmins

// c. Dress, Eat, Drive, Class

// d. returns the remainder after division
// totalmins % 60 returns the remainder of the division

// Task 2 - seconds to hours, minutes, seconds
// input: total seconds
// output: hours, minutes, seconds
// steps: 1. divide total seconds by 3600 to get hours
// 2. modules total seconds by 3600 to get the remaing seconds after hours have
// been taken away
// 3. divide remaining seconds by 60 to get minutes
// modulus remaining seconds to remove the minutes and only leave the seconds

class TimeConverter
{
    private int hours, minutes, seconds;

    public void convertSecsToTime(int totalSecs)
    {
        int tempSecs = totalSecs; // holds the total seconds for the printing at the end
        this.hours = totalSecs / 3600;
        totalSecs = totalSecs % 3600;
        this.minutes = totalSecs / 60;
        seconds = totalSecs % 60;

        System.Console.Write("The number of hours:minutes:seconds from " + tempSecs);
        System.Console.WriteLine(" is " + hours + ":" + minutes + ":" + this.seconds);
    }



    public static void Main(string[] args)
    {
        int totalSecs;
        System.Console.Write("Enter the number of seconds to be converted: ");
        totalSecs = int.Parse(System.Console.ReadLine());

        TimeConverter time1 = new TimeConverter();
        time1.convertSecsToTime(totalSecs);
    }

}
