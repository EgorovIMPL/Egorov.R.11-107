using System;

namespace Egorov.R._11_107.ClassWork
{
    public class Musician : IPlayer
    {
        public string Name { get; set; }
        public string Instrument { get; set; }

        public Musician(string name, MusicalInstrument instrument)
        {
            Name = name;
            if (instrument == MusicalInstrument.Guitar)
                Instrument = "Guitar";
            else
                Instrument = "Pianino";
        }
        public void Play()
        {
            Console.WriteLine($"{Name} играет на музыкальном инструменте {Instrument}");
        }
    }
    public enum MusicalInstrument
    {
        Guitar,
        Pianino
    }
}