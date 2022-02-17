/* This program will find the absolute value of 2 numbers, if the 1st is 
larger than the second, then return double the sum. Else just sum
*/
using System;
using static System.Console;
using static System.Convert;

namespace ComputeAbsoluteValue
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(result(13, 40));
            WriteLine(result(50, 21));
            WriteLine(result(0, 23));
            ReadKey();
        }

        public static int result(int a, int b)
        {      
            if (a > b)
            {
                return (a - b)*2;
            }
            return b - a;
       
        }

    }
}
