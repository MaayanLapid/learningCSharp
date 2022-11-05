using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1AreaOfCircle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p = 3.14;
            int radius = 8;
            double areaOfCircule;

            areaOfCircule = p * radius * radius;
            Console.WriteLine(areaOfCircule);
            Console.ReadKey();

        }
        //Write a C# program to calculate "area of circle" based on the given "radius" value.

        //Instructions
        //The radius value can be assigned to a variable; need not to take the value from the keyboard input.

        //Formula: PI* radius * radius

        //PI is a constant value, approximately equal to 3.14159, which is equal to the ratio of the circumference of any circle to its diameter.

        //Questions for this assignment
        //Check your source code with Instructor's solution.
    }
}
