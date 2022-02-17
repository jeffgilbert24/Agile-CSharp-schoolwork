// this program will average 4 numbers from user
using System;
using static System.Console;
using static System.Convert;

namespace W3avarageProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get input from the user
            int numb1, numb2, numb3, numb4;
            WriteLine("What is the first number?:");
            numb1 = Convert.ToInt16(ReadLine());
            WriteLine("What is the second number?:");
            numb2 = Convert.ToInt16(ReadLine());
            WriteLine("What is the third number?:");
            numb3 = Convert.ToInt16(ReadLine());
            WriteLine("What is the fourth number?:");
            numb4 = Convert.ToInt16(ReadLine());
            // add numbers together divide and output to user
            WriteLine($"The average is {(numb1 + numb2 + numb3 + numb4) / 4}");
            ReadKey();
        }        
    }    
}
