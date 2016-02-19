using System;

// Interface for getting input for the Rainfall program

public interface IRainfallInput
{
    // get a 2D array of average rainfall figures
    // the x value indicates the number of regions
    // the y value indicates the number of months
    double[,] getRainfall(int x, int y);

    // get the number of regions and months to test
    // this will return a 1D array with the first value the number of regions
    // and the second value the number of months
    int[] getRegions();
}

