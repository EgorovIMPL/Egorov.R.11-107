using System;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace Egorov.R._11_107.ControlWork_21._03._2022
{
    public class QueueNode<T>
    {
        public T InfField;
        public QueueNode<T> NextNode;
        public QueueNode(T inf)
        {
            InfField = inf;
        }
    }
    public class CustomQueue<T> 
    {
        private QueueNode<T> head;
        public CustomQueue(){ }
        public CustomQueue(T inf)
        {
            head = new QueueNode<T>(inf);
        }
        public void Add(T el)
        {
            QueueNode<T> headCopy = head;
            while (headCopy.NextNode != null)
            {
                headCopy = headCopy.NextNode;
            }
            headCopy.NextNode = new QueueNode<T>(el);
        }
        public QueueNode<T> Delete()
        {
            QueueNode<T> headCopy = head;
            head = head.NextNode;
            return headCopy;
        }

        public void DelSecond()
        {
            if (head.NextNode == null)
                throw new Exception("Очередь длины 1");
            head.NextNode = head.NextNode.NextNode;
        }
        
        public void DelPenultEl()
        {
            QueueNode<T> headCopy = head;
            if (head == null)
                throw new Exception("Список пуст");
            if (head.NextNode == null)
                throw new Exception("Список длины 1");
            while (headCopy.NextNode != null)
            {
                if (headCopy.NextNode.NextNode != null && headCopy.NextNode.NextNode.NextNode == null)
                    headCopy.NextNode = headCopy.NextNode.NextNode;
                else
                    headCopy = headCopy.NextNode;
            }
        }
        public int Size()
        {
            QueueNode<T> headCopy = head;
            int count = 0;
            while (headCopy != null)
            {
                count += 1;
                headCopy = headCopy.NextNode;
            }
            return count;
        }
        public bool IsEmpty()
        {
            return head == null;
        }

        public T[] ToReverseArray()
        {
            T[] array = new T[Size()];
            QueueNode<T> headCopy = head;
            int count = Size() - 1;
            while (headCopy != null)
            {
                array[count] = headCopy.InfField;
                count--;
                headCopy = headCopy.NextNode;
            }
            return array;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            QueueNode<T> headCopy = head.NextNode;
            sb.Append(head.InfField);
            while (headCopy != null)
            {
                sb.Append(" " + headCopy.InfField);
                headCopy = headCopy.NextNode;
            }

            return sb.ToString();
        }
    }
}