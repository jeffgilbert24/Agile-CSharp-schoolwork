// this program will display a number with spaces and without
using System;
using static System.Console;
using static System.Convert;
    

namespace W3Basicexercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb;
            WriteLine("Enter the number:");
            numb = Convert.ToInt32(ReadLine());
            WriteLine();
            WriteLine($"{numb} {numb} {numb} {numb}");
            WriteLine($"{numb}{numb}{numb}{numb}");
            WriteLine($"{numb} {numb} {numb} {numb}");
            WriteLine($"{numb}{numb}{numb}{numb}");
            ReadKey();

        }
    }
}
