using System;
using System.Linq;

namespace Egorov.R._11_107
{
    public class ClassWorkLinkQ
    {
        public static void Run()
        {
            Car[] cars = new Car[]
            {
                new Car() {CarID = 1, RegistrationNumber = 567, BrigadeID = 1, Capacity = 4, Mileage = 123000},
                new Car() {CarID = 2, RegistrationNumber = 769, BrigadeID = 3, Capacity = 2, Mileage = 223000},
                new Car() {CarID = 3, RegistrationNumber = 237, BrigadeID = 1, Capacity = 6, Mileage = 323000},
                new Car() {CarID = 4, RegistrationNumber = 667, BrigadeID = 2, Capacity = 4, Mileage = 423000},
                new Car() {CarID = 5, RegistrationNumber = 123, BrigadeID = 4, Capacity = 6, Mileage = 523000},
                new Car() {CarID = 6, RegistrationNumber = 100, BrigadeID = 4, Capacity = 4, Mileage = 623000},
                new Car() {CarID = 7, RegistrationNumber = 345, BrigadeID = 5, Capacity = 4, Mileage = 723000},
                new Car() {CarID = 8, RegistrationNumber = 092, BrigadeID = 2, Capacity = 2, Mileage = 823000},
                new Car() {CarID = 9, RegistrationNumber = 710, BrigadeID = 3, Capacity = 4, Mileage = 923000},
                new Car() {CarID = 10, RegistrationNumber = 315, BrigadeID = 5, Capacity = 4, Mileage = 1023000},
                new Car() {CarID = 11, RegistrationNumber = 115, BrigadeID = 5, Capacity = 4, Mileage = 1123000},
            };
            Brigade[] brigades = new Brigade[]
            {
                new Brigade() {BrigadeID = 1, BrigadeName = "Шушпинчики", PersonNumber = 10},
                new Brigade() {BrigadeID = 2, BrigadeName = "Бразы", PersonNumber = 12},
                new Brigade() {BrigadeID = 3, BrigadeName = "Головастики", PersonNumber = 7},
                new Brigade() {BrigadeID = 4, BrigadeName = "Гномы", PersonNumber = 15},
                new Brigade() {BrigadeID = 5, BrigadeName = "Титаны", PersonNumber = 2},
            };
            //Первое задание
            Console.WriteLine("First Task");
            cars.Join(brigades, c => c.BrigadeID, b => b.BrigadeID,
                (c, b) => c.RegistrationNumber + " " + b.BrigadeName)
                .ToList()
                .ForEach(x => Console.WriteLine($"Регистрационный номер и название бригады: {x}"));
            //Второе задание
            Console.WriteLine("Second Task");
            cars.GroupBy(x => x.BrigadeID)
                .Select(x => new{CarsCount = x.Count(),AvMileage = Convert.ToInt32(x.Average(y => y.Mileage)),BrigadeID = x.Key})
                .Join(brigades, c => c.BrigadeID, b => b.BrigadeID,
                    (c, b) => b.BrigadeName + " " + c.CarsCount + " " + c.AvMileage)
                .ToList()
                .ForEach(x => Console.WriteLine($"Название бригады, Количество машин, Средний пробег: {x}"));
            //Третье задание
            Console.WriteLine("Third Task");
            cars.GroupBy(x => x.BrigadeID)
                .Where(x => x.Count() == 2)
                .Select(x => new{AverageMileage = x.Average(y => y.Mileage), BrigadeID = x.Key})
                .Join(brigades, c => c.BrigadeID, b => b.BrigadeID,
                    (c, b) => b.BrigadeName + " " + c.AverageMileage)
                .ToList()
                .ForEach(x => Console.WriteLine($"Название бригады, которая имеет две машины, и средний пробег: {x}"));
        }
    }

    public class Car
    {
        public int CarID { get; set; }
        public int RegistrationNumber { get; set; }
        public int BrigadeID { get; set; }
        public int Capacity { get; set; }
        public int Mileage { get; set; }
    }

    public class Brigade
    {
        public int BrigadeID { get; set; }
        public string BrigadeName { get; set; }
        public int PersonNumber { get; set; }
    }
}