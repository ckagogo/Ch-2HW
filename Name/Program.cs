using System;
using static System.Console;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            string name;
            string firstString, secondSting;
            int first, second, product;
            Write("Enter your name >> );
      
            name = ReadLine;
            Write("Hello, {0}! Enter an integer >> ", name);
            firstString = ReadLine();
            first = ConvertToInt32(firstString);
            Write("Enter another integer >> ");
            secondString = Readline();
            second = Convert.ToInt(secondString);
            product = first * second;
            WriteLine("Thank you, {1}. The product of {2} and {3} is {4}",
           name, first, second, product);*/


            string name;
            string firstString, secondString;
            int first, second, product;

            WriteLine("Exercise 5");
            Write("Enter your name >>");

            name = Console.ReadLine();
            Write("Hello, {0}! Enter an integer >> ", name);
            firstString = Console.ReadLine();
            first = Convert.ToInt32(firstString);
            Write("Enter another integer >> ");
            secondString = Console.ReadLine();
            second = Convert.ToInt32(secondString);
            product = first * second;
            WriteLine("Thank you, {0}. The product of {1} and {2} is {3}",
           name, first, second, product);

        }

        }
    }

