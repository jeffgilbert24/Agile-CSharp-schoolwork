// This program will find the longest word in a string
using System;
using static System.Console;
using static System.Convert;

namespace W3Exercise24StringLonestWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "Write a C# Sharp Program to display the following pattern using the alphabet.";
            string[] words = line.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            int ctr = 0;
            foreach (String s in words)
            {
                if (s.Length > ctr)
                {
                    word = s;
                    ctr = s.Length;
                }
            }

            WriteLine(word);
            ReadKey();

        }
    }
}
