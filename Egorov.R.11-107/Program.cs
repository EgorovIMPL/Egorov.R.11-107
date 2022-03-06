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
using Egorov.R._11_107.HomeWork_INF_21._02._2022;

namespace Egorov.R._11_107
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> list = new CustomList<int>(1);
            list.AddRange(new int[]{1,2,3,4,0});
            list.WriteToConsole();
        }
        public static void Print(Couple[] array)
        {
            foreach (var el in array)
                Console.WriteLine(el.Key + " " + el.Value);
        }
    }
}