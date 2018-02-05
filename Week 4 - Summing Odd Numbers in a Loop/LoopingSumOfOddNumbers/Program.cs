using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingSumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // This program takes a number from the user, and displays & sums all the odd numbers up to it.
            // In this project we're using a While loop - in the other project, there is a For loop.
            
            int input, sum = 0, counter = 1;

            Console.Write("What number do you want to count up to? ");
            input = int.Parse(Console.ReadLine());

            if (input > 1) 
            {
                Console.WriteLine("\nThe odd numbers up to {0} are: ", input);
                while (counter <= input)
                {
                    Console.Write("{0} ",counter);
                    sum += counter;
                    counter += 2;
                }
                Console.WriteLine("\n\nThe sum of all the odd numbers up to {0} is {1}.\n",input,sum);
            }
            else
                Console.WriteLine("We can't do much with that number, sorry!");
        }
    }
}