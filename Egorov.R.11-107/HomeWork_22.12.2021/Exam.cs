using System;
using System.IO;
namespace Egorov.R._11_107.HomeWork_22._12._2021
{
    public struct Exam
    {
        public static void TimeTable()
        {
            string[] timeTable1 = new string[0];
            using (StreamReader sr = new StreamReader(@"C:\SomeDir2\exam.txt"))
            {
                DateTime[] time = new DateTime[sr.Peek()];
                string[] timeTable = new string[sr.Peek()];
                for (int i = 0; i < sr.Peek(); i++)
                {
                    string[] arr = sr.ReadLine().Split(' ');
                    time[i] = Convert.ToDateTime(arr[arr.Length - 1] + " " + arr[arr.Length - 2]);
                    int count = 0;
                    for (int j = 0; j < i; j++)
                    {
                        if (time[i] == time[j])
                        {
                            count++;
                        }
                    }
                    if (count > 0)
                    {
                        time[i] = time[i].Add(new TimeSpan(1, 0, 0, 0));
                    }
                    timeTable[i] = $"{arr[0]} {time[i]}";
                }
                timeTable1 = timeTable;
            }
            using (FileStream fs = new FileStream(@"C:\SomeDir2\timeTable.txt",FileMode.Create)){}
            using (StreamWriter sw = new StreamWriter(@"C:\SomeDir2\timeTable.txt",true))
            {
                foreach (var value in timeTable1)
                {
                    sw.WriteLine(value);
                }
            }
        }
    }
}