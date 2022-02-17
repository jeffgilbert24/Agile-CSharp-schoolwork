using System;
using static System.Console;
using static System.Convert;

namespace Ch05Ex06StatementAutoCompletion
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "This is a test.";
            char[] separator = {' ' };
            string[] myWords;
            myWords = myString.Split(separator);
            foreach (string word in myWords )
            {
                WriteLine($"{word}");
            }
            ReadKey();
        }
    }
}
