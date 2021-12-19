using System.IO;
using System;
namespace Egorov.R._11_107.HomeWork_22._12._2021
{
    public class DateBase
    {
        public static void Date()
        {
            for (int i = 0; i < 3; i++)
            {
                string data = DateTime.Now.ToString();
                string path = @"C:\SomeDir2\" + $"note{i}.txt";
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {
                    byte[] arr = System.Text.Encoding.Default.GetBytes(data);
                    fs.Write(arr, 0, arr.Length);
                }
            }
        }
        public static void FindTime()
        {
            DirectoryInfo c = new DirectoryInfo(@"C:\SomeDir2");
            var r = c.GetFiles();
            FileInfo name = r[0];
            DateTime maxDateTime = r[0].CreationTime;
            for (int i = 1; i < r.Length; i++)
            {
                if (r[i].CreationTime.CompareTo(maxDateTime) == 1 || r[i].CreationTime.CompareTo(maxDateTime) == 0)
                {
                    maxDateTime = r[i].CreationTime;
                    name = r[i];
                }
            }
            string path = @"C:\SomeDir2\" + $"{name.ToString()}";
            using (StreamReader sr = new StreamReader(path))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
        }
    }
}