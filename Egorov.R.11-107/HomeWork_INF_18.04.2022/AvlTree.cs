using System;
using System.Collections.Generic;
using System.Linq;

namespace Egorov.R._11_107.HomeWork_INF_18._04._2022
{
    public class AvlNode<T>
    {
        public T Value;
        public int Key;
        public AvlNode<T> LeftChild;
        public AvlNode<T> RightChild;
        public AvlNode(T value, int key)
        {
            Key = key;
            Value = value;
            LeftChild = null;
            RightChild = null;
        }
    }
    public class AvlTree<T>
    {
        private AvlNode<T> root;
        public AvlTree(T value,int key)
        {
            root = new AvlNode<T>(value, key);
        }

        public void Add(T value, int key)
        {
            AvlNode<T> newNode = new AvlNode<T>(value, key);
            root = Recursion(root, newNode);
        }
        public void PrintDepth()
        {
            Queue<AvlNode<T>> queue = new Queue<AvlNode<T>>();
            queue.Enqueue(root);
            while (queue.Count() != 0)
            {
                AvlNode<T> result = queue.Dequeue();
                Console.Write(result.Value + " Key:" + result.Key + " ");
                if (result.LeftChild != null)
                    queue.Enqueue(result.LeftChild);
                if (result.RightChild != null)
                    queue.Enqueue(result.RightChild);
            }
        }
        private AvlNode<T> Recursion(AvlNode<T> r,AvlNode<T> n)
        {
            if (r == null)
            {
                r = n;
                return r;
            }
            else if (r.Key > n.Key)
            {
                r.LeftChild = Recursion(r.LeftChild, n);
                Balance(ref r);
            }
            else if (r.Key < n.Key)
            {
                r.RightChild = Recursion(r.RightChild, n);
                Balance(ref r);
            }
            return r;
        }
        private int GetHeight(AvlNode<T> r)
        {
            int height = 0;
            if(r != null)
            {
                int left = GetHeight(r.LeftChild);
                int right = GetHeight(r.RightChild);
                height = Math.Max(left,right) + 1;
            }

            return height;
        }

        private void Balance(ref AvlNode<T> r)
        {
            int balanceFactor = BalanceFactor(r);
            if (balanceFactor > 1)
            {
                if (BalanceFactor(r.LeftChild) > 0)
                {
                    SmallRightTurn(ref r);
                }
                else
                {
                    BigLeftTurn(ref r);
                }
            }
            else if (balanceFactor < -1)
            {
                if (BalanceFactor(r.RightChild) > 0)
                {
                    BigRightTurn(ref r);
                }
                else
                {
                    SmallLeftTurn(ref r);
                }
            }
        }
        private int BalanceFactor(AvlNode<T> r)
        {
            int left = GetHeight(r.LeftChild);
            int right = GetHeight(r.RightChild);
            return left - right;
        }
        private void SmallLeftTurn(ref AvlNode<T> r) 
        {
            var newRoot = r.RightChild;
            r.RightChild = r.RightChild.LeftChild;
            newRoot.LeftChild = r;
            r = newRoot;
        }
        private void SmallRightTurn(ref AvlNode<T> r)
        {
            var newRoot = r.LeftChild;
            r.LeftChild = r.LeftChild.RightChild;
            newRoot.RightChild = r;
            r = newRoot;
        }
        private void BigLeftTurn(ref AvlNode<T> r)
        {
            SmallRightTurn(ref r.RightChild);
            SmallLeftTurn(ref r);
        }

        private void BigRightTurn(ref AvlNode<T> r)
        {
            SmallLeftTurn(ref r.LeftChild);
            SmallRightTurn(ref r);
        }
    }
}