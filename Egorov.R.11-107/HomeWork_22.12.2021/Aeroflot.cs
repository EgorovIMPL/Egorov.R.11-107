using System;
namespace Egorov.R._11_107.HomeWork_22._12._2021
{
    public struct Aeroflot
    {
        public string Destination;
        public int FlightNumber;
        public string PlaneType;
        public Aeroflot[] AeroflotArr()
        {
            Aeroflot[] aeroflotArr = new Aeroflot[7];
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Введите пункт назначения, номер рейса и тип самолёта");
                aeroflotArr[i] = new Aeroflot(){Destination = Console.ReadLine(), FlightNumber = Int32.Parse(Console.ReadLine()), PlaneType = Console.ReadLine()};
            }
            return aeroflotArr;
        }
        public static Aeroflot[] Sort(Aeroflot[] arr)
        { 
            Aeroflot temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i].FlightNumber > arr[j].FlightNumber)
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }                   
                }            
            }
            return arr;
        }
        public static void PersonalDestination(Aeroflot[] arr)
        {
            Console.WriteLine("Введите пункт назначения");
            string dest = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < 7; i++)
            {
                if (dest == arr[i].Destination)
                {
                    Console.WriteLine($"{arr[i].FlightNumber} {arr[i].PlaneType}");
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Рейсов с данным пунктом нет");
            }
        }
    }
}