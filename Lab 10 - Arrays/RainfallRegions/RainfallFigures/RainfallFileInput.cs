using System;
using System.IO;

class RainfallFileInput : IRainfallInput
{
    public double[,] getRainfall(int x, int y)
    {
        //double[,] rainfallArray = new double[3, 3];
        double[,] rainfallArray = new double[x, y];

        // Write random output to the file "rainfall.txt"

        double[] temp = new double[1000];
        for (int i = 0; i<1000; i++)
            {
            temp[i] = i * 3.142 * 7;
        }

        // Use the StreamWriter class to write text to a file
        using (StreamWriter strWriter = new StreamWriter("rainfall.txt"))
        {

            foreach (var item in temp)
            {
                strWriter.WriteLine(item);
            }

        }
        
        // Read a text stream from a file ("rainfall.txt")
        // Each line contains a double
        // the array 'rainfallArray' will read as many values as specified by x and y (x*y)
        using (StreamReader strReader = new StreamReader("rainfall.txt"))
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    rainfallArray[i, j] = Double.Parse(strReader.ReadLine());
                }
            }
        }

            return rainfallArray;
    }

    // Read in from a binary file the number of regions and months to sample
    public int[] getRegions()
    {
        int[] var = new int[2];
        FileStream F = new FileStream("test.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);

        var[0] = F.ReadByte();
        var[1] = F.ReadByte();
        
        return var;
    }
}