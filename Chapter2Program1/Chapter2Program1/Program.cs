using System;

namespace Chapter2Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            // promt user for a name
            Console.WriteLine("Enter your name");
            // store the value in a variable
            string name = Console.ReadLine();
            // display the message
            Console.WriteLine("Welcome to Agile, " + name);
            Console.ReadKey();
        }
    }
}
