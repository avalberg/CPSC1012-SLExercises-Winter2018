using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingNumbersFromString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt user for input
            Console.Write("Enter a 4 digit number: ");

            //Just for fun - this way doesn't use any math!
            string userInput = Console.ReadLine();
            int sum = int.Parse(userInput.Substring(0, 1));
            sum += int.Parse(userInput.Substring(1, 1));
            sum += int.Parse(userInput.Substring(2, 1));
            sum += int.Parse(userInput.Substring(3, 1));

            //This is the way we were shown in class (using div & modulus)
            //int userInput = int.Parse(Console.ReadLine());
            //int sum;
            //sum = userInput % 10;
            //sum = sum + userInput % 100 / 10;
            //sum = sum + userInput % 1000 / 100;
            //sum = sum + userInput / 1000;

            //Showing the user the sum of their input
            Console.WriteLine("The sum of your numbers is: " + sum + ".");
        }
    }
}
