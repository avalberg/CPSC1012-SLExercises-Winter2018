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
            // declaring my variables
            string province, slogan;
            
            // asking user for input
            Console.Write("Enter a province: ");
            province = Console.ReadLine();

            // switch to determine province!
            switch (province.ToLower())
            {
                case "alberta":
                    slogan = "Wild Rose Country";
                    break;
                case "british columbia":
                    slogan = "Beautiful British Columbia";
                    break;
                case "manitoba":
                    slogan = "Friendly";
                    break;
                case "new brunswick":
                    slogan = "Picture Province";
                    break;
                case "newfoundland and labrador":
                    slogan = "A World of Difference";
                    break;
                case "nova scotia":
                    slogan = "Canada's Ocean Playground";
                    break;
                case "ontario":
                    slogan = "Yours To Discover";
                    break;
                case "prince edward island":
                    slogan = "Canada's Green Province";
                    break;
                case "quebec":
                    slogan = "Je me souviens";
                    break;
                case "saskatchewan":
                    slogan = "Land of Living Skies";
                    break;
                default:
                    slogan = "";
                    break;
            }

            // bonus - a decision to figure out if the province they provided was actually found
            if (slogan == "")
            {
                Console.WriteLine("Sorry, we found no province matching {0}!\n", province);
            }
            else
            {
                Console.WriteLine("{0}'s provincial slogan is {1}.\n", province, slogan);
            }
        }
    }
}
