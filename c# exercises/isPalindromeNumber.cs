using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 353;
            int num = x;
            int lastDigit = 0;
            int reverseNum = 0;

            while (x > 0)
            {
                lastDigit = x % 10;
                reverseNum = reverseNum * 10 + lastDigit;
                x = x / 10;
            }
            Console.WriteLine("the num: " + num);
            Console.WriteLine("revers num is: " + reverseNum);

            if (reverseNum == num)
            {
                Console.WriteLine("the num is palindrome");
            }
            else
            {
                Console.WriteLine("the num is not palindrome");
            }

            Console.ReadKey();
        }
        // Given an integer x, return true if x is a  palindrome, and false otherwise.
        // 121, 131, 222 is a palindrome integer
    }
}
