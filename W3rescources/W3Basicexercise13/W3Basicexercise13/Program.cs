using System;
using static System.Console;
using static System.Convert;

namespace W3Basicexercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb;
            WriteLine("Enter a number:");
            numb = Convert.ToInt32(ReadLine());
            WriteLine();
            WriteLine($"{numb}{numb}{numb}");
            WriteLine($"{numb} {numb}");
            WriteLine($"{numb} {numb}");
            WriteLine($"{numb} {numb}");
            WriteLine($"{numb}{numb}{numb}");

            ReadKey();
        }
    }
}
