using System;
using Egorov.R._11_107.ClassWork;
using Egorov.R._11_107.HomeWork_8._12._2021;

namespace Egorov.R._11_107
{
    class Program
    {
        static void Main(string[] args)
        {
            RationalFraction r = new RationalFraction(1, 5);
            RationalFraction r1 = new RationalFraction(1, 3);
            RationalFraction r2 = new RationalFraction(1, 2);
            RationalFraction[] arr = new []{r2, r1, r};
            Console.WriteLine(r2.CompareTo(r1));
        }

        class PlayerPlayOrNot
        {
            public static void PlayOrNot(IPlayer[] player)
            {
                foreach (var p in player)
                {
                    if (p is FootBallPlayer)
                    {
                        var foot = p as FootBallPlayer;
                        if (foot.Age < 20)
                            foot.Play();
                    }
                    else if (p is Musician)
                    {
                        p.Play();
                    }
                }
            }
        }
    }
}