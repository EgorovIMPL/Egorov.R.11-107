using System;
namespace Egorov.R._11_107.ControlWork_15._12
{
    public class KitchenTechnic : Technic, ICloneable
    {
        public bool BuiltIn { get; set; }
        private EnergyClass CloneEnergyClass;
        public object Clone()
        {
            return new KitchenTechnic(Brand, Power, CloneEnergyClass,Name,BuiltIn);
        }
        public KitchenTechnic(string brand, int power, EnergyClass energyType, string name, bool builtIn) : base(brand,
            power, energyType, name)
        {
            CloneEnergyClass = energyType;
            BuiltIn = builtIn;
        }
        public void Set()
        {
            Console.WriteLine($"{Name} установлена");
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            else
            {
                KitchenTechnic tech = obj as KitchenTechnic;
                if (tech.BuiltIn == BuiltIn && tech.Name == Name && tech.Brand == Brand &&
                    tech.EnergyType == EnergyType && tech.Power == Power)
                    return true;
                else
                    return false;
            }
        }
        public override string ToString()
        {
            return $"Название: {Name}, Производитель: {Brand}, Мощность: {Power}, Класс Энергопотребления: " +
                   $"{EnergyType}, Встраиваемая: {BuiltIn}";
        }
        public override int GetHashCode()
        {
            int hashcode = Name.GetHashCode();
            hashcode = 31 * hashcode + Brand.GetHashCode() + Power.GetHashCode();
            return hashcode;
        }
    }
}