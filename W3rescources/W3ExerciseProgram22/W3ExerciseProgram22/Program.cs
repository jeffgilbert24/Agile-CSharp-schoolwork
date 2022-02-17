using System;
using static System.Console;
using static System.Convert;

namespace W3ExerciseProgram22
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb;
            WriteLine("Enter a number:");
            numb = Convert.ToInt32(ReadLine());
            WriteLine(result(numb));
            ReadKey();
        
        }
            public static bool result(int n)
        {
                if ((n - 100) <= 10 || (n - 200) <= 10)
                    return true;
                return false;

        }
    }
}
