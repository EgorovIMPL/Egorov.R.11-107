using System.IO;
using System;
namespace Egorov.R._11_107.HomeWork_22._12._2021
{
    public class DataBase
    {
        public static void Data()
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
            FileInfo name = null;
            DateTime maxDateTime = new DateTime(1,1,1, 0,0,1);
            for (int i = 0; i < r.Length; i++)
            {
                string path = @"C:\SomeDir2\" + $"{r[i]}";
                FileInfo fileInfo = new FileInfo(path);
                if (fileInfo.CreationTime.CompareTo(maxDateTime) == 1 || fileInfo.CreationTime.CompareTo(maxDateTime) == 0)
                {
                    maxDateTime = fileInfo.CreationTime;
                    name = r[i];
                }
            }
            string path1 = @"C:\SomeDir2\" + $"{name.ToString()}";
            using (StreamReader sr = new StreamReader(path1))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
        }
    }
}