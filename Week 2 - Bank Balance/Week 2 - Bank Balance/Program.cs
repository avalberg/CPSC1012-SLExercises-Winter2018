using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2___Bank_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Our Plan
            // 1) Welcome statement
            // 2) Declare variables: decimal accountBalance, int itemCost, decimal gst, string itemName
            // 3) Prompt user for current balance and store it in accountBalance
            // 4) Prompt user for item name & store it in itemName
            // 5) Prompt user for item cost & store it in itemCost (are you noticing a pattern...)
            // 6) Display item name, item cost, GST, and new account balance to the user.
            
            // declaring my variables!
            decimal balance;
            int transactionItem;
            string transactionName;

            // getting the user's balance
            Console.Write("Hi there! What's your current balance? ");
            balance = decimal.Parse(Console.ReadLine());

            // getting the user's transaction
            Console.Write("What are you buying? ");
            transactionName = Console.ReadLine();
            Console.Write("How much does it cost (without GST)? ");
            transactionItem = int.Parse(Console.ReadLine());

            // do the math
            balance -= transactionItem * 1.05m;

            // tell the user their balance
            Console.Write("After your purchase of {0} at {1:C} with {2:C} GST, your new account balance is {3:C}.",transactionName,transactionItem,transactionItem * 0.05,balance);
            Console.WriteLine();
        }
    }
}
