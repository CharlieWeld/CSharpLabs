using System;

namespace Reverse
{
class ReverseNumber
    {
        
        public ReverseNumber()
        {
            // Set array index 0 to 0
            Numbers = new int[5] { 0, 0, 0, 0, 0 };
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
            int[] tempArr = new int[5];
            Numbers.CopyTo(tempArr,0);
            
            int temp;

            int SIZE = Numbers.Length;
            
           for (int i=SIZE-1; i>-1; i--)
            {
                
                /*temp = tempArr[i];
                tempArr[i] = tempArr[SIZE - i - 1];
                tempArr[SIZE - i - 1] = temp;*/
                
                tempArr[SIZE - 1 - i] = Numbers[i];
            }
            return tempArr;
        }
    }
}