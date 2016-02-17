using System;

namespace ReverseNumber
{
class ReverseNumber
    {
        
        public ReverseNumber()
        {
            // Set array index 0 to 0
            Numbers.SetValue(0, 0);
        }

        public int[] Numbers { get; set; }

        public int sumNumbers()
        {
            int sum = 0;

            for (int i=0; i<Numbers.Length; i++)
            {
                sum += Numbers[i];
            }

            return sum;
        }

        public int[] reverseNumbers()
        {
            int[] tempArr = Numbers;
            int temp;
            int SIZE = Numbers.Length;

            for (int i=0; i<SIZE; i++)
            {
                temp = Numbers[i];
                tempArr[i] = tempArr[SIZE - i - 1];
                tempArr[SIZE - i - 1] = temp;
            }
            return tempArr;
        }
    }
}