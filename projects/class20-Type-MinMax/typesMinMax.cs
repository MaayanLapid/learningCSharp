using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
           sbyte a = sbyte.MinValue;
           sbyte b = sbyte.MaxValue;
            byte c = byte.MinValue;
            byte d = byte.MaxValue;
            short s = short.MinValue;
            short t = short.MaxValue;
            ushort us = ushort.MinValue;
            ushort v = ushort.MaxValue;
            int i = int.MinValue;
            int j = int.MaxValue;
            uint un = uint.MaxValue;
            ulong ul = ulong.MinValue;
            long l = long.MinValue;
            long ll = long.MaxValue;
            float f = float.MinValue;
            float g = float.MaxValue;
            double dd = double.MinValue;
            double dd2 = double.MaxValue;
            decimal dec = decimal.MinValue;
            decimal dec2 = decimal.MaxValue;
            // Char doesn't have a min/max value
            char ch = char.MinValue;
            char ch2 = char.MaxValue;
            // Bool doesn't have a min/max value
            //bool bb = bool.MinValue;




            Console.WriteLine("sbyte: "+ a);
            Console.WriteLine("sbyte: " + b);
            Console.WriteLine("byte: " + c);
            Console.WriteLine("byte: " + d);
            Console.WriteLine("short: " + s);
            Console.WriteLine("short: " + t);
            Console.WriteLine("uhort: " + us);
            Console.WriteLine("ushort: " + v);
            Console.WriteLine("int: " + i);
            Console.WriteLine("int: " + j);
            Console.WriteLine("uint:" + un);
            Console.WriteLine("uint:" + ul);
            Console.WriteLine("long:" + l);
            Console.WriteLine("long: " + ll);
            Console.WriteLine("float: " + f);
            Console.WriteLine("float: " + g);
            Console.WriteLine("double: " + dd);
            Console.WriteLine("double: " + dd2);
            Console.WriteLine("decimal: " + dec);
            Console.WriteLine("decimal: " + dec2);
            Console.WriteLine("char: " + ch);
            Console.WriteLine("char: " + ch2);

            Console.ReadKey();
        }
    }
}
