using System;
using System.Collections.Generic;

namespace Egorov.R._11_107.HomeWork_ASD_24._02._2022
{
    public class Couple
    {
        public int Key;
        public int Value;

        public Couple(int key, int value)
        {
            Key = key;
            Value = value;
        }
    }

    public class CustomDictionary
    {
        public static Couple[] Create(int[] array)
        {
            Couple[] dictionary = new Couple[0];
            foreach (var el in array)
            {
                int i = 0;
                while (i < dictionary.Length)
                {
                    if (dictionary[i].Key == el)
                    {
                        dictionary[i].Value++;
                        break;
                    }

                    i++;
                }
                if (i == dictionary.Length)
                {
                    Array.Resize(ref dictionary, dictionary.Length + 1);
                    dictionary[i] = new Couple(el, 1);
                }
            }
            return dictionary;
        }
        public static void NumberMoreHalf(int[] array)
        {
            Couple[] dictionary = Create(array);
            foreach (var el in dictionary)
                if (el.Value > array.Length/2)
                {
                    Console.WriteLine(el.Key + " " + el.Value);
                    break;
                }
        }
    }
}