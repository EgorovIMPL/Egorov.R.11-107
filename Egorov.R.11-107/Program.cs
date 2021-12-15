using System;
using System.IO;
using Egorov.R._11_107.ClassWork;
using Egorov.R._11_107.ControlWork_15._12;
using Egorov.R._11_107.HomeWork_8._12._2021;

namespace Egorov.R._11_107
{
    class Program
    {
        static void Main(string[] args)
        {
            KitchenTechnic tech = new KitchenTechnic("Samsung", 100, EnergyClass.A, "Холодильник", false);
            using (StreamWriter sw = new StreamWriter(@"C:\SomeDir2\note.txt",false))
            {
                sw.WriteLine(tech.Name);
                sw.WriteLine(tech.Brand);
                sw.WriteLine(tech.KitchenRepare());
            }
        }
    }
}