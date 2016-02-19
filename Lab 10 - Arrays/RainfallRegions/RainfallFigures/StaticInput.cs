
using System;

public class StaticInput : IRainfallInput
{
    public double[,] getRainfall(int x, int y)
    {
        double[,] tempArr = new double[x, y];

        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                tempArr[i, j] = i + j;
            }
        }

        return tempArr;
    }

    public int[] getRegions()
    {
        // return an array of 3 regions and 3 months 
        // This is the applications default value
        return new int[] { 3, 3 };
    }
}