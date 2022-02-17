// This program will ask the user where did they graduate from and display it
using System;

namespace Chapter4Challenge4._1Dispaly_school
{
    class Program
    {        
        static void Main(string[] args)
        {
            // Display text  and ask the user for input
            Console.WriteLine("Where did you graduate from?");
            string school = Console.ReadLine();
            DisplayText(school);
            Console.ReadKey();
        }
        // Display method
        static void DisplayText(string message)
        {
            
            Console.WriteLine();
            Console.WriteLine(message + "is a great school");
            Console.WriteLine();
        }
        
    }
}
