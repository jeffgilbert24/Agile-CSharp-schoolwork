using System;
using static System.Console;
using static System.Convert;

namespace Ch06Ex04CommandLineArgue
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine($"{args.Length} command line arguments were specified:");
            foreach (string arg in args)
                WriteLine(arg);
            ReadKey();
        }
    }
}
