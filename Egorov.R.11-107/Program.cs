using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Egorov.R._11_107.ClassWork;
using Egorov.R._11_107.CodeForces;
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
using Egorov.R._11_107.HomeWork_ASD_31._03._2022;
using Egorov.R._11_107.HomeWork_INF_04._04._2022;

namespace Egorov.R._11_107
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<string> t = new BinarySearchTree<string>("mama", 4);
            t.Add("papa",10);
            t.Add("son",8);
            t.Add("lusio",11);
            t.Add("mercy",3);
            t.Add("reaper",7);
            t.Add("mccree",9);
            
            t.BigLeftTurn(ref t.root);
            t.PrintDepth();
        }

    }
}