using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            string continueYN = "N";

            do
            {
                int height, width;
                char symbol;

                Console.WriteLine("Choose your symbol: ");
                while (!char.TryParse(Console.ReadLine(), out symbol))
                    Console.WriteLine("Invalid symbol. Try again: ");

                Console.WriteLine("Choose a height: ");
                while (!int.TryParse(Console.ReadLine(), out height) || height <= 0)
                    Console.WriteLine("Invalid integer. Try again: ");

                Console.WriteLine("Choose a width: ");
                while (!int.TryParse(Console.ReadLine(), out width) || height <= 0)
                    Console.WriteLine("Invalid integer. Try again: ");

                Console.WriteLine();

                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        if ((i > 0 && i != height - 1) && (j != 0 && j != width - 1))
                            Console.Write(" ");
                        else
                            Console.Write("{0}", symbol);
                    }
                    Console.WriteLine();
                }
                Console.Write("\nThat's a cool rectangle! Want to play again? Enter N to Quit or any other key to continue: ");
                continueYN = Console.ReadLine().ToUpper();
            } while (continueYN != "N");
            Console.WriteLine("\nBye!\n");
        }
    }
}
