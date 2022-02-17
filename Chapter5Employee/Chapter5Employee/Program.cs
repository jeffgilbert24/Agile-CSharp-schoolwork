// This program will display the employee's ID name and promotion date
using System;

namespace Chapter5Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            // create two employees
            Employee employee1 = new Employee("111", "Alice",
                DateTime.Parse("11/11/2015"));
            // You should change the following date to a more recent
            // date so that Bob won't see the promotion message
            Employee employee2 = new Employee("222", "Bob",
                DateTime.Parse("9/4/2016"));
            // Display the message
            Console.WriteLine(employee1);
            Console.WriteLine(employee2);
            Console.ReadKey();
        }
    }
}
