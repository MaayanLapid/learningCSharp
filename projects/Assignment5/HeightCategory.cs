using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5HeightCategory
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double height_in_inch = 196;
            double inchToCentimeter = 2.54;
            double height_in_centimeter = height_in_inch * inchToCentimeter;

            if (height_in_centimeter < 150)
            {
                Console.WriteLine("Dwarf");
            }
            else if ((height_in_centimeter >= 150) && (height_in_centimeter <= 165))
            {
                Console.WriteLine("Average height");
            }
            else if ((height_in_centimeter >= 166) && (height_in_centimeter <= 195))
            {
                Console.WriteLine("Tall");
            }
            else
            {
                Console.WriteLine("Abnormal height");
            }
            
            Console.ReadKey();
        }

        //Write a program to find out "category of height" based on the given height of a person(in inches), using "if".
        //Height categories:

        //Height is less than 150 cm = "Dwarf"
        //Height is between 150 cm and 165 cm = "Average height"
        //Height is between 165 cm and 195 cm = "Tall"
        //Height is above 195 cm = "Abnormal height"

        //Note: 1 inch = 2.54 centimeter
        //You need to convert the input value(inches) into centimeters.

        //Eg:
        //Input: 75
        //Output: Tall
    }
}
