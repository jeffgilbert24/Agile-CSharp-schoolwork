// this program will take two numbers and use + - * / give results

using System;
using static System.Convert;
using static System.Console;

namespace W3multipleoutcomes2numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt the user for input
            int numb1, numb2;
            WriteLine("What is the first number:");
            numb1 = Convert.ToInt16(ReadLine());
            WriteLine("What is the second number:");
            numb2 = Convert.ToInt16(ReadLine());
            // output results
            
            WriteLine($"The sum of {numb1} and {numb2} is " +
                $"{numb1 + numb2}.");
            WriteLine($"The sum after subtraction is:{numb1 - numb2}.");            
            WriteLine($"The result after division is:{numb1 / numb2}.");
            WriteLine($"The remainder after division is:{numb1 % numb2}.");
            ReadKey();
        }
    }
}
