using System;
using RomanNumeralConsoleApp.Models;

namespace RomanNumeralConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var romanNumber = "IV";
            var result = SuperInteger.ConvertToDecimal(romanNumber);

            Console.WriteLine($"The equivalent roman number to decimal is: {result}");
        }
    }
}
