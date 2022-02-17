using System;

namespace Chapter2Program3a
{
    class Program
    {
        static void Main(string[] args)
        {
            // This program counts coin change from us currency
            Console.WriteLine("Enter the amoun of money in US dollars and cents");
            //Prompt the user for input
            double currencyAmount = Console.ReadLine(double int());
            double x = currencyAmount * 100;
            int quarters = x / 25;
            double QuartersChange = x % 25;
            Console.WriteLine();


        }
    }
}