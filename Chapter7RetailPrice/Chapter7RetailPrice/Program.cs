// This program deminstrates the exception method. enter the word for a number
// instead of the number i.e. "ten" vice "10".
using System;
using static System.Console;
using static System.Convert;

namespace Chapter7RetailPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Promt user for wholesale price and markup percentage
            WriteLine("Enter Wholesale Price:");
            double wholeSalePrice = double.Parse(ReadLine());
            WriteLine("Enter Markup Percentage:");
            double markupPercentage = double.Parse(ReadLine());
            // calculate retail price
            double retailPrice = wholeSalePrice * (1 + markupPercentage / 100);
            // display result
            WriteLine($"Retail Price: {retailPrice:C}");
            ReadKey();
        }
    }
}
