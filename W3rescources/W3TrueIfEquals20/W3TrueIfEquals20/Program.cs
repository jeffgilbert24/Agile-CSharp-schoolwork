// This program will evaluate two numbers as 20
using System;
using static System.Console;
using static System.Convert;

namespace W3TrueIfEquals20
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb1, numb2;
            WriteLine("Enter the first number:");
            numb1 = Convert.ToInt32(ReadLine());
            WriteLine("Enter the second number:");
            numb2 = Convert.ToInt32(ReadLine());
            WriteLine(numb1 == 20 || numb2 == 20 || (numb1 + numb2 == 20));
            ReadKey();
        }
    }
}
