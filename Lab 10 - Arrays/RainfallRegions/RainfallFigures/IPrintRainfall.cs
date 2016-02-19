using System;

// This interface is used by all printing classes
// such as printing to Console, GUI, Website, etc
// They must implement these methods

interface IPrintRainfall
{
    void printText(String text);
    void printRainfall(double[,] rainfallArray);
    void printAvgRainfall(double[] avgRainfallArray);
}