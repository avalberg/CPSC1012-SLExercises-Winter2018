using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USDtoCAD
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring our variables
            // I've made them double but Decimal is also fine!
            double usd, cad;

            // Writing messages to the user
            Console.WriteLine("Welcome to the USD to CAD Conversion Program");
            Console.Write("Please enter a US dollar value: ");

            // Taking user input & parsing it into a double
            // Both of these lines are assignment statements
            // That means something on the right (in this case, user input) is being stored in whatever is on the left (here, the usd variable)
            usd = double.Parse(Console.ReadLine());
            cad = usd * 1.24;

            // String concatenation
            Console.WriteLine("The CAD value of $" + usd + "USD");

            // String parameterization
            Console.WriteLine("is ${0} CAD", cad);

            // These are both just ways to combine strings with variables.
            Console.ReadLine();
        }
    }
}
