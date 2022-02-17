// this progam uses a string to make the first and last letters switch position
using System;
using System.Collections.Generic;
using static System.Console;
using static System.Convert;

namespace W3BasicExercise16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(first_last("w3resource"));
            Console.WriteLine(first_last("Python"));
            Console.WriteLine(first_last("x"));
            Console.ReadKey();

        }
        public static string first_last(string ustr)
        {
            return ustr.Length > 1
                ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1) : ustr;

        }

    }
}
