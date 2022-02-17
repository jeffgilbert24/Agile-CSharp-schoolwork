using System;
using static System.Console;
using static System.Convert;

namespace Ch05Ex05ArrayPratice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] citiesNames = { "Walla Walla", "Lubbock", "Del Sole", null, "" };
            foreach (var citiesName in citiesNames)
            {
                switch (citiesName)
                {
                    case string l when l.StartsWith("L"):
                        WriteLine("This city name starts with a'L': " +
                            $"{citiesName} and is {l.Length - 1} letters long");
                        break;
                    case null:
                        WriteLine("There is a 'null' value in the array");
                        break;
                    case string e when e.Length == 0:
                        WriteLine("There is a string in the array with no value");
                        break;
                    case var x:
                        WriteLine("This is the var patteren of type: " +
                            $"{x.GetType().Name}");
                        break;
                    default:
                        break;
                }
            }
            int sum = 0, total = 0, counter = 0, intValue = 0;
            int?[] myIntArray = new int?[7] { 5, intValue, 9, 10, null, 2, 99 };
            foreach(var integer in myIntArray)
            {
                switch(integer)
                {
                    case 0:
                        WriteLine($"integer number '{total}' has a default value of 0");
                        counter++;
                        break;
                    case int value:
                        sum += value;
                        WriteLine($"integer number '{total}' has a value of{value}");
                        counter++;
                        break;
                    case null:
                        WriteLine($"integer number '{total}' is null");
                        counter++;
                        break;
                    default:
                        break;
                }
            }
            WriteLine($"{total} total integers, {counter} integers with a" +
                $"value other than 0 or null have a sum value of {sum}");
            ReadLine();

        }
    }
}
