// This program is display the sum and difference of two intergers
using System;

namespace Chapter4SumandDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create three int variables
            int a = 17;
            int b = 5;
            int difference;
            // calls the addition() method and stores the return value in sum
            int sum = addition(a, b, out difference);
            // display the results
            Console.WriteLine("{0} added to {1} is {2} the difference is {3}", a, b, sum, difference);
            Console.ReadKey();
        }
        // Addition method
        static int addition(int x, int y, out int r)
        {
            int q;
            q = x + y;
            r = x - y;
            return q;
        }
    }
}
