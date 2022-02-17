using System;

namespace ChangeCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompts the user for quantity
            Console.WriteLine("How much change do you have?");
            double ChangeAmount = Console.ReadLine();
            double workingAmount = ChangeAmount * 100;
            double quarters = workingAmount / 25;


        }
    }
}
