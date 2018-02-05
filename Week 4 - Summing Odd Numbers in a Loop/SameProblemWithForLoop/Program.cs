using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SameProblemWithForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // This program takes a number from the user, and displays & sums all the odd numbers up to it.
            // This project uses a for loop instead of a while loop.

            int input, sum = 0;

            Console.Write("What number do you want to count up to? ");
            input = int.Parse(Console.ReadLine());

            if (input > 1)
            {
                Console.WriteLine("\nThe odd numbers up to {0} are: ", input);
                for (int counter = 1; counter <= input; counter += 2)
                {
                    Console.Write("{0} ", counter);
                    sum += counter;
                }
                Console.WriteLine("\n\nThe sum of all the odd numbers up to {0} is {1}.\n", input, sum);
            }
            else
                Console.WriteLine("We can't do much with that number, sorry!");
        }
    }
}