using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockInClass5
{
    class Program
    {
        static void Main(string[] args)
        {
            char exit = ' ';
            string firstName, lastName, status;
            DateTime dob;
            int menuChoice = 0;
            double hours = 0;
            GetEmployeeInfo(out firstName,out lastName,out dob,out hours);
            do
            {
                menuChoice = Menu();
                // switch to determine what to do based on user input
                switch (menuChoice)
                {
                    case 1:
                        double addedHours = UpdateHours(ref hours);
                        Console.WriteLine("{0} hours added to {1} {2}'s schedule. Current hours are now {3}.", addedHours, firstName, lastName, hours);
                        break;
                    case 2:
                        status = GetEmployeeStatus(hours);
                        Console.WriteLine("{0} {1} is a {2} employee with {3} hours.",firstName,lastName,status,hours);
                        break;
                    default:
                        Console.WriteLine("How did you get here?");
                        break;
                }
                Console.WriteLine("\nPress X to exit, or any other key to return to the menu.");
                while (!char.TryParse(Console.ReadLine(), out exit))
                    Console.WriteLine("Sorry, didn't catch that. Press X to exit.");
            } while (char.ToUpper(exit) != 'X');
        }

        public static void GetEmployeeInfo(out string firstname, out string lastname, out DateTime dob, out double hours)
        {
            // asking for the employee name, DOB & current hours
            Console.Write("Enter a first name: ");
            firstname = Console.ReadLine();
            Console.Write("Enter a last name: ");
            lastname = Console.ReadLine();
            Console.Write("Enter a DOB: ");
            while (!DateTime.TryParse(Console.ReadLine(), out dob))
                Console.Write("Incorrect date. Format is MM/DD/YYYY. Try again: ");
            Console.Write("Enter the employee's current hours: ");
            while (!double.TryParse(Console.ReadLine(), out hours) || hours <= 0)
                Console.Write("Incorrect hours. Try again: ");
        }

        public static int Menu()
        {
            // method variables
            int menuChoice;

            // showing the menu, then getting user input on menu choice
            Console.WriteLine("\nEmployee Management Menu\n------------------------\n1) Update employee's hours\n2) Get employee's status");
            Console.Write("Enter your choice: ");
            while (!int.TryParse(Console.ReadLine(), out menuChoice) || menuChoice != 1 && menuChoice != 2)
                Console.Write("Menu option must be a 1 or 2. Try again: ");
            return menuChoice;
        }

        public static double UpdateHours(ref double hours)
        {
            double addedHours;
            Console.Write("\nHow many hours have been added to the employee's schedule? ");
            while (!double.TryParse(Console.ReadLine(), out addedHours) || addedHours <= 0)
                Console.Write("Sorry, that's not a valid number of hours. Try again: ");
            hours += addedHours;
            return addedHours;
        }

        public static string GetEmployeeStatus(double hours)
        {
            string status;
            if (hours < 20)
                status = "Casual";
            else
            {
                if (hours < 37.5)
                    status = "Part Time";
                else
                    status = "Full Time";
            }
            return status;
        }
    }
}
