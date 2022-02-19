using System;
using System.IO;
using Egorov.R._11_107.ClassWork;
using Egorov.R._11_107.ControlWork_15._12;
using Egorov.R._11_107.HomeWork_22._12._2021;
using Egorov.R._11_107.HomeWork_8._12._2021;
using Egorov.R._11_107.HomeWork_AISD_17._02._2022;
using Egorov.R._11_107.HomeWork_INF_21._02._2022;

namespace Egorov.R._11_107
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new CustomList();
            list.Add(1);
            list.Add(2);
            list.Add(-3);
            list.AddToHead(2);
            list.Add(10, 1);
            list.AddBeforeAndAfterK(1,3);
            list.WriteToConsole();
        }
    }
}