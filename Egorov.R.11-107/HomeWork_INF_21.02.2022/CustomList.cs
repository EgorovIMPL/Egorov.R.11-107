using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Egorov.R._11_107.HomeWork_INF_21._02._2022
{
    public class Node<T>
    {
        public T InfField;
        public Node<T> NextNode;
        public Node(T a) 
        {
            InfField = a;
        }
    }

    public class CustomList<T>
    {
        private Node<T> head;

        public CustomList()
        {
        }

        public CustomList(T a)
        {
            head = new Node<T>(a);
        }

        public void Add(T a)
        {
            var newNode = new Node<T>(a);
            if (head == null)
            {
                head = newNode;
                return;
            }

            var headCopy = head;
            while (headCopy.NextNode != null)
                headCopy = headCopy.NextNode;
            headCopy.NextNode = newNode;
        }

        public void AddToHead(T a)
        {
            var newNode = new Node<T>(a);
            newNode.NextNode = head;
            head = newNode;
        }

        public void Add(T a, int position)
        {
            if (position == 1)
            {
                AddToHead(a);
                return;
            }

            var headCopy = head;
            for (int i = 1; i <= position - 2; i++)
            {
                if (head == null)
                    throw new ArgumentOutOfRangeException("Список недостаточной длины");
                headCopy = headCopy.NextNode;
            }

            var newNode = new Node<T>(a);
            if (headCopy.NextNode != null)
                newNode.NextNode = headCopy.NextNode;
            headCopy.NextNode = newNode;
        }

        public void AddRange(T[] array)
        {
            if (head == null)
                throw new Exception("Список пуст");
            Node<T> headCopy = head;
            while (headCopy.NextNode != null)
                headCopy = headCopy.NextNode;
            foreach (var el in array)
            {
                Node<T> newNode = new Node<T>(el);
                headCopy.NextNode = newNode;
                headCopy = headCopy.NextNode;
            }
        }

        public void DelHead()
        {
            if (head == null)
                throw new Exception("Список пуст");
            head = head.NextNode;
        }

        public void DelLastEl()
        {
            if (head == null)
                throw new Exception("Список пуст");
            Node<T> headCopy = head;
            if (head.NextNode == null)
                head = null;
            while (headCopy.NextNode != null)
            {
                if (headCopy.NextNode.NextNode == null)
                    headCopy.NextNode = null;
                else
                    headCopy = headCopy.NextNode;
            }
        }

        public void DelPenultEl()
        {
            if (head == null)
                throw new Exception("Список пуст");
            if (head.NextNode == null)
                throw new Exception("Список длины 1");
            Node<T> headCopy = head;
            while (headCopy.NextNode != null)
            {
                if (headCopy.NextNode.NextNode != null && headCopy.NextNode.NextNode.NextNode == null)
                    headCopy.NextNode = headCopy.NextNode.NextNode;
                else
                    headCopy = headCopy.NextNode;
            }
        }

        public void DelFirstK(int k)
        {
            if (Num.IsNum(head.InfField.ToString()) != true)
                throw new Exception("Не подходящий формат");
            if (head == null)
                    throw new Exception("Список пуст");
            if ((Convert.ToInt32(head.InfField) == k))
                DelHead();
            else
            {
                Node<T> headCopy = head; 
                while (headCopy.NextNode != null)
                {
                    if (Convert.ToInt32(headCopy.NextNode.InfField) == k)
                    {
                        headCopy.NextNode = headCopy.NextNode.NextNode;
                        break;
                    }
                    else
                        headCopy = headCopy.NextNode;
                }
            }
        }

        public void DelK(int k)
        {
            if (Num.IsNum(head.InfField.ToString()) != true)
                throw new Exception("Не подходящий формат");
            if (head == null)
                throw new Exception("Список пуст");
            if (Convert.ToInt32(head.InfField) == k)
                DelHead();
            Node<T> headCopy = head;
            while (headCopy.NextNode != null)
            {
                if (Convert.ToInt32(headCopy.NextNode.InfField) == k)
                {
                    headCopy.NextNode = headCopy.NextNode.NextNode;
                }
                else
                    headCopy = headCopy.NextNode;
            }
        }

        public void AddBeforeAndAfterK(int k, T m)
        {
            if (Num.IsNum(head.InfField.ToString()) != true)
                throw new Exception("Не подходящий формат");
            if (head == null)
                throw new Exception("Список пуст");
            if (Convert.ToInt32(head.InfField) == k)
            {
                Node<T> newNode = new Node<T>(m);
                newNode.NextNode = head.NextNode;
                head.NextNode = newNode;
                AddToHead(m);
            }
            else
            {
                Node<T> headCopy = head;
                while (headCopy.NextNode != null)
                {
                    if (Convert.ToInt32(headCopy.NextNode.InfField) == k)
                    {
                        Node<T> newNode = new Node<T>(m);
                        newNode.NextNode = headCopy.NextNode.NextNode;
                        headCopy.NextNode.NextNode = newNode;
                        Node<T> newNode1 = new Node<T>(m);
                        newNode1.NextNode = headCopy.NextNode;
                        headCopy.NextNode = newNode1;
                        break;
                    }
                    else
                        headCopy = headCopy.NextNode;
                }
            }
        }

        public int Max()
        {
            if (Num.IsNum(head.InfField.ToString()) != true)
                throw new Exception("Не подходящий формат");
            if (head == null)
                throw new ArgumentOutOfRangeException("Список пуст");
            Node<T> headCopy = head;
            int maxValue = Convert.ToInt32(head.InfField);
            while (headCopy.NextNode != null)
            {
                headCopy = headCopy.NextNode;
                if (Convert.ToInt32(headCopy.InfField) > maxValue)
                    maxValue = Convert.ToInt32(headCopy.InfField);
            }

            return maxValue;
        }

        public int SumElements()
        {
            if (head == null)
                throw new ArgumentOutOfRangeException("Список пуст");
            if (Num.IsNum(head.InfField.ToString()) != true)
                throw new Exception("Не подходящий формат");
            Node<T> headCopy = head;
            int sum = Convert.ToInt32(head.InfField);
            while (headCopy.NextNode != null)
            {
                headCopy = headCopy.NextNode;
                sum += Convert.ToInt32(headCopy.InfField);
            }

            return sum;
        }

        public bool CheckNegativeValue()
        {
            if (head == null)
                throw new ArgumentOutOfRangeException("Список пуст");
            if (Num.IsNum(head.InfField.ToString()) != true)
                throw new Exception("Не подходящий формат");
            Node<T> headCopy = head;
            while (headCopy != null)
            {
                if (Convert.ToInt32(headCopy.InfField) < 0)
                    return true;
                headCopy = headCopy.NextNode;
            }

            return false;
        }

        public void Swap()
        {
            if (head == null)
                throw new ArgumentOutOfRangeException("Список пуст");
            Node<T> headCopy = head;
            int i = 1;
            while (headCopy != null && headCopy.NextNode != null)
            {
                Add(headCopy.NextNode.InfField, i);
                i += 2;
                headCopy.NextNode = headCopy.NextNode.NextNode;
                headCopy = headCopy.NextNode;
            }
        }
        public void SwapSecondVersion()
        {
            if (head == null)
                throw new ArgumentOutOfRangeException("Список пуст");
            Node<T> headCopy = head;
            int count = 2;
            Node<T> newNode = head.NextNode;
            head.NextNode = head.NextNode.NextNode;
            newNode.NextNode = head;
            head = newNode;
            headCopy = head;
            while (headCopy.NextNode != null && headCopy.NextNode.NextNode != null)
            {
                if(count % 2 == 0 )
                {
                    newNode = headCopy.NextNode;
                    headCopy.NextNode = newNode.NextNode;
                    newNode.NextNode = headCopy.NextNode.NextNode;
                    headCopy.NextNode.NextNode = newNode;
                }
                count++;
                headCopy = headCopy.NextNode;
            }
        }

        public void Reverse()
        {
            Node<T> headCopy = head.NextNode;
            Node<T> reverse = new Node<T>(head.InfField);
            while (headCopy != null)
            {
                Node<T> reverseCopy = new Node<T>(headCopy.InfField);
                reverseCopy.NextNode = reverse;
                reverse = reverseCopy;
                headCopy = headCopy.NextNode;
            }
            head = reverse;
        }
        
        public override string ToString()
        {
            var headCopy = head;
            StringBuilder result = new StringBuilder();
            if (head == null)
            {
                return "Список пуст";
            }
            while (headCopy != null)
            {
                result.Append(headCopy.InfField.ToString() + " ");
                headCopy = headCopy.NextNode;
            }
            return result.ToString();
        }
        public void WriteToConsole() 
        {
            Console.WriteLine(ToString());
        }
    }
    public static class Num
    {
        public static bool IsNum(this string str)
        {
            try
            {
                var num = Int32.Parse(str);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}