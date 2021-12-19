using System;
using System.IO;
using System.Text;

namespace Egorov.R._11_107.HomeWork_22._12._2021
{
    public class CreateFootBall
    {
        public static void File()
        {
            Console.WriteLine("Введите кол-во команд");
            int numTeams = Int32.Parse(Console.ReadLine());
            using(FileStream fs = new FileStream(@"C:\SomeDir2\teams.txt", FileMode.Create)){}
            for (int i = 0; i < numTeams; i++)
            {
                using (StreamWriter sw = new StreamWriter(@"C:\SomeDir2\teams.txt", true))
                {
                    Console.WriteLine("Введите название команды");
                    string name = Console.ReadLine();
                    Console.WriteLine("Введите дату матча");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine("Введите набранное кол-во очков");
                    int points = Int32.Parse(Console.ReadLine());
                    string text = $"TeamName: {name} DateMatch: {date} Points: {points}";
                    sw.WriteLine(text);
                }
            }
        }
    }

    public struct FootBall
    {
        public static string[] MostValuableTeam()
        {
            using (StreamReader sr = new StreamReader(@"C:\SomeDir2\teams.txt"))
            {
                Console.WriteLine("Введите временной промежуток");
                DateTime dt1 = DateTime.Parse(Console.ReadLine());
                DateTime dt2 = DateTime.Parse(Console.ReadLine());
                int max = 0;
                string[] mostValuable = null;
                for (int i = 0; i < sr.Peek(); i++)
                {
                    string[] arr = sr.ReadLine().Split(' ');
                    if (Convert.ToInt32(arr[arr.Length - 1]) > max && dt1.CompareTo(Convert.ToDateTime(arr[arr.Length-4]+" "+arr[arr.Length-3])) == -1 && dt2.CompareTo(Convert.ToDateTime(arr[arr.Length-4]+" "+arr[arr.Length-3])) == 1)
                    {
                        max = Convert.ToInt32(arr[arr.Length - 1]);
                        mostValuable = arr;
                    }
                }
                return mostValuable;
            }
        }
    }
}