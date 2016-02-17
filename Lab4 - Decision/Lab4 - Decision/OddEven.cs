// Lab 4 - Decision
// Task 1 - Odd or Even
// Input: Integer
// Output: Message to user
// Process: 1. get input from user
// 2. divide the number by 2
// 3. check if the remainder is 0 or 1
// 4. if 0 then the number is even
// 5. if 1 then the number is odd
// 6. display the appropriate message to the user
// Input Data: 0, 1, 2, 99
// Output: Even, Odd, Even, Odd

class OddEven
{
    public bool determineOddOrEven(int number)
    {
        bool evenFlag = true;

        if (number % 2 == 1)
        {
            evenFlag = false;
        }

        return evenFlag;
    }

    public static void Main(string[] args)
    {
        int number;
        System.Console.Write("Enter a number to determine if it is odd or even: ");
        number = int.Parse(System.Console.ReadLine());

        OddEven oeObj = new OddEven();

        if (oeObj.determineOddOrEven(number))
        {
            System.Console.WriteLine("The number is even");
        }
        else
        {
            System.Console.WriteLine("The number is ODD!");
        }
    }
}
