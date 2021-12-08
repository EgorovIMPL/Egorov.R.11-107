using System;
using System.Security.Cryptography;

namespace Egorov.R._11_107.HomeWork_8._12._2021
{
    public class Extension
    {
        static public string StringExtension(string s1, string s2)
        {
            string s3 = null;
            string[] input1 = s1.Split(' ');
            string[] input2 = s2.Split(' ');
            for (int i = 0; i < Math.Min(input1.Length, input2.Length); i++)
            {
                s3 += input1[i] + " " + input2[i] + " ";
            }
            for (int i = Math.Min(input1.Length, input2.Length); i < Math.Max(input1.Length, input2.Length); i++)
            {
                if (Math.Max(input1.Length, input2.Length) == input1.Length)
                {
                    s3 += input1[i] + " ";
                }
                else
                    s3 += input2[i] + " ";
            }
            return s3;
        }
    }
}