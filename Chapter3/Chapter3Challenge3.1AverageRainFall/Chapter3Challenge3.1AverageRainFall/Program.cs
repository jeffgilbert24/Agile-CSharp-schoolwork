// This program is take inches of rainfall per month for year and average
using System;
using System.Linq;

namespace Chapter3Challenge3._1AverageRainFall
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaires an array that can hold 12 int months
            int[] month = new int[12];
            // using a loop to prompt user for input, one month at a time
            for(int count = 0; count<month.Length; count++)
            {
                Console.WriteLine("Enter months rainfall:");
                month[count] = int.Parse(Console.ReadLine());
            }
            // Displays the statistics
            Console.WriteLine("Average:  {0}", month.Average());
            Console.WriteLine("Highest:  {0}", month.Max());
            Console.WriteLine("Lowest:   {0}", month.Min());
            Console.ReadKey();
        }
    }
}
