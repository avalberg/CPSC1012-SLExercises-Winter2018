using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3_Mock_In_Class_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // The answer for Question 1

            double area, height, baseVariable;

            Console.WriteLine("Please enter the height in cm: ");
            height = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the base in cm: ");
            baseVariable = double.Parse(Console.ReadLine());

            area = 0.5 * height * baseVariable;

            Console.WriteLine("A triangle with a base of {0}cm and a height of {1}cm has an area of {2}cm.",baseVariable,height,area);
        }
    }
}
