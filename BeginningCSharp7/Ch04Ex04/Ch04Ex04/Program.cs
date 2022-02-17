﻿// do loops
using System;
using static System.Console;
using static System.Convert;

namespace Ch04Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance, intersetRate, targetBalance;
            WriteLine("What is your current balance?");
            balance = ToDouble(ReadLine());
            WriteLine("What is your current annual interest rate(in %)?");
            intersetRate = 1 + ToDouble(ReadLine()) / 100.0;
            WriteLine("What balance would you like to have?");
            targetBalance = ToDouble(ReadLine());
            int totalYears = 0;
            do
            {
                balance *= intersetRate;
                ++totalYears;
            }
            while (balance < targetBalance);
            WriteLine($"In {totalYears} year{(totalYears == 1 ? "" : "s")}" +
                $"you'll have a balance of {balance}.");
            ReadKey();
        }
    }
}
