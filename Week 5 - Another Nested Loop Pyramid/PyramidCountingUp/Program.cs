using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyramidCountingUp
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput, printValue = 1;

            Console.WriteLine("Counting Up Inside a Triangle!");
            Console.WriteLine("------------------------------\n");

            Console.Write("How many rows do you want? ");
            userInput = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for(int rows = 1; rows <= userInput; rows++)
            {
                for(int columns = 1; columns <= rows; columns++)
                {
                    Console.Write("{0} ", printValue++);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
