using System;
using System.Runtime.Serialization;

namespace Egorov.R._11_107.HomeWork_INF_25._04._2022
{
    public class PowerStation
    {
        public event EventHandler<DangerEventArgs> DangerHandler;
        private void Reactor()
        {
            int t = 0;
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine($"Температура реактора: {t}");
                if (i % 3 == 0)
                    t += 20;
                if (t == 300)
                {
                    DangerHandler(this,new DangerEventArgs());
                    t = 0;
                }
            }
        }
        public void Run()
        {
            DangerHandler += PowerStation.ev_DangerHandler;
            Reactor();
        }
        public static void ev_DangerHandler(object sender, DangerEventArgs danger)
        {
            MCHS mchs = new MCHS();
            FireStation fs = new FireStation();
            mchs.Troubleshooting();
            fs.Extenguishing();
        }
    }
    public class DangerEventArgs:EventArgs
    {
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