using System;
namespace Egorov.R._11_107.HomeWork_8._12._2021
{
    public class RationalFraction : IComparable
    {
        private int a;
        private int b;
        /// <summary>
        /// Числитель
        /// </summary>
        public int A { get { return a; } }
        /// <summary>
        /// Знаменатель
        /// </summary>
        public int B { get { return b; } }
        public RationalFraction()
        {
            a = 0;
            b = 1;
        }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="x">Числитель</param>
        /// <param name="y">Знаменатель</param>
        public RationalFraction(int x, int y)
        {
            a = x;
            b = y;

        }

        public int CompareTo(object obj)
        {
            RationalFraction r = obj as RationalFraction;
            int z = NOK(b, r.b);
            int a1 = z / b * a;
            int ra1 = z / r.b * r.a;
            if (a1 > ra1)
                return 1;
            else if (a1 == ra1)
                return 0;
            else
                return -1;
        }
        private void reduce_YourSelf()
        {
            int z = NOD(a, b);
            a = a / z;
            b = b / z;
        }
        private RationalFraction reduce(RationalFraction r)
        {
            int z = NOD(r.a, r.b);
            return new RationalFraction(r.a / z, r.b / z);
        }
        private int NOD(int x, int y)
        {
            x = Math.Abs(x);
            y = Math.Abs(y);
            while (x != 0 && y != 0)
            {
                if (x > y)
                    x = x % y;
                else
                    y = y % x;
            }
            return x + y;
        }
        private int NOK(int x, int y)
        {
            return x * y / NOD(x, y);
        }
        public RationalFraction Add(RationalFraction r)
        {
            int z = NOK(r.b, b);
            int z1 = z / b * a + z / r.b * r.a;
            RationalFraction newZ = new RationalFraction(z1, z);
            return reduce(newZ);
        }
        public void Add_ToYourself(RationalFraction r)
        {
            int z = NOK(r.b, b);
            a = z / b * a + z / r.b * r.a;
            b = z;
            reduce_YourSelf();
        }
        public RationalFraction Sub(RationalFraction r)
        {
            int z = NOK(r.b, b);
            int z1 = z / b * a - z / r.b * r.a;
            RationalFraction newZ = new RationalFraction(z1, z);
            return reduce(newZ);
        }
        public void Sub_ToYourself(RationalFraction r)
        {
            int z = NOK(r.b, b);
            a = z / b * a - z / r.b * r.a;
            b = z;
            reduce_YourSelf();
        }
        public RationalFraction Mult(RationalFraction r)
        {
            RationalFraction newZ = new RationalFraction(a * r.a, b * r.b);
            return reduce(newZ);
        }
        public void Mult_ToYourself(RationalFraction r)
        { ;
            a = a * r.a;
            b = b * r.b;
            reduce_YourSelf();
        }
        public RationalFraction Div(RationalFraction r)
        {
            RationalFraction newZ = new RationalFraction(a * r.b, b * r.a);
            return reduce(newZ);
        }
        public void Div_ToYourself(RationalFraction r)
        { ;
            a = a * r.b;
            b = b * r.a;
            reduce_YourSelf();
        }
        public int NumberPart()
        {
            return a / b;
        }
        public bool Equals(RationalFraction r)
        {
            r = reduce(r);
            var current = reduce(this);
            return r.A == current.A && r.B == current.B;
        }
        public double Value()
        {
            return Convert.ToDouble(a) / Convert.ToDouble(b);
        }
        public string RFToString()
        {
            return $"{a}/{b}";
        }
    
}
}