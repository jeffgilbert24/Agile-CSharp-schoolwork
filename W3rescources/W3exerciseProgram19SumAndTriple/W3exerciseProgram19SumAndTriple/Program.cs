// This program will take the sum of two equal numbers and triple the sum
using System;
using static System.Console;
using static System.Convert;

namespace W3exerciseProgram19SumAndTriple
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb1, numb2;
            WriteLine("Enter a number:");
            numb1 = Convert.ToInt32(ReadLine());
            WriteLine("Enter the second number:");
            numb2 = Convert.ToInt32(ReadLine());
            if (numb1 % numb2 == 0)
            {
                WriteLine($"The sum of{numb1} and {numb2} is {numb1 + numb2}");
                WriteLine();
                WriteLine($"Triple the sum is {(numb1 + numb2) * 3 }");
                ReadKey();
            }
        }
    }
}
