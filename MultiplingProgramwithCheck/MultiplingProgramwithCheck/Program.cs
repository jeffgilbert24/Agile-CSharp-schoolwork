// This program will multiply two numbers ask for an answer and check the answer
using System;

namespace MultiplingProgramwithCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompts the user for input
            Console.WriteLine("What is the first number?");
            int FirstNumber = int.Parse( Console.ReadLine());
            //Prompt the user for the second number
            Console.WriteLine("What is the second number?");
            int SecondNumber = int.Parse (Console.ReadLine());
            //Multiply the two numbers
            int answer = FirstNumber * SecondNumber;
            //Ask user for answer
            Console.WriteLine("What do you think the answer is?");
            int results = int.Parse(Console.ReadLine());
            if (answer == results) {
                Console.WriteLine("You are correct");
            }
            else
            {
                Console.WriteLine("That is incorrect, try again");
            }
            Console.ReadKey();
        }
    }
}
