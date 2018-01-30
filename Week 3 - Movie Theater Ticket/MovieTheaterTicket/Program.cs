using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheaterTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            // This program is for a very simple movie theatre.
            // You can buy one ticket (based on your age) and 1 snack.
            // The program then displays your purchase details and your total cost.

            // variable declaration & initialization
            decimal ticketPrice = 0, total = 0, snackPrice = 0;
            int age, tickets = 0, snacks = 0;
            char snackChoice;

            // title
            Console.WriteLine("Movie Theatre\n-------------");

            // asking user for their age and determining ticket price based on that
            Console.Write("\nHow old are you? ");

            // getting the user's age & storing it
            age = int.Parse(Console.ReadLine());

            
            if (age > 0 && age < 101) // checking if the age is between 1 and 100
            {
                if (age < 13) // child ticket
                {
                    Console.WriteLine("\nChild ticket - 8$.");
                    total += 8;
                    ticketPrice = 8;
                    tickets++;
                }
                else
                {
                    if (age >= 13 && age < 18) // youth ticket
                    {
                        Console.WriteLine("\nYouth ticket - 10$.");
                        total += 10;
                        ticketPrice = 10;
                        tickets++;
                    }
                    else // adult ticket
                    {
                        Console.WriteLine("\nAdult ticket - 12$.");
                        total += 12;
                        ticketPrice = 12;
                        tickets++;
                    }
                }

                // printing snack options for the user to see
                Console.WriteLine("\nSnack Options:");
                Console.WriteLine("A) Pretzels - 3$");
                Console.WriteLine("B) Twizzlers - 2$");
                Console.WriteLine("C) Skittles - 4$");
                Console.WriteLine("D) Popcorn - 3$");
                Console.WriteLine("E) No snack");
                Console.Write("Please select an option: ");

                // taking the user's menu option and storing it
                snackChoice = char.Parse(Console.ReadLine().ToUpper());

                switch (snackChoice) // taking user's menu input & doing stuff with it
                {
                    case 'A':
                        Console.WriteLine("\nPretzels added to your order (3$).");
                        total += 3;
                        snackPrice = 3;
                        snacks++;
                        break;
                    case 'B':
                        Console.WriteLine("\nTwizzlers added to your order (2$).");
                        total += 2;
                        snackPrice = 2;
                        snacks++;
                        break;
                    case 'C':
                        Console.WriteLine("\nSkittles added to your order (4$).");
                        total += 4;
                        snackPrice = 4;
                        snacks++;
                        break;
                    case 'D':
                        Console.WriteLine("\nPopcorn added to your order (3$).");
                        total += 3;
                        snackPrice = 3;
                        snacks++;
                        break;
                    case 'E':
                        Console.WriteLine("\nNo snack chosen.");
                        break;
                    default:
                        Console.WriteLine("\nInvalid choice. No snack for you!");
                        break;
                }
            }
            else // if the program gets here, the user didn't enter a valid age! no need to do anything else.
                Console.WriteLine("\nThat was not a valid age. No ticket purchased.");

            // 'print' the bill for the user
            Console.WriteLine("-------------------------");
            Console.WriteLine("{0,5}{1,13}{2,5}{3,10:C}",tickets,"ticket(s)","@",ticketPrice);
            if (snacks != 0) // only print the snack line if they purchased a snack
                Console.WriteLine("{0,5}{1,13}{2,5}{3,10:C}",snacks,"snack(s)","@",snackPrice);
            Console.WriteLine("{0,33}", "-----------------------------");
            Console.WriteLine("{0,18}{1,5}{2,10:C2}", "Subtotal", "=", total);
            Console.WriteLine("{0,18}{1,5}{2,10:C2}", "GST", "=", total * 0.05m);
            Console.WriteLine("{0,18}{1,5}{2,10:C2}\n", "Total", "=", total * 1.05m);
        }
    }
}
