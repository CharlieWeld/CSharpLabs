using System;

namespace Rainfall
{
    class RainfallRecorder
    {
        public int NoDays { get; set; }
        public double[] RainfallArray { get; set; }
        public double TotalRainfall { get; set; }
        public double AverageRainfall { get; set; }
        public double RainfallLimit { get; set; }

        public RainfallRecorder()
        {
            NoDays = 7;
            RainfallLimit = 3.5;
            TotalRainfall = 0;
            AverageRainfall = 0;
        }

        public double calcTotalRainfall()
        {
            for (int i=0; i< NoDays; i++)
            {
                TotalRainfall += RainfallArray[i];
            }
            return TotalRainfall;
        }

        public double calcAverageRainfall()
        {
            foreach (var day in RainfallArray)
            {
                AverageRainfall += day;
            }

            AverageRainfall /= 7;
            return AverageRainfall;
        }

        public bool overLimit()
        {
            foreach (var item in RainfallArray)
            {
                if (item > RainfallLimit)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
