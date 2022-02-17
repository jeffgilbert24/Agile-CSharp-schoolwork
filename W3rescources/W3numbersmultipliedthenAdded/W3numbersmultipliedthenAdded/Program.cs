// this program takes 3 numbers multiply in differt order then adds
using System;
using static System.Console;
using static System.Convert;


namespace W3numbersmultipliedthenAdded
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask user for inputs
            int numb1, numb2, numb3;
            WriteLine("What is the first number?:");
            numb1 = Convert.ToInt16(ReadLine());
            WriteLine("What is the second number?:");
            numb2 = Convert.ToInt16(ReadLine());
            WriteLine("What is the third number?:");
            numb3 = Convert.ToInt16(ReadLine());            
            WriteLine($"Results of specified numbers{numb1}, {numb2} and {numb3}  is");
            WriteLine(value: $"({numb1} + {numb2})*{numb3} is: {(numb1 + numb2) * numb3}");
            WriteLine();
            WriteLine($"also {numb1}*{numb2}+{numb2}*{numb3} equals");
            WriteLine($"{numb1 * numb2 + numb2 * numb3}");
            ReadKey();
        }
    }
}
