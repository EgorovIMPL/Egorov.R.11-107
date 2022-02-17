using System.IO;
using System;
using System.Linq;
using System.Management.Instrumentation;

namespace Egorov.R._11_107.HomeWork_AISD_17._02._2022
{
    public class LargestNumber
    {
        public static string Start(string path)
        {
            if (Directory.Exists(Path.GetDirectoryName(path)) == false || File.Exists(path) == false)
                throw new Exception("Папка или файл отсутствует");
            StreamReader sr = new StreamReader(path);
            string[] str = sr.ReadLine().Split(' ');
            sr.Dispose();
            Array.Sort(str);
            string t = "";
            for (int g = 0; g < str.Length; g++)
            {
                for (int i = str.Length - 1; i > 0; i--)
                {
                    if (Convert.ToInt32(str[i] + str[i - 1]) < Convert.ToInt32(str[i - 1] + str[i]))
                    {
                        t = str[i - 1];
                        str[i - 1] = str[i];
                        str[i] = t;
                    }
                }
            }
            return String.Join("",str.Reverse());
        }
    }
}