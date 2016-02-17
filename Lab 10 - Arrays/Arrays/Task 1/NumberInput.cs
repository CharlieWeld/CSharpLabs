using System;

namespace NumInput
{
public static class NumberInput
{
        public static int[] getArray()
        {
            int[] tempArr = new int[5];

            for(int i=0; i<5; i++)
            {
                Console.Write("Enter input " + (i+1) + ": ");
                tempArr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return tempArr;
        }

    

}

}