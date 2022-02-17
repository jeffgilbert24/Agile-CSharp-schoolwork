// This program asks a user for thier age and prints
using System;


namespace W311ageComplamentProgram
{
    class Program
    {
        static void Main(string[] args)            
        {
            int age;
            Console.WriteLine("What is your age?;");
            age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("You look young for {0}:", age);
            Console.ReadKey();

            
        }
    }
}
