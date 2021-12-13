using System;
namespace Egorov.R._11_107
{
      public class BigInt
      {
          private static string n { get; set; }
          public int[] array1 = new int[1];
          public BigInt(int t)
          {
              n = Convert.ToString(t);
              array1 = BigInt.Arr(n);
          }
          /// <summary>
        /// Перевод числа в массив
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int[] Arr(string n)
        {
            int[] array = new int[n.Length];
            int nint = Convert.ToInt32(n);
            for (int i = array.Length - 1; i >= 0; i--)
            {
                array[i] = nint % 10;
                nint /= 10;
            }
            return array;
        }
        /// <summary>
        /// Сумма
        /// </summary>
        /// <param name="array1"></param>
        /// <param name="array2"></param>
        /// <returns></returns>
        public static int[] Sum(int[] array1, int[] array2)
        {
            int[] sum = new int[Math.Max(array1.Length, array2.Length) + 1];
            int c1 = 0, c2 = 0;
            if (Math.Max(array1.Length, array2.Length) == array1.Length)
                c1 = array1.Length - array2.Length;
            else
                c2 = array2.Length - array1.Length;
            for (int g = 1; g <= c2 + c1; g++)
            {
                if (Math.Max(array1.Length, array2.Length) == array1.Length)
                    sum[g] = array1[g-1];
                else
                    sum[g] = array2[g-1];
            }
            for (int i = Math.Max(array1.Length, array2.Length); i > c2 + c1; i--)
            {
                if (array1[i - c2 - 1] + array2[i - c1 - 1] < 10)
                    sum[i] = sum[i] + array1[i - c2 - 1] + array2[i - c1 - 1];
                else
                {
                    sum[i-1] += 1;
                    sum[i] = (sum[i] + array1[i - c2 - 1] + array2[i - c1 - 1]) % 10;
                }
            }
            return sum;
        }
        /// <summary>
        /// Вычитание
        /// </summary>
        /// <param name="array1"></param>
        /// <param name="array2"></param>
        /// <returns></returns>
        public int[] Vch(int[] array2)
        {
            int[] vch = new int[array1.Length];
            for (int g = 0; g < array1.Length - array2.Length; g++)
            {
                vch[g] = array1[g];
            }
            for (int i = array1.Length - 1; i > array1.Length - array2.Length - 1; i--)
            {
                if (array1[i] - array2[i - (array1.Length - array2.Length)] >= 0)
                {
                    vch[i] = array1[i] - array2[i- (array1.Length - array2.Length)];
                }
                else if (array1[i] - array2[i - (array1.Length - array2.Length)] < 0)
                {
                    int count = 1;
                    while (array1[i - count] == 0)
                    {
                        count += 1;
                    }
                    vch[i - count] -= 1;
                    vch[i] = 10 + array1[i] - array2[i - (array1.Length - array2.Length)];
                }
            }
            Console.WriteLine("Вычитание равно");
            return vch;
        }
        /// <summary>
        /// Произведение на цифру
        /// </summary>
        /// <param name="array"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public int[] Prz(int n)
        {
            int[] prz = new int[array1.Length + 1];
            for (int i = array1.Length; i > 0; i--)
            {
                if (prz[i] + n * array1[i-1] < 10)
                {
                    prz[i] =  prz[i] + n * array1[i-1];
                }
                else
                {
                    int r = prz[i];
                    prz[i] = ((r + n * array1[i-1]) % 10);
                    prz[i-1] = (r + n * array1[i-1]) / 10;
                }
            }
            return prz;
        }
        /// <summary>
        /// Произведенние чисел
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public int[] PrzChYourSelf(int[] array2)
        {
            int count = 1;
            int[] sum = new int[array1.Length + array2.Length];
            for (int i = array2.Length-1; i >= 0; i--)
            {
                int[] arr1 = Prz(array2[i]);
                int[] arr = new int[array1.Length + count];
                count++;
                for (int g = 0; g < arr1.Length; g++)
                {
                    arr[g] = arr1[g];
                }
                sum = Sum(arr,sum);
            }
            return sum;
        }
        /// <summary>
        /// Вывод
        /// </summary>
        /// <param name="array1"></param>
        public static void Print(int[] array1)
        {
            bool f = false;
            for (int i = 0; i < array1.Length; i++)
            {
                while (array1[i] == 0 & f == false)
                    i += 1;
                if (array1[i] > 0)
                    f = true;
                Console.Write($"{array1[i]} ");
            }
            Console.WriteLine();
        }
    }
}