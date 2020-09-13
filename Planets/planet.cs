using System;
using static System.Console;

namespace Planets
{
    partial class Program
    {
        public enum Planet
        {

            Mercury = 1, Venus, Earth, Mars,
            Juputer, Saturn, Uranus, Neptune
        }



        static void Main(string[] args)
        {

            WriteLine("Exercise 4");
            WriteLine("Enter a number to see a planet in that position >>");

            Planet inputNum = (Planet)int.Parse(ReadLine());

            WriteLine("{0} is {1}", (int)inputNum, inputNum);

        }

    }
}