using System;

namespace Egorov.R._11_107.HomeWork_22._12._2021
{
    public struct Train
    {
        public string Destination;
        public int TrainNumber;
        public DateTime Time;
        public static Train[] TrainArr()
        {
            Train[] trainArr = new Train[8];
            for (int i = 0; i < trainArr.Length; i++)
            {
                Console.WriteLine("Введите пункт назначения, номер поездда и время отправления");
                trainArr[i] = new Train(){Destination = Console.ReadLine(), TrainNumber = Int32.Parse(Console.ReadLine()), Time = DateTime.Parse(Console.ReadLine())};
            }
            return trainArr;
        }
        public static Train[] Sort(Train[] arr)
        { 
            Train temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i].TrainNumber > arr[j].TrainNumber)
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }                   
                }            
            }
            return arr;
        }
        public static void PersonalTrain(Train[] arr)
        {
            Console.WriteLine("Введите номер поезда");
            int num = Int32.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (num == arr[i].TrainNumber)
                {
                    Console.WriteLine($"{arr[i].Destination} {arr[i].Time}");
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Поездов с данным номером нет");
            }
        }
    }
}