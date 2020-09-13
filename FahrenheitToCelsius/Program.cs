using System;
using static System.Console;

namespace FahrenheitToCelsius
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit;
            double Celsius;

            WriteLine("Exercise 3");
            WriteLine("Enter Fahreneheit degress >>");

            fahrenheit = double.Parse(ReadLine());
            Celsius = (fahrenheit - 32) * 5/9;

            WriteLine("{0} Fahrenheit is {1} Celsius", fahrenheit.ToString("0.0"), Celsius.ToString("0.0"));

        }
    }
}
