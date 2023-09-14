using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    internal class GenMax
    {

        public static T GenericsMax<T>(T Num1, T Num2, T Num3) where T : IComparable
       
        {
         if (Num1.CompareTo(Num2) > 0 && Num1.CompareTo(Num3) > 0 ||
                    Num1.CompareTo(Num2) >= 0 && Num1.CompareTo(Num3) > 0 ||
                     Num1.CompareTo(Num2) > 0 && Num1.CompareTo(Num3) >= 0)
            {
                return Num1;
            }
            if (Num2.CompareTo(Num1) > 0 && Num2.CompareTo(Num3) > 0 ||
                    Num2.CompareTo(Num1) >= 0 && Num2.CompareTo(Num3) > 0 ||
                     Num2.CompareTo(Num1) > 0 && Num2.CompareTo(Num3) >= 0)
            {
                return Num2;
            }
            if (Num3.CompareTo(Num1) > 0 && Num3.CompareTo(Num2) > 0 ||
                   Num3.CompareTo(Num1) >= 0 && Num3.CompareTo(Num2) > 0 ||
                    Num3.CompareTo(Num1) > 0 && Num3.CompareTo(Num2) >= 0)
            {
                return Num3;
            }
            throw new Exception("Num1,Num2 and Num3 are same");
        }

    }
}
