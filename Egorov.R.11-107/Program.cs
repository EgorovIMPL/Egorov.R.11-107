using System;
using System.Linq;
using System.Collections.Generic;
using Egorov.R._11_107.ControlWork_05._05._2022;
using Egorov.R._11_107.HomeWork_INF_04._04._2022;
using Egorov.R._11_107.HomeWork_INF_07._03._2022;
using Egorov.R._11_107.HomeWork_INF_21._02._2022;
using Egorov.R._11_107.HomeWork_INF_25._04._2022;

namespace Egorov.R._11_107
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassWorkLinkQ.Run();
        }
        static void MirroredString(string str)
        {
            int l = str.Length;
            int l2 = str.Length / 2;
            if ((l % 2 == 1  && str[l2] != '8' && str[l2] != '0'))
            {
                Console.WriteLine("No");
                return;
            }
            for (int i = 0; i < l2; i++)
            {
                if ((str[i] == '3' & str[l - i - 1] == 'E') || (str[i] == 'E' & str[l - i - 1] == '3') || 
                    (str[i] == '2' & str[l - i - 1] == '5') || (str[i] == '5' & str[l - i - 1] == '2'))
                {
                    
                }
                else if (str[i] != str[l - i - 1])
                {
                    Console.WriteLine("No");
                    return;
                }
            }
            Console.WriteLine("Yes");
        }
        static double Discrim(double a, double b, double c)
        {
            // Task<double> myTask = new Task<double>(() => Discrim(1,2,1));
            // myTask.Start();
            // double discr = myTask.Result;
            // Task<double[]> myTask1 = myTask.ContinueWith(task => Roots(discr,1,2));
            // Console.WriteLine(string.Join(" ", myTask1.Result));
            return Math.Pow(b, 2) - 4 * a * c;
        }

        static double[] Roots(double discr,double a, double b)
        {
            double[] array = new[] {(-b + Math.Pow(discr, 0.5)) / (2.0 * a), (-b + Math.Pow(discr, 0.5)) / (2.0 * a)};
            return array;
        }
    }
}