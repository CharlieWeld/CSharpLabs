using System;

class App
{
    public static void Main(string[] args)
    {
        int selection = 0;
        double length, height, radius, volume;
        Volume vol = new Volume();
        

        while (selection != 4)
        {
            selection = 0;
            while (selection < 1 || selection > 4)
            {
                Console.WriteLine("1. Cube Volume\n2. Cylinder Volume\n3. Sphere Volume\n4. Exit");
                Console.Write("Select from the menu: ");
                // Need to add exception handling here
                try
                {
                    selection = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Select a valid option!");
                    selection = 0;
                }
            }
            Console.WriteLine();

            switch (selection)
            {
                case 1:
                    Console.Write("Enter the length of a cube side: ");
                    length = Convert.ToDouble(Console.ReadLine());
                    volume = vol.cubeVolume(length);
                    Console.WriteLine("The volume of the Cube is {0:0.00}", volume);
                    break;
                case 2:
                    Console.Write("Enter the radius of the cylinder: ");
                    radius = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the height of the cylinder: ");
                    height = Convert.ToDouble(Console.ReadLine());
                    volume = vol.cylinderVolume(height, radius);
                    Console.WriteLine("The volume of the cylinder is {0:0.00}", volume);
                    break;
                case 3:
                    Console.Write("Enter the radius of the sphere: ");
                    radius = Convert.ToDouble(Console.ReadLine());
                    volume = vol.sphereVolume(radius);
                    Console.WriteLine("The volume of the sphere is {0:0.00}", volume);
                    break;
                default:
                    break;

            }
            Console.WriteLine();
        }
        
    }
}
