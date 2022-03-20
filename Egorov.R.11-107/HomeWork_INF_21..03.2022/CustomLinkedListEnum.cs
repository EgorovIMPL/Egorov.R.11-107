using System;
using System.Collections;
using System.Collections.Generic;
using Egorov.R._11_107.HomeWork_INF_07._03._2022;

namespace Egorov.R._11_107.HomeWork_INF_21._03._2022
{
    public class CustomLinkedListEnumerator<T> :IEnumerator where T: IComparable<T>

    {
    private static T[] list = new T[0];
    public CustomLinkedListEnumerator(CustomLinkedList<T> list1)
    {
        list = list1.ToArray();
    }
    private int position = -1;
    public bool MoveNext()
    {
        if (position < list.Length  - 1)
        {
            position++;
            return true;
        }
        else
            return false;
    }
    public object Current
    {
        get
        {
            return list[position];
        }
    }

    public void Reset() => position -= 1;
    }

    public class CustomLinkedListEnumerable<T> : IEnumerable where T: IComparable<T>
    {
        private CustomLinkedList<T> list = new CustomLinkedList<T>();

        public CustomLinkedListEnumerable(CustomLinkedList<T> list1)
        {
            list = list1;
        }
        public IEnumerator GetEnumerator()
        {
            return new CustomLinkedListEnumerator<T>(list);
        }
    }
}
