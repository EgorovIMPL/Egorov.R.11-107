using System;
using System.IO;

namespace Egorov.R._11_107.HomeWork_AISD_17._02._2022
{
    public class KSortedArrays
    {
        public static int[] Start(string path)
        {
            if (Directory.Exists(Path.GetDirectoryName(path)) == false || File.Exists(path) == false)
                throw new Exception("Папка или файл отсутствует");
            StreamReader sr = new StreamReader(path);
            string str = sr.ReadLine();
            if (str.Split(' ').Length != 1)
                throw new Exception("Не подходит под условие");
            sr.Dispose();
            int length= Convert.ToInt32(str);
            int[] arr = TwoSortedArrays.LineReading(2, path);
            for (int i = 3; i <= length + 1; i++)
            {
                arr = TwoSortedArrays.Sorting(arr, TwoSortedArrays.LineReading(i, path));
            }
            return arr;
        }
    }
}