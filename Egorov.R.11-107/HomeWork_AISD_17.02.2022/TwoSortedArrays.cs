using System;
using System.IO;

namespace Egorov.R._11_107.HomeWork_AISD_17._02._2022
{
    public class TwoSortedArrays
    {
        public static int[] LineReading(int n, string path)
        {
            //n-строка, которую мы хотим считать
            if (Directory.Exists(Path.GetDirectoryName(path)) == false || File.Exists(path) == false)
                throw new Exception("Папка или файл отсутствует");
            string[] arr = File.ReadAllLines(path);
            int[] intarr = Array.ConvertAll(arr[n - 1].Split(' '), int.Parse);
            if(SortOrNot(intarr) == false)
                throw new Exception("Сортировка нарушена");
            return intarr;
        }
        public static bool SortOrNot(int[] arr)
        {
            bool result = true;
            int[] arr1 = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
                arr1[i] = arr[i];
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != arr1[i])
                {
                    return false;
                }
            }
            return result;
        }
        public static int[] Sorting(int[] arr1, int[] arr2)
        {
            int[] sorted_array = new int[arr1.Length + arr2.Length];
            int count1 = 0;
            int count2 = 0;
            for (int i = 0; i < arr1.Length + arr2.Length; i++)
            {
                if (count1 < arr1.Length && count2 < arr2.Length && arr1[count1] <= arr2[count2])
                {
                    sorted_array[i] = arr1[count1];
                    count1++;
                }
                else if (count1 < arr1.Length && count2 < arr2.Length && arr1[count1] >= arr2[count2])
                {
                    sorted_array[i] = arr2[count2];
                    count2++;
                }
                else if(count1 >= arr1.Length)
                {
                    sorted_array[i] = arr2[count2];
                    count2++;
                }
                else if(count2 >= arr2.Length)
                {
                    sorted_array[i] = arr1[count1];
                    count1++;
                }
            }
            return sorted_array;
        }
        public static void Print(int[] array)
        {
            foreach (var el in array)
            {
                Console.Write(el + " ");
            }
        }
    }
}