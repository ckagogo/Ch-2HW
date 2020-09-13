using System;
using static System.Console;

namespace InchesToCentimersInteractive
{
    class Program
    {
        static void Main(string[] args)
        {

            //  Declare variable

            const Double Centimeter_In_Inches = 2.54;
            double inches;
            double centimeter;
            string inchesAsString;


            WriteLine("Exercise 2");
            Console.WriteLine("Enter a value in Inches  >>");
            inchesAsString = Console.ReadLine();
            inches = Convert.ToDouble(inchesAsString);
            centimeter = inches * Centimeter_In_Inches;
            WriteLine("{0} inches is {1} centimeter", inchesAsString, centimeter);
        }
    }
}
