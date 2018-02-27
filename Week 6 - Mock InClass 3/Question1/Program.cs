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
            // my variables
            int year;
            string animal;

            // letting user tell us their YOB
            Console.Write("What year were you born? ");
            year = int.Parse(Console.ReadLine());

            // my huge switch!
            switch ((year - 4) % 12 + 1)
            {
                case 1:
                    animal = "Rat";
                    break;
                case 2:
                    animal = "Ox";
                    break;
                case 3:
                    animal = "Tiger";
                    break;
                case 4:
                    animal = "Rabbit";
                    break;
                case 5:
                    animal = "Dragon";
                    break;
                case 6:
                    animal = "Snake";
                    break;
                case 7:
                    animal = "Horse";
                    break;
                case 8:
                    animal = "Goat";
                    break;
                case 9:
                    animal = "Monkey";
                    break;
                case 10:
                    animal = "Rooster";
                    break;
                case 11:
                    animal = "Dog";
                    break;
                case 12:
                    animal = "Pig";
                    break;
                default:
                    animal = "";
                    break;
            }

            // printing the user's year and telling them their animal
            Console.WriteLine("Since you were born in {0}, your Zodiac animal is a {1}!\n",year,animal);
        }
    }
}
