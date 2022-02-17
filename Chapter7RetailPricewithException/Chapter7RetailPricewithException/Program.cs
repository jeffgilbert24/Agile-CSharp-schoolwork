using System;
using static System.Console;
using static System.Convert;


namespace Chapter7RetailPricewithException
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declair variables to hold user valuReadKey();
            double wholeSalePrice;
            double markupPercentage;
            // Prompt user for wholesale price and markup percentage
            WriteLine("Enter wholesale price:");
            if(! (double.TryParse(ReadLine(), out wholeSalePrice)))
            {
                WriteLine("Whilesale price must be numeric");
            }
            else
                if(double wholeSalePrice < 0.0)
                {
                WriteLine("Enter positive number only");
            }
            else
            {
                WriteLine("Enter markup percentage:");
                if(!(double.TryParse(ReadLine(), out markupPercentage)))
                {
                    WriteLine("Marup must be numeric");
                }
                else
                {
                    // data are good
                    // calculate retail price
                    double retailPrice = wholeSalePrice * (1 + markupPercentage / 100);
                    // display results
                    WriteLine($"Retail Price: {retailPrice:C}");
                }
            }
            ReadKey();
        }
        
    }
}

