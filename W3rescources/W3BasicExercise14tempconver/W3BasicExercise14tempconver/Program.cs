// this program will convert celsius to K and F
using System;
using static System.Console;
using static System.Convert;

namespace W3BasicExercise14tempconver
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb; int kelv; int fahr;
            WriteLine("Enter a temperture:");
            numb = Convert.ToInt32(ReadLine());
            kelv = Convert.ToInt32(numb + 273.15); 
            fahr = Convert.ToInt32(1.8 * numb) + 32;
            WriteLine($"celsius to fahrenheit is {fahr}");
            WriteLine($"celsius to Kelvin is {kelv}");
            ReadKey();

        }
    }
}
