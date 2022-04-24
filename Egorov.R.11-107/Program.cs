using System;
using Egorov.R._11_107.HomeWork_ASD_21._04._2022;
using Egorov.R._11_107.HomeWork_INF_04._04._2022;
using Egorov.R._11_107.HomeWork_INF_18._04._2022;

namespace Egorov.R._11_107
{
    class Program
    {
        static void Main(string[] args)
        {
            MaxNumber mx = new MaxNumber();
            Console.WriteLine(mx.Max(new[] {17, 4, 25, 29, 3, 111, 13, 60,36,12}));
        }
    }
}