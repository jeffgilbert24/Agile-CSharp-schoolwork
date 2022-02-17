using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Convert;
using static System.Console;

namespace Ch05Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            short shortResult, shortVal = 4;
            int integerVal = 67;
            long longResult;
            float floatVal = 10.5F;
            double doubleResults, doubleVal = 99.999;
            string stringResults, stringVal = "17";
            bool boolVal = true;
            WriteLine("Variable conversion examples \n");
            doubleResults = floatVal * shortVal;
            WriteLine($"Implicet, -> double: {floatVal} * {shortVal} -> {doubleResults}");
            shortResult = (short)floatVal;
            WriteLine($"Explicit, -> short: {floatVal}  -> { shortResult}");
            stringResults = Convert.ToString(boolVal) +
                Convert.ToString(doubleVal);
            WriteLine($"Explicit, -> string: \"{boolVal}\" + \"{doubleVal}\" ->" +
                $"{stringResults}");
            longResult = integerVal + ToInt64(stringVal);
            WriteLine($"Mixed, -> long: {integerVal} + {stringVal} -> {longResult}");
            ReadKey();
        }
    }
}
