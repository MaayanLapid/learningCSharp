using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7PatternPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 2 3 4 7 8 9 10
            //1 2 3 4 7 8 9 10
            //1 2 3 4 7 8 9 10
            for (int i = 0; i < 3; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (j == 5 || j == 6)
                    {
                        continue;
                    }
                    Console.Write(" " + j);
                }
                Console.WriteLine();
            }

            //10 9 8 7 6 5 4 3 2 1
            //10 9 8 7 6 5 4 3 2 1
            //10 9 8 7 6 5 4 3
            //10 9 8 7 6 5 4 3 2 1

            for (int i = 0; i < 5; i++)
            {
                for (int j = 10; j > 0; j--)
                {
                    if (i == 3)
                    {
                        if (j < 3)
                        {
                            continue;
                        }
                    }
                    Console.Write(" " + j);
                }
                Console.WriteLine();
            }

            //1 2 3 4 5 6 7 9 10
            for (int i = 1; i < 11; i++)
            {
                if (i == 8)
                {
                    continue;
                }
                Console.Write(" " + i);
            }

            Console.ReadKey();
        }
        //Write a C# program to print the following output:

        //1 2 3 4 7 8 9 10
        //1 2 3 4 7 8 9 10
        //1 2 3 4 7 8 9 10
        //10 9 8 7 6 5 4 3 2 1
        //10 9 8 7 6 5 4 3 2 1
        //10 9 8 7 6 5 4 3
        //10 9 8 7 6 5 4 3 2 1
        //1 2 3 4 5 6 7 9 10

        //Each number should be printed by using the loop variable.
        //Don't print full line at-a-time as string.

        //For example, don't write statements as:
        //System.Console.WriteLine("1 2 3 4 7 8 9 10");

        //Use for loop, break and continue statements to bring the output.
    }
}
