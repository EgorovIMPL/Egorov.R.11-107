using System;
using System.IO;

namespace Egorov.R._11_107
{
    public class WorkWithFile
    {
        public static void Start()
        {
            string text = Console.ReadLine();
            using (StreamWriter sw = new StreamWriter(@"C:\SomeDir2\note.txt", false, System.Text.Encoding.Default))
            {
                sw.WriteLine(text);
            }

            using (StreamReader sr = new StreamReader(@"C:\SomeDir2\note.txt"))
            {
                Console.WriteLine("FileText:");
                Console.WriteLine(sr.ReadToEnd());
            }
        }
        
    }
}