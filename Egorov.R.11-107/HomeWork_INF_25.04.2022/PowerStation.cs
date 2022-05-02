using System;
using System.Runtime.Serialization;

namespace Egorov.R._11_107.HomeWork_INF_25._04._2022
{
    public class PowerStation
    {
        public delegate void Danger();
        public event Danger Start;
        public void Run()
        {
            int t = 0;
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine($"Температура реактора: {t}");
                if (i % 3 == 0)
                    t += 20;
                if (t == 300)
                {
                    Start();
                    t = 0;
                }
            }
        }
    }

    public class MCHS
    {
        public void Troubleshooting()
        {
            Console.WriteLine("Устранение ЧП");
        }
    }

    public class FireStation
    {
        public void Extenguishing()
        {
            Console.WriteLine("Тушим пожар");
        }
    }
}