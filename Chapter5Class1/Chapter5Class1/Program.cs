using System;

namespace Chapter5Class1
{
    class Program
    {
        static void Main(string[] args)
        {
            // create two students
            Student student1 = new Student("Alice", 97);
            Student student2 = new Student("Bob", 87);
            // display the data
            Console.WriteLine(student1);
            Console.WriteLine(student2);
            Console.ReadKey();
        }
    }
}
