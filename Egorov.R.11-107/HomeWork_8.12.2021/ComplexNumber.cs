using System;
namespace Egorov.R._11_107.HomeWork_8._12._2021
{
    public class ComplexNumber : ICloneable
    {
        private double a;
        private double b;
        public ComplexNumber()
        {
            a = 0;
            b = 0;
        }
        public object Clone()
        {
            return new ComplexNumber(a, b);
        }
        public ComplexNumber(double x, double y)
        {
            a = x;
            b = y;
        }
        public ComplexNumber ComplexNumberAdd(ComplexNumber r)
        {
            double z = a + r.a;
            double z1 = b + r.b;
            ComplexNumber newZ = new ComplexNumber(z, z1);
            return newZ;
        }
        public void Add_ToYourSelf(ComplexNumber r)
        {
            a = a + r.a;
            b = b + r.b;
        }
        public ComplexNumber ComplexNumberSub(ComplexNumber r)
        {
            double z = a - r.a;
            double z1 = b - r.b;
            ComplexNumber newZ = new ComplexNumber(z, z1);
            return newZ;
        }
        public void Sub_ToYourSelf(ComplexNumber r)
        {
            a = a - r.a;
            b = b - r.b;
        }
        public ComplexNumber MultNumber(double r)
        {
            double z = a * r;
            double z1 = b * r;
            ComplexNumber newZ = new ComplexNumber(z, z1);
            return newZ;
        }
        public void MultNumber_ToYourSelf(double r)
        {
            a = a * r;
            b = b * r;
        }
        public ComplexNumber Mult(ComplexNumber r)
        {
            double z = a * r.a - b * r.b;
            double z1 = b * r.a + a * r.b;
            ComplexNumber newZ = new ComplexNumber(z, z1);
            return newZ;
        }
        public void Mult_ToYourSelf(ComplexNumber r)
        {
            a = a * r.a - b * r.b;
            b = b * r.a + a * r.b;
        }
        public ComplexNumber Div(ComplexNumber r)
        {
            double z = (a * r.a + b * r.b) / (r.a * r.a + r.b * r.b);
            double z1 = (b * r.a - a * r.b) / (r.a * r.a + r.b * r.b);
            ComplexNumber newZ = new ComplexNumber(z, z1);
            return newZ;
        }
        public void Div_ToYourSelf(ComplexNumber r)
        {
            a = (a * r.a + b * r.b) / (r.a * r.a + r.b * r.b);
            b = (b * r.a - a * r.b) / (r.a * r.a + r.b * r.b);
        }
        public double Length()
        {
            return Math.Sqrt(a * a + b * b);
        }
        public override string ToString()
        {
            string z;
            if (b < 0)
                z = $"{a} - {-b}*i";
            else if (b == 0)
                z = $"{a}";
            else if (a == 0)
                z = $"{b}*i";
            else
                z = $"{a} + {b}*i";
            return z;
        }
        public double Arg()
        {
            double z;
            if (a > 0)
                z = Math.Atan(b / a);
            else if (a < 0 && b >= 0)
                z = Math.PI + Math.Atan(b / a);
            else if (a < 0 && b < 0)
                z = -Math.PI + Math.Atan(b / a);
            else if (a == 0 && b > 0)
                z = Math.PI / 2;
            else
                z = - Math.PI / 2;
            return z;
        }
        public ComplexNumber Pow(double n)
        {
            double z = Math.Pow(Length(), n) * Math.Cos(Arg() * n);
            double z1 = Math.Pow(Length(), n) * Math.Sin(Arg() * n);
            ComplexNumber newZ = new ComplexNumber(z, z1);
            return newZ;
        }
        public Boolean Equals(ComplexNumber r)
        {
            if (a == r.a && b == r.b)
                return true;
            else
                return false;
        }
    }
}
