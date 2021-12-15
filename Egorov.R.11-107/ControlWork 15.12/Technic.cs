using System;

namespace Egorov.R._11_107.ControlWork_15._12
{
    public abstract class Technic
    {
        public string Brand { get; set; }
        public int Power { get; set; }
        public string EnergyType { get; set; }
        public string Name { get; set; }
        public Technic(string brand, int power, EnergyClass energyType, string name)
        {
            Brand = brand;
            Power = power;
            if (energyType == EnergyClass.A)
                EnergyType = "A";
            else if (energyType == EnergyClass.B)
                EnergyType = "B";
            else if (energyType == EnergyClass.C)
                EnergyType = "C";
            else if (energyType == EnergyClass.D)
                EnergyType = "D";
            else if (energyType == EnergyClass.E)
                EnergyType = "E";
            else if (energyType == EnergyClass.F)
                EnergyType = "F";
            else
                EnergyType = "G";
            Name = name;
        }
    }
    public enum EnergyClass
    {
        A,
        B,
        C,
        D,
        E,
        F,
        G
    }
}