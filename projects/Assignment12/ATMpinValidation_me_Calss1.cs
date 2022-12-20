using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class DebitCard
    {
        //instance field
        private string _pinNum;

        //instance property
        public string PinNum
        {
            get { return _pinNum; }
            set
            {
                    _pinNum = value;
                if (_pinNum.Length == 4 || _pinNum.Length == 6)
                {
                    bool b = int.TryParse(value, out int n);
                        if (b == true)
                    {
                        Console.WriteLine("okay");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                }
                else
                {
                    Console.WriteLine("the pin is not 4 or 6");
                }
            }
        }

        //constructor
        //public DebitCard(string pinNum)
        //{
        //    this._pinNum = pinNum;
        //}
    }
}
