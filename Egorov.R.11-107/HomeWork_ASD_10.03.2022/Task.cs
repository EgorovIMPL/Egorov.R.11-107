using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Egorov.R._11_107.HomeWork_ASD_10._03._2022
{
    public class Task1
    {
        public static void Start(int[] array)
        {
            int[] maxArray = Array.Empty<int>();
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int[] sumArray = new int[0];
                int sum = 0;
                for (int g = i; g < array.Length; g++)
                {
                    sumArray = sumArray.Append(array[g]).ToArray();
                    sum += array[g];
                    if (sum > max)
                    {
                        max = sum;
                        maxArray = sumArray;
                    }
                }
            }
            Console.WriteLine("Максимальная сумма:" + max + " " + "Подмассив:" + String.Join(" ",maxArray));
        }
    }
}