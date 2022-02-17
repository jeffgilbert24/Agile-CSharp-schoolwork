using System;
using static System.Console;
using static System.Convert;

namespace W3multiplyloopnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // prompt user for number
            int numb1;
            WriteLine("What number will I use?:");
            numb1 = Convert.ToInt16(ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                WriteLine(i * numb1);
                ReadKey();
            }
        }
    }
} 
