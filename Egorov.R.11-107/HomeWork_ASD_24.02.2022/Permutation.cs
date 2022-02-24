using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Egorov.R._11_107.HomeWork_ASD_24._02._2022
{
    public class Permutation
    {
        public static void GetAllPermutations(int[] array,ref int[] result, int value = 0)
        {
            if (array.Length == 0)
            {
                int[] swap = new int[result.Length + 1];
                for (int i = 0; i < result.Length; i++)
                    swap[i] = result[i];
                swap[result.Length] = value;
                result = swap;
                return;
            }
            for (int j = 0; j < array.Length; j++)
            {
                int[] newArray = new int[array.Length - 1];
                int count = 0;
                for (int g = 0; g < array.Length; g++)
                    if (j != g)
                    {
                        newArray[count] = array[g];
                        count++;
                    }
                GetAllPermutations(newArray,ref result, value * 10 + array[j]);
            }
        }
        public static void TwoNumbersSum(int a, int b, int c)
        {
            int[] result1 = new int[0];
            int[] result2 = new int[0];
            int[] arrayA = IntToArray(a);
            int[] arrayB = IntToArray(b);
            GetAllPermutations(arrayA,ref result1);
            GetAllPermutations(arrayB, ref result2);
            foreach (var el1 in result1)
            {
                foreach (var el2 in result2)
                {
                    if (el1 + el2 == c)
                    {
                        Console.WriteLine("YES");
                        Console.WriteLine(el1 + " " + el2);
                        return;
                    }
                }
            }
            Console.WriteLine("NO");
        }

        public static int[] IntToArray(int number)
        {
            int[] array = new int[Convert.ToString(number).Length];
            int count = 0;
            while (number > 0)
            {
                array[count] = number % 10;
                number /= 10;
                count++;
            }
            return array;
        }
    }
}