using System;
using static System.Console;
using static System.Convert;

namespace Chapter7RetailPrice3
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare variables to hold user values
            double WholeSalePrice;
            double markupPercentage;
            // prompt user for wholesale price and markup percentage
            WriteLine("Enter wholesale price;");
            while(!(double.TryParse(ReadLine(), out WholeSalePrice))
                || (WholeSalePrice < 0))
            {
                WriteLine("Wholesale price must be numeric and positive.");
            }
            // wholesale price is valid
            WriteLine("Enter markup percentage.");
            while(!(double.TryParse(ReadLine(), out markupPercentage))
                || markupPercentage < 0)
            {
                WriteLine("Markup must be numeric and positive.");
            }
            // markup percentage is valid
            //calculate retail price
            double retailPrice = WholeSalePrice * (1 + markupPercentage / 100);
            // display result
            WriteLine($"Retail Price:{retailPrice:C}");
            ReadKey();
        }
    }
}
