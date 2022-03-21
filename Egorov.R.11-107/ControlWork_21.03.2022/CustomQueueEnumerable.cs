using System;
using System.Collections;

namespace Egorov.R._11_107.ControlWork_21._03._2022
{
    public class CustomQueueEnumerable<T>: IEnumerable where T: IComparable<T>
    {
        private CustomQueue<T> queue = new CustomQueue<T>();
        public CustomQueueEnumerable(CustomQueue<T> queue1)
        {
            queue = queue1;
        }
        public IEnumerator GetEnumerator()
        {
            return new CustomQueueEnumerator<T>(queue);
        }
    }
    public class CustomQueueEnumerator<T> :IEnumerator where T: IComparable<T>

    {
        private static T[] queue = new T[0];
        public CustomQueueEnumerator(CustomQueue<T> list1)
        {
            queue = list1.ToReverseArray();
        }
        private int position = -1;
        public bool MoveNext()
        {
            if (position < queue.Length - 1)
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
                return queue[position];
            }
        }
        public void Reset() => position -= 1;
    }
}