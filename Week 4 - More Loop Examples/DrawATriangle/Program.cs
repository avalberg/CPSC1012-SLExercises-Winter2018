using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawATriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput;
            Console.Write("Display the pattern like right angle using asterisk:\n");
            Console.Write("------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input number of rows : ");
            userInput = int.Parse((Console.ReadLine()));
            for (int rows = 1; rows <= userInput; rows++)
            {
                for (int stars = 1; stars <= rows; stars++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
