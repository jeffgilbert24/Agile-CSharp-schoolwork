// This program will ask for two numbers then multiply them
using System;

namespace Chapter4Challenge4._2MultiplyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user for two numbers that will be placed into an int
                   
            Console.WriteLine("What is the first whole number?");
            int numb01 = int.Parse( Console.ReadLine());
            Console.WriteLine("What is the second whole number?");
            int numb02 =  int.Parse(Console.ReadLine());
            Console.ReadKey();
        }   // Call the multiply method
        public static int Multiply(int numb01, int numb02)
        {
            Console.WriteLine(numb01 * numb02);
        }

    }
}
