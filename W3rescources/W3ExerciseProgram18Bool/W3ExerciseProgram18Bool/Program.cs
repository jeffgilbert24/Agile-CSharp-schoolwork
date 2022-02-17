// this program will ask for two numbers and if one is - and the other + print true.
using System;
using static System.Console;
using static System.Convert;

namespace W3ExerciseProgram18Bool
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb1, numb2;
            WriteLine("Enter a positive or negative number:");
            numb1 = Convert.ToInt32(ReadLine());
            WriteLine("Enter a second positive or negative number:");
            numb2 = Convert.ToInt32(ReadLine());
            if   
               ( (numb1 <= 0 && numb2 >= 0) || (numb1 >= 0 && numb2 <= 0))
                Console.WriteLine(true);
            Console.ReadKey();
            
        }
    }
}
