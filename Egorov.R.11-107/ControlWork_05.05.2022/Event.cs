using System;
using System.Runtime.Remoting.Messaging;

namespace Egorov.R._11_107.ControlWork_05._05._2022
{
    public class Event
    {
        public event EventHandler<ProductEventArgs> ProductHandler;
        public void Product(string name, int number)
        {
            Console.WriteLine(name + number);
            ProductHandler(this, new ProductEventArgs());
        }
        /* Реализовать события, самим предложить список аргументов события
        * 15) Товар поступает в магазин, директор магазина подписывает документы, 
        * товаровед проверяет соответствие пришедшего товара и накладной
        */
    }
    public class Director
    {
        public void SendMessage(object obj, ProductEventArgs productEventArgs)
        {
            Console.WriteLine("Директор подписал документы");
        }
    }
    public class Merchendaiser
    {
        public void SendMessage(object obj, ProductEventArgs productEventArgs)
        {
            Console.WriteLine("товаровед проверил соответствие пришедшего товара и накладной");
        }
    }

    public class ProductEventArgs:EventArgs
    {
    }

    public class Run
    {
        public void Start()
        {
            Event ev = new Event();
            Director dr = new Director();
            Merchendaiser mr = new Merchendaiser();
            ev.ProductHandler += ev_ProductHandler;
            ev.Product("apple",6);
            dr.SendMessage(ev,new ProductEventArgs());
            mr.SendMessage(ev,new ProductEventArgs());
        }
        static void ev_ProductHandler(object sender, ProductEventArgs pr)
        {
        }
    }
}