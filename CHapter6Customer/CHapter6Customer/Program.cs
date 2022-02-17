// This program has two types of customer, member and VIP
using System;
using System.Collections.Generic;

namespace CHapter6Customer
{
    class Program
    {
        static void Main(string[] args)
        {
            // creat a regular customer
            VIPCustomer c1 = new VIPCustomer("111", "Alice");
            c1.MakePurchase(500);
            Console.WriteLine(c1);
            c1.MakePurchase(1000);
            Console.WriteLine(c1);
            c1.MakePurchase(100);
            Console.WriteLine(c1);
            Console.WriteLine();
            MemberCustomer c2 = new MemberCustomer("222", "Bob");
            c2.MakePurchase(500);
            Console.WriteLine(c2);
            c2.MakePurchase(1000);
            Console.WriteLine(c2);
            Console.ReadKey();            
        }
    }
}
