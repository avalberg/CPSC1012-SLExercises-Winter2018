using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a program that takes a number from the user and checks if it's perfect.

            int userInput, sum = 0;

            Console.WriteLine("Enter a whole number: ");
            userInput = int.Parse(Console.ReadLine());

            Console.Write("The positive divisors of {0} are: ", userInput);
            for (int i = 1;i <= (userInput / 2); i++)
            {
                if (userInput % i == 0)
                {
                    sum += i;
                    Console.Write("{0} ",i);
                }
            }

            Console.WriteLine("\nThe sum of these divisors is {0}.", sum);
            if (sum == userInput)
            {
                Console.WriteLine("{0} is perfect!",userInput);
            }
            else
            {
                Console.WriteLine("{0} is not perfect. But it's still pretty good!",userInput);
            }
            Console.WriteLine();
        }
    }
}
