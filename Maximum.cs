using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    internal class Maximum
    {
        public static int MaximumInteger(int Num1, int Num2, int Num3)
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
        public static float Maximumfloat(float Num4, float Num5, float Num6)
        {
            if (Num4.CompareTo(Num5) > 0 && Num4.CompareTo(Num6) > 0 ||
                    Num4.CompareTo(Num5) >= 0 && Num4.CompareTo(Num6) > 0 ||
                     Num4.CompareTo(Num5) > 0 && Num4.CompareTo(Num6) >= 0)
            {
                return Num4;
            }
            if (Num5.CompareTo(Num4) > 0 && Num5.CompareTo(Num6) > 0 ||
                    Num5.CompareTo(Num4) >= 0 && Num5.CompareTo(Num6) > 0 ||
                     Num5.CompareTo(Num4) > 0 && Num5.CompareTo(Num6) >= 0)
            {
                return Num5;
            }
            if (Num6.CompareTo(Num4) > 0 && Num6.CompareTo(Num5) > 0 ||
                   Num6.CompareTo(Num4) >= 0 && Num6.CompareTo(Num5) > 0 ||
                    Num6.CompareTo(Num4) > 0 && Num6.CompareTo(Num5) >= 0)
            {
                return Num6;
            }
            throw new Exception("Num4,Num5 and Num6 are same");

        }
        public static string Maximumstring(string Num7, string Num8, string Num9)
        {
            if (Num7.CompareTo(Num8) > 0 && Num7.CompareTo(Num9) > 0 ||
                    Num7.CompareTo(Num8) >= 0 && Num7.CompareTo(Num9) > 0 ||
                     Num7.CompareTo(Num8) > 0 && Num7.CompareTo(Num9) >= 0)
            {
                return Num7;
            }
            if (Num8.CompareTo(Num7) > 0 && Num8.CompareTo(Num9) > 0 ||
                    Num8.CompareTo(Num7) >= 0 && Num8.CompareTo(Num9) > 0 ||
                     Num8.CompareTo(Num7) > 0 && Num8.CompareTo(Num9) >= 0)
            {
                return Num8;
            }
            if (Num9.CompareTo(Num7) > 0 && Num9.CompareTo(Num8) > 0 ||
                   Num9.CompareTo(Num7) >= 0 && Num9.CompareTo(Num8) > 0 ||
                    Num9.CompareTo(Num7) > 0 && Num9.CompareTo(Num8) >= 0)
            {
                return Num9;
            }
            throw new Exception("Num4,Num5 and Num6 are same");

        }
    }
}