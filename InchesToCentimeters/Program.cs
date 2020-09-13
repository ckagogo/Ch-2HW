using System;

namespace InchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {

            //  Declare variable

            const Double Centimeter_In_Inches = 2.54;
            double inches = 3;
            double centimeter;
            string inchesAsString;

            // Calculations
            centimeter = inches * Centimeter_In_Inches;


            Console.WriteLine("Exercise 1");
            Console.WriteLine(inches + " inches is " + centimeter + " centimeter");

            Console.WriteLine();

            //***********************************************************

        }
    }
}





    



