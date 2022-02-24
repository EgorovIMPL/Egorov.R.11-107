using System;
using System.IO;

namespace Egorov.R._11_107.HomeWork_AISD_17._02._2022
{
    public class ArraySubstraction
    {
        public static int[] Start(string path)
        {
            int[] arr1 = TwoSortedArrays.LineReading(1, path);
            int[] arr2 = TwoSortedArrays.LineReading(2, path);
            int[] arr = new int[0];
            foreach (int el in arr1)
            {
                int count = 0;
                for (int i = 0; i< arr2.Length;i++)
                {
                    if (arr2[i] == el)
                    {
                        count += 1;
                        break;
                    }
                }
                if (count == 0)
                {
                    int[] transition = new int[arr.Length + 1];
                    for (int i = 0; i < arr.Length; i++) 
                    {
                        transition[i] = arr[i];
                    }
                    transition[transition.Length - 1] = el;
                    arr = transition;
                }
            }
            return arr;
        }
    }
}