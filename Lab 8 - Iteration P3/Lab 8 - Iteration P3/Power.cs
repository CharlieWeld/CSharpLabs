// Task 2 - raise number to a power

class Power
{
    public int raisePower(int number, int power)
    {
        int originalNumber = number;

        for (int i = 1; i < power; i++)
        {
            number *= originalNumber;
        }
        return number;
    }

    public static void Main(string[] args)
    {
        Power power = new Power();

        // initialise variables for use in while loops that
        // ensure user enters correct input
        int number = 0, pwr = -1;
        bool validInteger = false; // if user enters invalid integer value
        bool validPower = false; // if user enters invalid power value

        int result;
        
        // while user doesn't enter valid / integer value make them re-enter input
        while (number < 1 || !validInteger)
        {
            System.Console.Write("Enter a whole to number: ");
            try
            {
                number = int.Parse(System.Console.ReadLine());
                validInteger = true;
            }
            catch
            {
                System.Console.WriteLine("Enter a valid integer!");
                validInteger = false;
            }
        }

        // run this loop until user enters a power in the correct range
        while (pwr < 0 || !validPower)
        {
                try
                {
                    System.Console.Write("Enter a power (>=0) to raise the number to: ");
                    pwr = int.Parse(System.Console.ReadLine());
                    validPower = true;
                }
                catch
                {
                    System.Console.WriteLine("You entered an invalid power!");
                    validPower = false;
                }
        }

        // calculate result using power objects method 'raisePower'
        result = power.raisePower(number, pwr);
        System.Console.WriteLine("The result is " + result);
    }
}