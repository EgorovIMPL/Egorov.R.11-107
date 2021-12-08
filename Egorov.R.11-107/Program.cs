using System;
using Egorov.R._11_107.HomeWork_8._12._2021;

namespace Egorov.R._11_107
{
    class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber z = new ComplexNumber(1, 1);
            var r = z.Clone() as ComplexNumber;
            Console.WriteLine(r.ToString());
        }
    }
}