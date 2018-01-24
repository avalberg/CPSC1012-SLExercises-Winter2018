using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // The answer for Question 2

            // I did 3 parameters per line, so each line = one row from the table.
            Console.WriteLine("{0,-20}{1,-20}{2,-20}","Shape","Formula","Cost");
            Console.WriteLine("{0,-20}{1,-20}{2,-20:C}", "Triangle", "½ah", 0.4);
            // \xB2 is how you show a 'superscript' or a tiny number next to something in the console.
            // in this example, it means "squared" because it's a 2.
            // if you wrote \xB3 it would show a tiny 3 instead!
            Console.WriteLine("{0,-20}{1,-20}{2,-20:C}", "Circle", "πr\xB2", 0.5);
            Console.WriteLine("{0,-20}{1,-20}{2,-20:C}", "Cylinder Volume", "πr\xB2h", 0.6);
        }
    }
}
