using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Egorov.R._11_107.HomeWork_ASD_24._02._2022
{
    public class Permutation
    {
        public static void GetPermutationsArrayLenght(int[] array,ref int[] result, int value = 0)
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
                GetPermutationsArrayLenght(newArray,ref result, value * 10 + array[j]);
            }
        }
        private static void GetAllPermutations(int[] array,ref string[] result, string value = "")
        {
            string[] swap = new string[result.Length + 1];
            for (int i = 0; i < result.Length; i++)
                swap[i] = result[i];
            swap[result.Length] = value;
            result = swap;
            if (array.Length == 0)
                return;
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
                GetAllPermutations(newArray,ref result, value + array[j]);
            }
        }
        public static void TwoNumbersSum(int a, int b, int c)
        {
            int[] result1 = new int[0];
            int[] result2 = new int[0];
            int[] arrayA = IntToArray(a);
            int[] arrayB = IntToArray(b);
            GetPermutationsArrayLenght(arrayA,ref result1);
            GetPermutationsArrayLenght(arrayB, ref result2);
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
        public static string[][] IncreasingPermutations(int[] array)
        {
            string[] result = new string[0];
            GetAllPermutations(array,ref result);
            string[][] final = new string[0][];
            foreach (var el in result)
            {
                string[] elArray = new string[el.Length];
                for (int i = 0; i < el.Length; i++)
                    elArray[i] = $"{el[i]}";
                if (elArray.Length == 1)
                    final = Add(final, elArray);
                else
                {
                    bool check = false;
                    for (int i = 0; i < el.Length-1; i++)
                        if (el[i] > el[i + 1])
                            check = true;
                    if (check == false)
                        final = Add(final, elArray);
                }
            }
            return final;
        }
        private static string[][] Add(string[][] array, string[] str)
        {
            string[][] result = new string[array.Length + 1][];
            for (int i = 0; i < array.Length; i++)
                result[i] = array[i];
            result[array.Length] = str;
            return result;
        }
        private static int[] IntToArray(int number)
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