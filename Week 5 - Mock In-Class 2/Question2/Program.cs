using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new project that asks the user for their name.
            // Then, display a menu to the user that should look like this:
            // A) Hello
            // B)	Goodbye
            // Let the user type in “hello” or “goodbye” to select an option (use a switch). 
            // If they select “hello”, display “hello username”. If they select “goodbye”, display “goodbye username”. 
            // If they don’t choose a menu option correctly, make sure to inform them.

            string username, input;

            Console.WriteLine("Please enter your name: ");
            username = Console.ReadLine();

            Console.WriteLine("Please choose from: \nA) Hello\nB) Goodbye");
            input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "hello":
                    Console.WriteLine("Hello {0}!", username);
                    break;
                case "goodbye":
                    Console.WriteLine("Goodbye {0}!", username);
                    break;
                default:
                    Console.WriteLine("Invalid option chosen.");
                    break;
            }
        }
    }
}
