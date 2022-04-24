using System;
using System.Linq;

namespace Egorov.R._11_107.HomeWork_ASD_21._04._2022
{
    public class MaxNumber
    {
        public int Max(int[] array)
        {
            int[] newArray = new int[0];
            if (array.Length == 2)
            {
                if (array[0] > array[1])
                    return array[0];
                return array[1];
            }
            else if(array.Length == 1)
            {
                return array[0];
            }
            else
            {
                newArray = newArray.Append(Max(Cut(array, 0, array.Length / 2))).ToArray();
                newArray = newArray.Append(Max(Cut(array, array.Length / 2, array.Length))).ToArray();
            }
            return Max(newArray);
        }
        private int[] Cut(int[] array, int a, int b)
        {
            int[] newArray = new int[0];
            for (int i = a; i < b; i++)
            {
                newArray = newArray.Append(array[i]).ToArray();
            }

            return newArray;
        }
    }
}