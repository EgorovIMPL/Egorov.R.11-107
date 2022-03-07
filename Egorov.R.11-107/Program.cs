using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Egorov.R._11_107.ClassWork;
using Egorov.R._11_107.ControlWork_15._12;
using Egorov.R._11_107.HomeWork_22._12._2021;
using Egorov.R._11_107.HomeWork_8._12._2021;
using Egorov.R._11_107.HomeWork_AISD_17._02._2022;
using Egorov.R._11_107.HomeWork_ASD_24._02._2022;
using Egorov.R._11_107.HomeWork_INF_07._03._2022;
using Egorov.R._11_107.HomeWork_INF_21._02._2022;

namespace Egorov.R._11_107
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomArrayCollection<int> array = new CustomArrayCollection<int>(new int[] {1, 5, 2, 5, 6});
            array.RemoveAll(5);
            Console.WriteLine(array.ToString());
        }
        public static void Print(Couple[] array)
        {
            foreach (var el in array)
                Console.WriteLine(el.Key + " " + el.Value);
        }
    }
}