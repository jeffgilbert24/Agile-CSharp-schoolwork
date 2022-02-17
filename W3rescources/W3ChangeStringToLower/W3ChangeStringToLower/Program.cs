// This program will change a string to lowercase
using System;
using static System.Console;
using static System.Convert;

namespace W3ChangeStringToLower
{
    class Program
    {
        static void Main(string[] args)
        {
            string l;
            WriteLine("Enter alphebet in upper case:");
            l = Convert.ToString(ReadLine());
            WriteLine(l.ToLower());
            ReadKey();
        }
    }
}
