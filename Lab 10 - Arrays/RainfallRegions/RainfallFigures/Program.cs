using System;
using Rainfalls;


class Program
{
    static void Main(string[] args)
    {
        // define local varables
        int noRegions, noMonths;
        int[] temp;

        // create rainfall object
        Rainfall rainfall = new Rainfall();

        // create input object
        IRainfallInput input = new RainfallFileInput();

        // create output object
        IPrintRainfall output = new PrintRainfallConsole();

        // Start message for User
        output.printText("Welcome to the Rainfall Program :)");

        // 1. get number of regions / months to sample
        temp = input.getRegions();
        
        noRegions = temp[0];
        noMonths = temp[1];

        // 2. get the rainfall data from the input device
        rainfall.RainfallFigures = input.getRainfall(noRegions, noMonths);

        // 3. output the rainfall figures for each month
        output.printRainfall(rainfall.RainfallFigures);

        // 4. output the average rainfall figures for each region
        output.printAvgRainfall(rainfall.calcAvgRainfall());
    }
}

