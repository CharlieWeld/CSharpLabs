// Task 3 - allow user enter any number of floats
// enter 0 to quit and get average of floats entered

class Stats2
{
    public double averageFloats()
    {
        double input, total = 0;
        int count = 0;

        do
        {
            System.Console.Write("Enter a floating value: ");
            input = System.Convert.ToDouble(System.Console.ReadLine());
            total += input;
            count++;
        }
        while (input != 0);
        count--;

        return (total / count);
    }

    public static void Main(string[] args)
    {
        double average;
        Stats2 stats = new Stats2();
        average = stats.averageFloats();

        System.Console.WriteLine("The average of the values entered is " + string.Format("{0:0.00}", average));
    }
}