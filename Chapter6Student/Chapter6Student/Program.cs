// This program tracks grad and undergrad students with different grade styles
using System;
using System.Collections.Generic;

namespace Chapter6Student
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> allStudents = new List<Student>();
            Undergraduate ud1 = new Undergraduate("111", "Alice", 98);
            allStudents.Add(ud1);
            Undergraduate ud2 = new Undergraduate("222", "Bob", 88);
            allStudents.Add(ud2);
            Graduate g1 = new Graduate("333", "Chuck", 76);
            allStudents.Add(g1);
            Graduate g2 = new Graduate("444", "Dan", 56);
            allStudents.Add(g2);
            foreach(Student s in allStudents)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();

                
        }
    }
}
