using System;

namespace CylinderCalculator
{
    class CylinderInformation
    {
        static void Main(string[] args)
        {
            const double pi = 3.1415926;
            //Print a greeting message
            Console.WriteLine("Cylinder Calculator\n");

            Console.WriteLine("Enter a number for height");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a number for radius");
            int radius = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            double volume = pi * radius * radius * height;
            double surface = 2 * pi * radius * (radius + height);
            Console.WriteLine("\nThe volume of the cylinder is" + " " + volume);
            Console.WriteLine("\nThe surface of the cylinder is" + " " + surface);
            Console.ReadKey();
        }

    }
}
