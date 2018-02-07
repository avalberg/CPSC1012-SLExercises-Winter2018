using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new project that takes a radius and height from the user.
            // Let the user decide if their input / output is in centimeters (cm) or in inches (in).
            // Calculate the volume of a cylinder based on these values.
            // Display the total volume to the user (with the appropriate unit of measurement).
            // Formula for volume is V = π * r * r * h

            double radius, height, volume;
            string input;

            Console.WriteLine("Enter a radius: ");
            radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter a height: ");
            height = double.Parse(Console.ReadLine());

            Console.WriteLine("Is your input in cm or in?");
            input = Console.ReadLine();

            volume = Math.PI * Math.Pow(radius, 2) * height;

            if (input.ToLower() == "cm")
            {
                Console.WriteLine("Volume is {0}cm.", volume);
            }
            else
            {
                Console.WriteLine("Volume is {0}in.", volume);
            }
        }
    }
}
