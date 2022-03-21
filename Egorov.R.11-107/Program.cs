using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Egorov.R._11_107.ClassWork;
using Egorov.R._11_107.ControlWork_15._12;
using Egorov.R._11_107.HomeWork_22._12._2021;
using Egorov.R._11_107.HomeWork_8._12._2021;
using Egorov.R._11_107.HomeWork_AISD_17._02._2022;
using Egorov.R._11_107.HomeWork_ASD_10._03._2022;
using Egorov.R._11_107.HomeWork_ASD_24._02._2022;
using Egorov.R._11_107.HomeWork_INF_07._03._2022;
using Egorov.R._11_107.HomeWork_INF_21._02._2022;
using Egorov.R._11_107.HomeWork_INF_21._03._2022;
using Egorov.R._11_107.ControlWork_21._03._2022;

namespace Egorov.R._11_107
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomQueue<int> queue = new CustomQueue<int>(1);
            queue.Add(2);
            queue.Add(3);
            queue.Add(4);
            queue.DelSecond();
            queue.DelPenultEl();
            CustomQueueEnumerable<int> en = new CustomQueueEnumerable<int>(queue);
            foreach (var el in en)
            {
                Console.WriteLine(el);
            }
        }
        public static void Print(Couple[] array)
        {
            foreach (var el in array)
                Console.WriteLine(el.Key + " " + el.Value);
        }
    }
}