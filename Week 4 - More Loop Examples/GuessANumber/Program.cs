using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int answer, userInput;

            answer = rnd.Next(0, 10);

            Console.Write("\nGuess a number between 1 and 10!   ");
            userInput = int.Parse(Console.ReadLine());

            while (userInput != answer)
            {
                Console.WriteLine("\nNope! Try again.   ");
                userInput = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"\nYou got it! The answer was {answer}.\n");
        }
    }
}
