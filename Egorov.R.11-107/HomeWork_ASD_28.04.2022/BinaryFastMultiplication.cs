using System;

namespace Egorov.R._11_107.HomeWork_ASD_28._04._2022
{
    public class BinaryFastMultiplication
    {
        public uint Calc(uint number1, uint number2)
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
            uint a = number1 / Convert.ToUInt32(Math.Pow(2, half));
            uint b = Convert.ToUInt32(number1 % Math.Pow(2, half)); 
            uint c = number2 / Convert.ToUInt32(Math.Pow(2, half)); 
            uint d = Convert.ToUInt32(number2 % Math.Pow(2, half)); 
            uint ac = 0; 
            uint bd = 0; 
            uint ad = 0; 
            if (a / 2 != 0 || c / 2 != 0) 
            { 
                ac = Calc(a, c);
            }
            if (b / 2 != 0 || d / 2 != 0)
            { 
                bd = Calc(b, d);
            }
            if ((a + b) / 2 != 0 || (c + d) / 2 != 0)
            { 
                ad = Calc(a + b, c + d);
            }
            if (ac == 0) 
                ac = a * c;
            if (bd == 0)
                bd = b * d;
            if (ad == 0) 
                ad = (a + b) * (c + d);
            return Convert.ToUInt32(ac * Math.Pow(2, maxl) + (ad - ac - bd) * Math.Pow(2, half) + bd);
        }
        private int NumberLength(uint number)
        { 
            return Convert.ToString(number, toBase: 2).Length;
        } 
    }
}