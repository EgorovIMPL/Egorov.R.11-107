using System;
using Egorov.R._11_107.ClassWork;
using Egorov.R._11_107.HomeWork_8._12._2021;

namespace Egorov.R._11_107
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 123;
            int n1 = 22;
            BigInt b1 = new BigInt(n);
            BigInt b2 = new BigInt(n1); 
            BigInt.Print(b2.array1);
            BigInt.Print(b1.PrzChYourSelf(b2.array1));
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