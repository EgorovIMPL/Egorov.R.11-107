using System;

namespace Egorov.R._11_107
{
    public abstract class DecorationObject
    {
        public int DecorationArea { get; set; }
        public int SocketsNumber { get; set; }
        public DecorationObject(int area, int sockets)
        {
            DecorationArea = area;
            SocketsNumber = sockets;
        }
    }
    public class ChristmasTree : DecorationObject
    {
        public double Height { get; set; }
        
        public ChristmasTree(int area, int sockets, double height) : base(area, sockets)
        {
            Height = height;
        }
    }
    public class ShowCase : DecorationObject
    {
        public ShowCase(int area, int sockets) : base(area, sockets){}
    }
    public abstract class Decoration
    {
        public int Area { get; set; }
        public bool NeedSocket { get; set; }

        public Decoration(int area, bool need)
        {
            Area = area;
            NeedSocket = need;
        }
    }

    public class Garland : Decoration
    {
        public int ColorsNumber { get; set; }
        public int ModsNumer { get; set; }

        public Garland(int area, bool need, int colors, int mods ) : base(area, need)
        {
            ColorsNumber = colors;
            ModsNumer = mods;
        }
    }
    public class Toy : Decoration
    {
        public double Weight { get; set; }
        public string Fragility { get; set; }

        public Toy(int area, bool need, double weight, string fragility) : base(area, need)
        {
            Weight = weight;
            Fragility = fragility;
        }
    }
    public class NewYear
    {
        public static void Decorate(DecorationObject decoration)
        {
            int sockets = decoration.SocketsNumber;
            int area = decoration.DecorationArea;
            while (sockets > 0 && area > 0)
            {
                Console.WriteLine("Введите характеристики гирлянды");
                int area1 = Int32.Parse(Console.ReadLine());
                bool need = Boolean.Parse(Console.ReadLine());
                int color = Int32.Parse(Console.ReadLine());
                int mod = Int32.Parse(Console.ReadLine());
                Garland garland = new Garland(area1, need, color, mod);
                sockets -= 1;
                area -= area1;
                Console.WriteLine($"Украшено гирляндой с количеством цветов {color} и количеством режимов {mod}");
            }
            while (area > 0)
            {
                int area1 = Int32.Parse(Console.ReadLine());
                bool need = Boolean.Parse(Console.ReadLine());
                double weight = Double.Parse(Console.ReadLine());
                string fragility = Console.ReadLine();
                area -= area1;
                Console.WriteLine($"Украшено игрушкой, которая весит {weight}");
            }
        }
    }
}