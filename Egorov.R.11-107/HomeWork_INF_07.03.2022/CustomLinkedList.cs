using System;
using System.Text;

namespace Egorov.R._11_107.HomeWork_INF_07._03._2022
{
    public class LinkedNode<T> where T: IComparable<T>
    {
        public T InfField;
        public LinkedNode<T> NextNode;
        public LinkedNode<T> PrevNode;
        public LinkedNode(T inf)
        {
            InfField = inf;
        }
    }
    public class CustomLinkedList<T> : ICustomCollection<T> where T: IComparable<T>
    {
        private LinkedNode<T> head;
        public CustomLinkedList() { }
        public CustomLinkedList(T elem) 
        {
            head = new LinkedNode<T>(elem);
        }
        public CustomLinkedList(T[] array)
        {
            if (array == null && array.Length == 0)
                return;
            
            head = new LinkedNode<T>(array[0]);

            if (array.Length > 1)
            {
                var headCopy = head;
                for (int i = 1; i < array.Length; i++)
                {
                    var node = new LinkedNode<T>(array[i]);
                    node.PrevNode = headCopy;
                    headCopy.NextNode = node;
                    headCopy = headCopy.NextNode;
                }
            }
        }

        public override string ToString() 
        {
            if (head == null)
                return "Список пуст";
            var sb = new StringBuilder();
            var headCopy = head;
            while (headCopy != null)
            {
                sb.Append(headCopy.InfField.ToString());
                if (headCopy.NextNode != null)
                    sb.Append("<=>");
                headCopy = headCopy.NextNode;
            }
            return sb.ToString();
        }

        public void WriteToConsole()
        {
            Console.WriteLine(ToString());
        }

        public void Add(T elem)
        {
            throw new NotImplementedException();
        }

        public void AddRange(T[] elems)
        {
            LinkedNode<T> headCopy = head;
            while (headCopy.NextNode != null)
                headCopy = headCopy.NextNode;
            foreach (var el in elems)
            {
                LinkedNode<T> newNode = new LinkedNode<T>(el);
                newNode.PrevNode = headCopy;
                headCopy.NextNode = newNode;
                headCopy = headCopy.NextNode;
            }
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T elem)
        {
            throw new NotImplementedException();
        }

        public int IndexOf(T elem)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T elem)
        {
            throw new NotImplementedException();
        }

        public bool isEmpty()
        {
            throw new NotImplementedException();
        }

        public void Remove(T elem)
        {
            throw new NotImplementedException();
        }

        public void RemoveAll(T elem)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public void Reverse()
        {
            LinkedNode<T> headCopy = head.NextNode;
            LinkedNode<T> reverse = new LinkedNode<T>(head.InfField);
            while (headCopy != null)
            {
                LinkedNode<T> reverseCopy = new LinkedNode<T>(headCopy.InfField);
                reverse.PrevNode = reverseCopy;
                reverseCopy.NextNode = reverse;
                reverse = reverseCopy;
                headCopy = headCopy.NextNode;
            }
            head = reverse;
        }

        public int Size()
        {
            throw new NotImplementedException();
        }
    }
}