using System;
using Reverse;
using NumInput;
using PrintNum;

class Program
{
    public static void Main(string[] args)
    {
        ReverseNumber r1 = new ReverseNumber();

        r1.Numbers = new int[5];

        r1.Numbers = NumberInput.getArray();
       
        int sum = r1.sumNumbers();
        
        int[] temp = new int[5];

        temp = r1.reverseNumbers();

        PrintNumber.printArray(temp);
       
    }
}