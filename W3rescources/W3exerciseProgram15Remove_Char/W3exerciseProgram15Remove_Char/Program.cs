// This program will remove a letter from a word at different points in a string.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3exerciseProgram15Remove_Char
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(remove_char("w3resource", 1));
            Console.WriteLine(remove_char("w3resource", 9));
            Console.WriteLine(remove_char("w3resource", 0));
            Console.ReadKey();
        }
        public static string remove_char(string str, int n)
        {
            return str.Remove(n, 1);
        }
    }
}

