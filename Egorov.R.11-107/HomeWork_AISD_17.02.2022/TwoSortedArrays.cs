using System;
using System.IO;

namespace Egorov.R._11_107.HomeWork_AISD_17._02._2022
{
    public class TwoSortedArrays
    {
        public static int[] Start()
        {
            int[] arr1= new int[1];
            int[] arr2 = new int[1];
            using (StreamReader sr = new StreamReader(Console.ReadLine()))
            {
                arr1 = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
                arr2 = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
            }
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