using System;


namespace Rainfalls
{
    // This class contains the business logic for the Rainfall program
    // Its data member is a 2D array implemented using C# Properties

    public class Rainfall
    {
        public double[,] RainfallFigures {get; set; }

        // By default The RainfallFigures array is i
        public Rainfall()
        {
            int SIZE = 3;
            RainfallFigures = new double[SIZE, SIZE];

            // Initialise all values to zero
            // This will prevent errors if the get method
            // is called on an uninitialised array
            for(int i=0; i< SIZE; i++)
            {
                for (int j=0; j< SIZE; j++)
                {
                    RainfallFigures[i, j] = 0;
                }
            }
        }

        public Rainfall(double[,] rainfallFigures)
        {
            // set the RainfallFigures array to the values of the array passed
            this.RainfallFigures = rainfallFigures;
        }

        public double[] calcAvgRainfall()
        {
            // get the number of regions to average
            double[] avgArray = new double[RainfallFigures.GetLength(1)];
            double total = 0;
            
            for(int i=0; i<RainfallFigures.GetLength(0); i++)
            {
                for (int j=0; j<RainfallFigures.GetLength(1); j++)
                {
                    total += RainfallFigures[i, j];
                }
                avgArray[i] = total / RainfallFigures.GetLength(0);
            }
            
            return avgArray;
        }

    }
}