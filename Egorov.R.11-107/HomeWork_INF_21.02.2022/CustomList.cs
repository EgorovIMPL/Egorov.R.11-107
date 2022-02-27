using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Egorov.R._11_107.HomeWork_INF_21._02._2022
{
    public class Node
    {
        public int InfField;
        public Node NextNode;
        public Node(int a) 
        {
            InfField = a;
        }
    }
    public class CustomList
    {
        private Node head;

        public CustomList() { }

        public CustomList(int a)
        {
            head = new Node(a);
        }
        
        public void Add(int a)
        {
            var newNode = new Node(a);
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
        
        public void AddToHead(int a) 
        {
            var newNode = new Node(a);
            newNode.NextNode = head;
            head = newNode;
        }
        
        public void Add(int a, int position)
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
            var newNode = new Node(a);
            if (headCopy.NextNode != null)
                newNode.NextNode = headCopy.NextNode;
            headCopy.NextNode = newNode;
        }
        
        public void DelHead()
        {
            if (head == null)
                throw new Exception("Список пуст");
            head = head.NextNode;
        }
        
        public void DelLastEl()
        {
            Node headCopy = head;
            if (head == null)
                throw new Exception("Список пуст");
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
            Node headCopy = head;
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
        
        public void DelFirstK(int k)
        {
            if (head == null)
                throw new Exception("Список пуст");
            if (head.InfField == k)
                DelHead();
            else
            {
                Node headCopy = head;
                while (headCopy.NextNode != null)
                {
                    if (headCopy.NextNode.InfField == k)
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
            if (head == null)
                throw new Exception("Список пуст");
            if (head.InfField == k)
                DelHead();
            Node headCopy = head;
            while (headCopy.NextNode != null)
            {
                if (headCopy.NextNode.InfField == k)
                {
                    headCopy.NextNode = headCopy.NextNode.NextNode;
                }
                else
                    headCopy = headCopy.NextNode;
            }
        }

        public void AddBeforeAndAfterK(int k, int m)
        {
            if (head == null)
                throw new Exception("Список пуст");
            if (head.InfField == k)
            {
                Node newNode = new Node(m);
                newNode.NextNode = head.NextNode;
                head.NextNode = newNode;
                AddToHead(m);
            }
            else
            {
                Node headCopy = head;
                while (headCopy.NextNode != null)
                {
                    if(headCopy.NextNode.InfField == k)
                    {
                        Node newNode = new Node(m);
                        newNode.NextNode = headCopy.NextNode.NextNode;
                        headCopy.NextNode.NextNode = newNode;
                        Node newNode1 = new Node(m);
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
            Node headCopy = head;
            if (head == null)
                throw new ArgumentOutOfRangeException("Список пуст");
            int maxValue = head.InfField;
            while (headCopy.NextNode != null)
            {
                headCopy = headCopy.NextNode;
                if (headCopy.InfField > maxValue)
                    maxValue = headCopy.InfField;
            }
            return maxValue;
        }
        
        public int SumElements()
        {
            Node headCopy = head;
            if (headCopy == null)
                throw new ArgumentOutOfRangeException("Список пуст");
            int sum = head.InfField;
            while (headCopy.NextNode != null)
            {
                headCopy = headCopy.NextNode;
                sum += headCopy.InfField;
            }
            return sum;
        }
        
        public bool CheckNegativeValue()
        {
            Node headCopy = head;
            if (headCopy == null)
                throw new ArgumentOutOfRangeException("Список пуст");
            while (headCopy != null)
            {
                if (headCopy.InfField < 0)
                    return true;
                headCopy = headCopy.NextNode;
            }
            return false;
        }

        public void Swap()
        {
            Node headCopy = head;
            int i = 1;
            while (headCopy != null && headCopy.NextNode != null)
            {
                Add(headCopy.NextNode.InfField,i);
                i += 2;
                headCopy.NextNode = headCopy.NextNode.NextNode;
                headCopy = headCopy.NextNode;
            }
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
}