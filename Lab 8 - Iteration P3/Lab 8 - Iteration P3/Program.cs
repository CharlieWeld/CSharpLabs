using System;

class Asterisks
{
    private static int numberAsterisks = 5;

    public static void Main(string[] args)
    {   
        
        for (int i = 0; i< Asterisks.numberAsterisks; i++)
        {
            for (int k = 0; k <= i; k++)
                Console.Write('*');
            Console.WriteLine();
        }
        
    }

}