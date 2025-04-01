using System
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cylinder Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello! This is a test program for calculating the volume of a cylinder");
            Console.Write("Please enter the radius:");
            string RadiusAsString = System.Console.ReadLine();
            double radius = Convert.ToDouble(RadiusAsString);

            Console.Write("Please enter the height:");
            string HeightAsString = System.Console.ReadLine();
            double height = Convert.ToDouble(HeightAsString);

            double pi = 3.141592654

            double volume = pi * radius * radius * height;
            double surfaceArea = 2 * pi * radius * (radius + height);

            System.Console.WriteLine($"The cylinders volume is: {volume} cubic units" );
            System.Console.WriteLine($"The cylinders surface area is: {surfaceArea} square units");

            Console.ReadKey();
        }
    }
}
