using System;

namespace Egorov.R._11_107.ClassWork
{
    public class FootBallPlayer : IPlayer
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public FootBallPlayer(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void Play()
        {
            if (Age < 20)
                Console.WriteLine($"{Name} играет в футбол");
        }
    }
}