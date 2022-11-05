using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2FeetToCentimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inchToCm =2.54;
            double feetToInches = 12;

            double userFeet = 5;
            double userInches = 7;

            double feetToInchesUser;

            //conver feet to inches
            feetToInchesUser = (userFeet * feetToInches);

            //conver inches to centimeters
            double result = (feetToInchesUser * inchToCm) + (userInches * inchToCm);

            Console.WriteLine(result);
            Console.ReadKey();

        }
        //Write a C# program convert a person's height (in feet and inches) to centimeters.

        //Instructions
        //Eg:
        //feet = 5
        //inches = 7
        //output: 170.18 cm

        //Formula:
        //1 inch = 2.54 cm
        //1 feet = 12 inches

    }
}
