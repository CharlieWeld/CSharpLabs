using System;

namespace Shapes
{
    class Rectangle
    {
        private double length;
        private double width;

        public Rectangle() : this(0, 0) { }

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double CalcPerimter()
        {
            return (2 * length + 2 * width);
        }

        public double CalcArea()
        {
            return (length * width);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(3, 5);
            Rectangle r2 = new Rectangle(900, 1000);

            double r1Perimeter = r1.CalcPerimter();
            double r2Perimeter = r2.CalcPerimter();

            if (r1Perimeter == r2Perimeter)
            {
                Console.WriteLine("both rectangles have the same perimeter!");
                Console.WriteLine("Both rectangles have an area of " + String.Format("{0:0.00}", r1.CalcArea()));
            }
            else if (r1Perimeter > r2Perimeter)
            {
                Console.WriteLine("Rectangle 1 has a larger perimeter");
                Console.WriteLine("Its area is " + String.Format("{0:0.00}", r1.CalcArea()));
            }
            else
            {
                Console.WriteLine("Rectangle 2 has a larger perimeter");
                Console.WriteLine(String.Format("Its area is {0}", r2.CalcArea()));
            }

            // 2. Rectangles in an array
            Rectangle r3 = new Rectangle(3, 4);
            Rectangle r4 = new Rectangle(5, 66);
            Rectangle r5 = new Rectangle(33.1, 4.456);
            Rectangle r6 = new Rectangle(13, 9.4);

            Rectangle[] rArray = new Rectangle[4];
            rArray[0] = r3;
            rArray[1] = r4;
            rArray[2] = r5;
            rArray[3] = r6;

            foreach (Rectangle r in rArray)
            {
                Console.WriteLine(String.Format("The perimeter of the rectangle is {0:0.00} metres", r.CalcPerimter()));
                Console.WriteLine(String.Format("The area of the rectangle is {0:0.00} metres squared\n", r.CalcArea()));
            }
        }


    }
}