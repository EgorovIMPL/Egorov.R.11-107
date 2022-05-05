using System;
using System.Collections.Generic;
using System.Linq;
using Egorov.R._11_107.HomeWork_INF_04._04._2022;

namespace Egorov.R._11_107.ControlWork_05._05._2022
{
    public class Tree<T>
    {
        private BinaryTreeNode<T> root;
        
        public Tree(T value, int key)
        {
            root = new BinaryTreeNode<T>(value, key);
            root.Position = 1;
        }

        public void Add(T value, int key)
        {
            if (root == null)
                root = new BinaryTreeNode<T>(value, key);
            else
            {
                var rootCopy = root;
                while (true)
                {
                    if (key < rootCopy.Key)
                    {
                        if (rootCopy.LeftChild == null)
                        {
                            rootCopy.Parent = rootCopy;
                            rootCopy.LeftChild = new BinaryTreeNode<T>(value, key, rootCopy);
                            rootCopy.LeftChild.Position = rootCopy.Position * 2;
                            return;
                        }
                        else
                            rootCopy = rootCopy.LeftChild;
                    }
                    else
                    {
                        if (rootCopy.RightChild == null)
                        {
                            rootCopy.Parent = rootCopy;
                            rootCopy.RightChild = new BinaryTreeNode<T>(value, key, rootCopy);
                            rootCopy.RightChild.Position = rootCopy.Position * 2 + 1;
                            return;
                        }
                        else
                            rootCopy = rootCopy.RightChild;
                    }
                }
            }
        }

        public void PrintDepth()
        {
            Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();
            queue.Enqueue(root);
            ConsoleColor[] colors = (ConsoleColor[]) ConsoleColor.GetValues(typeof(ConsoleColor));
            while (queue.Count() != 0)
            {
                BinaryTreeNode<T> result = queue.Dequeue();
                int colorNumber = GetHeight(result);
                while (colorNumber >= 16)
                    colorNumber -= 16;
                Console.ForegroundColor = colors[colorNumber];
                Console.Write(result.Value + " ");
                Console.ResetColor();
                if (result.LeftChild != null)
                    queue.Enqueue(result.LeftChild);
                if (result.RightChild != null)
                    queue.Enqueue(result.RightChild);
            }
        }

        public int ListNumber()
        {
            Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();
            queue.Enqueue(root);
            int count = 0;
            while (queue.Count() != 0)
            {
                BinaryTreeNode<T> result = queue.Dequeue();
                if (result.LeftChild == null && result.RightChild == null)
                    count += 1;
                if (result.LeftChild != null)
                    queue.Enqueue(result.LeftChild);
                if (result.RightChild != null)
                    queue.Enqueue(result.RightChild);
            }
            return count;
        }

        public List<BinaryTreeNode<T>> RootsHeightN(int height)
        {
            Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();
            queue.Enqueue(root);
            List<BinaryTreeNode<T>> list = new List<BinaryTreeNode<T>>();
            while (queue.Count() != 0)
            {
                BinaryTreeNode<T> result = queue.Dequeue();
                if (GetHeight(result) == height)
                    list.Add(result);
                if (result.LeftChild != null)
                    queue.Enqueue(result.LeftChild);
                if (result.RightChild != null)
                    queue.Enqueue(result.RightChild);
            }

            return list;
        }
        private int GetHeight(BinaryTreeNode<T> r)
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
    }
}