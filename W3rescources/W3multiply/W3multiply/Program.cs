using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3multiply
{
    class Program
    {
        static void Main(string[] args)
        {

            int numb1, numb2, numb3;
            Console.WriteLine("Enter the first number:");
            numb1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            numb2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number:");
            numb3 = Convert.ToInt32(Console.ReadLine());
            int results = numb1 * numb2 * numb3;
            Console.WriteLine("Output: {0} * {1} * {2} = {3}", numb1, numb2, numb3, results);

            System.Console.WriteLine("Write your code at here");
            Console.ReadKey();
        }
    }
    }

