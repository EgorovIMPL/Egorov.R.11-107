using System;
using System.Reflection;
using Egorov.R._11_107.HomeWork_ASD_21._04._2022;
using Egorov.R._11_107.HomeWork_ASD_28._04._2022;
using Egorov.R._11_107.HomeWork_INF_04._04._2022;
using Egorov.R._11_107.HomeWork_INF_18._04._2022;
using Egorov.R._11_107.HomeWork_INF_25._04._2022;

namespace Egorov.R._11_107
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryFastMultiplication fm = new BinaryFastMultiplication();
            uint f = 0b_1001_0110;
            uint t = 0b_1001_0110;
            Console.WriteLine(Convert.ToString(f * t, toBase: 2));
            Console.WriteLine(Convert.ToString(fm.Calc(f,t), toBase: 2));
        }
    }
}