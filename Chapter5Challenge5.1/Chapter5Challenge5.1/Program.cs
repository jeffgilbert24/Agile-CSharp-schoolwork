// This program will calculate a students 2 midterms and final grades and return the semester grade
using System;

namespace Chapter5Challenge5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask user for student's name and grades
            Console.WriteLine("Enter students name:");
            string studentName = Console.ReadLine();
            Console.WriteLine("Enter midterm1 grade:");
            int Term1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter midterm2 grade:");
            int Term2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter finalExam grade:");
            int final = int.Parse(Console.ReadLine());
            // display student
            CollegeStudent stud1 = new CollegeStudent(studentName, Term1, Term2, final);
            // Results
            Console.WriteLine(stud1);
            Console.ReadKey();


            


        }
    }
}
