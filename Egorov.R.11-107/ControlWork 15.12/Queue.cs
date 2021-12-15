using System;
using System.CodeDom;
using System.Xml;

namespace Egorov.R._11_107.ControlWork_15._12
{
    public class Queue
    {
        private KitchenTechnic[] technics = new KitchenTechnic[3];
        private int index = 1;
        public void Add(KitchenTechnic kitchenTechnic)
        {
            if (index < technics.Length)
            {
                technics[index - 1] = kitchenTechnic;
                index++;
                Console.WriteLine("Сработало добавление");
            }
            else
            {
                KitchenTechnic[] newTechnics = new KitchenTechnic[technics.Length + 3];
                for (int i = 0; i < index; i++)
                {
                    newTechnics[i] = technics[i];
                }
                newTechnics[index-1] = kitchenTechnic;
                index++;
                technics = newTechnics;
                Console.WriteLine("Сработало добавление");
            }
        }
        public KitchenTechnic Read()
        {
            if (technics[0] is KitchenTechnic)
            {
                KitchenTechnic read = technics[0];
                KitchenTechnic[] newTechnics = new KitchenTechnic[technics.Length - 1];
                for (int i = 1; i < index; i++)
                {
                    newTechnics[i-1] = technics[i];
                }
                index--;
                technics = newTechnics;
                Console.WriteLine("Сработало чтение");
                return read;
            }
            else
            {
                throw new Exception("Ошибка. Пустая очередь");
            }
        }
        public void Print()
        {
            for (int i = 0; i < index-1; i++)
            {
                Console.WriteLine($"{technics[i].Name} фирмы {technics[i].Brand}");
            } 
        }
    }
}