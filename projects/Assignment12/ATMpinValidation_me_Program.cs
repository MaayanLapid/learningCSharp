using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Assignment12ATMpinValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DebitCard debitCard = new DebitCard();
            debitCard.PinNum = "a4";
            Console.WriteLine(debitCard.PinNum);
            Console.ReadKey();
        }
        /*
         Create a C# program with a class called DebitCard with a property called "Pin" with validations in the set accessor.

        The Pin should be exactly 4 digits or 6 digits.

        If the supplied pin is invalid, it shows error message.


        Examples:

        Pin = "1234"     -->  valid

        Pin = "1234ef"     -->  invalid

        Pin = "123456"     -->  valid

        Pin = "0"     -->  invalid

        Pin = "a4"     -->  invalid
         */
    }
}
