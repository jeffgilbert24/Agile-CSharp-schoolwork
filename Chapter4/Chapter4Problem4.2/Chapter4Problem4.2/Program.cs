// From chapter 4 , example 4.2 pg.80
using System;


namespace Chapter4Problem4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayText();
            Console.ReadKey();
        }
        // DisplayText method
        static void DisplayText()
        {
            Console.WriteLine();
            Console.WriteLine("C# is Fun.");
            Console.WriteLine();
            Console.WriteLine("*************************");
            Console.ReadKey();
        }
    }
}
