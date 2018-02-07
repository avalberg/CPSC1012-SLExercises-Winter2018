using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new project that asks the user their age so that they can buy a movie ticket.
            // If they’re under 12, their ticket is “Child” and costs 8$.
            // If they’re 13 - 17, their ticket is “Youth” and costs 10$.
            // If they’re 18 - 64, their ticket is “Adult” and costs 12$.
            // If they’re 65 or over, their ticket is “Senior” and costs 10$.
            // If they enter an invalid age (outside 1 - 100), inform the user.
            // Based on the age they provide, display the following information(formatted in columns as shown below, spacing doesn’t have to match):
            //    1      Youth ticket(s)    @      $10.00
            //                              GST:   $0.50
            //                              Total: $10.50
            //    Thanks for shopping at MOVIES R US!

            int age;
            string ticketType;
            decimal ticket;

            Console.Write("How old are you? ");
            age = int.Parse(Console.ReadLine());

            if (age > 0 && age < 101) // checking that their age is between 1 and 100
            {
                if (age >= 65) // are they 65 or over?
                {
                    ticketType = "Senior";
                    ticket = 10;
                }
                else
                {
                    if (age >= 18) // since we know they're not over 65, are they over 18?
                    {
                        ticketType = "Adult";
                        ticket = 12;
                    }
                    else
                    {
                        if (age >= 13) // we know they're not over 18, are they over 13?
                        {
                            ticketType = "Youth";
                            ticket = 10;
                        }
                        else // if all other options failed, we know they're 12 or under.
                        {
                            ticketType = "Child";
                            ticket = 8;
                        }
                    }
                }

                // printing the 'bill' to the user
                // I'm doing this here because then it only prints if their original input was valid :)

                Console.WriteLine("\n{0,5}{1,10}{2,10}{3,5}{4,10:C}", 1, ticketType, "ticket(s)", "@", ticket);
                Console.WriteLine("{0,30}{1,10:C}","GST:",ticket * 0.05m);
                Console.WriteLine("{0,30}{1,10:C}","Total:",ticket * 1.05m);
                Console.WriteLine("Thanks for shopping at MOVIES R US!");
            }
            else // if age is not valid
            {
                Console.WriteLine("That's not a valid age, sorry.");
            }
        }
    }
}
