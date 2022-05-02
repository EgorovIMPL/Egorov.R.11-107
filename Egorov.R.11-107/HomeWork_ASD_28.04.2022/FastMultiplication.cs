using System;
using System.Runtime.Serialization.Formatters.Binary;

namespace Egorov.R._11_107.HomeWork_ASD_28._04._2022
{
    public class FastMultiplication
    {
        public int Calc(int number1, int number2)
        {
            int l1 = NumberLength(number1);
            int l2 = NumberLength(number2);
            int maxl = Math.Max(l1, l2);
            int half = maxl / 2;
            if (maxl % 2 == 1)
            {
                half += 1;
                maxl += 1;
            }
            int a = number1 / Convert.ToInt32(Math.Pow(10, half));
            int b = Convert.ToInt32(number1 % Math.Pow(10, half));
            int c = number2 / Convert.ToInt32(Math.Pow(10, half));
            int d = Convert.ToInt32(number2 % Math.Pow(10, half));
            int ac = 0;
            int bd = 0;
            int ad = 0;
            if (a / 10 != 0 || c / 10 != 0)
            {
                ac = Calc(a, c);
            }
            if (b / 10 != 0 || d / 10 != 0)
            {
                bd = Calc(b,d);
            }
            if ((a + b) / 10 != 0 || (c + d) / 10 != 0)
            {
                ad = Calc(a + b, c + d);
            }
            if (ac == 0)
                ac = a * c;
            if (bd == 0)
                bd = b * d;
            if (ad == 0)
                ad = (a + b) * (c+d);
            return Convert.ToInt32(ac * Math.Pow(10, maxl) + (ad - ac - bd) * Math.Pow(10, half) + bd);
        }
        private int NumberLength(int number)
        {
            return Convert.ToString(number).Length;
        }
    }
}