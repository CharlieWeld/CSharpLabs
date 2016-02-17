using System;

namespace PrintNum
{
    public static class PrintNumber
    {
        public static void printArray(int[] tempArr)
        {
            for (int i=0; i<tempArr.Length; i++)
            {
                Console.WriteLine("Number " + (i+1) + " is " + tempArr[i]);
            }
        }
    }
}