using System;
using System.Reflection;
using Egorov.R._11_107.HomeWork_ASD_21._04._2022;
using Egorov.R._11_107.HomeWork_INF_04._04._2022;
using Egorov.R._11_107.HomeWork_INF_18._04._2022;
using Egorov.R._11_107.HomeWork_INF_25._04._2022;

namespace Egorov.R._11_107
{
    class Program
    {
        static void Main(string[] args)
        {
            PowerStation ps = new PowerStation();
            FireStation fs = new FireStation();
            MCHS mchs = new MCHS();
            ps.Start += fs.Extenguishing;
            ps.Start += mchs.Troubleshooting;
            ps.Run();
        }
    }
}