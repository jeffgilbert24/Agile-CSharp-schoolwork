using System;
using static System.Console;
using static System.Convert;

namespace Ch05Ex04_ArrayPratice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] citiesNames = { "Lubbock", "Elpaso", "WallaWalla" };
            int i;
            WriteLine($"Here are {citiesNames.Length} of my cities:");
            for (i = 0; i < citiesNames.Length; i++)
            {
                WriteLine(citiesNames[i]);
            }
            ReadKey();
        }
    }
}
