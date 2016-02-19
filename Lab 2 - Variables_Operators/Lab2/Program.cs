using System;

class TempConverter
{
    double fahrenheitToCelscius(double fahrenheit)
    {
        double celcius;
        celcius = ((double)5 / 9) * (fahrenheit - 32);

        return celcius;
    }
}

class GrassCut
{
    double yardLength, yardWidth, houseLength, houseWidth;
    double yardArea, houseArea;
    double cuttingRate;

    GrassCut(double ylength, double ywidth, double hlength, double hwidth, double crate)
    {
        yardLength = ylength;
        yardWidth = ywidth;
        houseLength = hlength;
        houseWidth = hwidth;
        cuttingRate = crate;

        yardArea = yardLength * yardWidth;
        houseArea = houseLength * houseWidth;
    }

    double computeCuttingTime()
    {
        return (yardArea - houseArea) / cuttingRate;
    }

}


// Lab 2 Task 3 - Sum, Difference & Product of two floats
// Inputs - x, y
// Outputs - sum, difference & product
// Steps: 1 - assign two doubles x & y
// 2 - Calculate the sum of the two floats
// 3 - Calculate the differene of the two floats
// 4 - Calculate the product of the floats
// 5 - Display the outputs

class Floats
{
    double x, y;

    double calculateSum()
    {
        return x + y;
    }
    double calculateDifference()
    {
        // get absolute values of variables
        x = Math.Abs(x);
        y = Math.Abs(y);
        return Math.Abs((x - y));
    }
    double calculateProduct()
    {
        return (x * y);
    }

    static void Main(string[] args)
    {
        /*
        TempConverter tempconvert = new TempConverter();
        double fahrenheit = 35;
        double celcius = tempconvert.fahrenheitToCelscius(fahrenheit);
        Console.WriteLine("The temperature in celcius is " + celcius);
        */
        /*
        GrassCut cut1 = new GrassCut(10, 10, 4, 4, 2);
        double time = cut1.computeCuttingTime();
        Console.WriteLine("The time taken to cut the grass is " + time + " seconds");
        */
        double sum, diff, product;
        Floats floatObj = new Floats();

        Console.Write("Enter two floating point values.\nValue 1: ");
        floatObj.x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Value 2: ");
        floatObj.y = Convert.ToDouble(Console.ReadLine());

        sum = floatObj.calculateSum();
        diff = floatObj.calculateDifference();
        product = floatObj.calculateProduct();

        Console.WriteLine("The sum is " + sum + "\nThe difference is " + diff + "\nThe prodcut is " + product);
    }
}

