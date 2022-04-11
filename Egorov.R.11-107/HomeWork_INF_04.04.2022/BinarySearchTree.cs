using System;
using System.Collections.Generic;
using System.Linq;

namespace Egorov.R._11_107.HomeWork_INF_04._04._2022
{
    public class BinaryTreeNode<T>
    {
        public T Value;
        public int Key;
        public int Position;
        public BinaryTreeNode<T> LeftChild;
        public BinaryTreeNode<T> RightChild;
        public BinaryTreeNode<T> Parent;

        public BinaryTreeNode(T value,int  key, BinaryTreeNode<T> parent = null)
        {
            Parent = parent;
            Value = value;
            Key = key ;
        }

        public BinaryTreeNode(T value, int key,BinaryTreeNode<T> leftChild,
            BinaryTreeNode<T> rightChild, BinaryTreeNode<T> parent = null)
        {
            Value = value;
            Key = key;
            Parent = parent;
            RightChild = rightChild;    
            LeftChild = leftChild;
        }
    }
     public class BinarySearchTree<T>
    {
        public BinaryTreeNode<T> root;
        public BinarySearchTree(T value, int key)
        {
            root = new BinaryTreeNode<T>(value,key);
            root.Position = 1;
        }
        /// <summary>
        /// возвращает значение корня дерева
        /// </summary>
        public T Root()
        {
            return root.Value;
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
                    if(key < rootCopy.Key)
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
        /// <summary>
        /// возвращает значение «родителя» для вершины в позиции p
        /// </summary>
        public T Parent(int p)
        {
            Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();
            queue.Enqueue(root);
            if (root.LeftChild == null && root.RightChild == null)
                throw new Exception("Дерево имеет только корень дерева");
            while (queue.Count() != 0)
            {
                BinaryTreeNode<T> result = queue.Dequeue();
                if (result.Position == p)
                    return result.Parent.Value;
                if (result.LeftChild != null)
                    queue.Enqueue(result.LeftChild);
                if (result.RightChild != null)
                    queue.Enqueue(result.RightChild);
            }
            Console.WriteLine("Узла с такой поизицией нет, вывод значения корневого узла:");
            return root.Value;
        }

        /// <summary>
        /// возвращает значение «самого левого сына» для вершины в позиции p.
        /// изначально надо было вернуть позицию
        /// </summary>
        public T LeftMostChild(int p)
        {
            Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();
            queue.Enqueue(root);
            if (root.LeftChild == null && root.RightChild == null)
                throw new Exception("Дерево имеет только корень дерева");
            while (queue.Count() != 0)
            {
                BinaryTreeNode<T> result = queue.Dequeue();
                if (result.Position == p && result.LeftChild != null)
                    return result.LeftChild.Value;
                if (result.LeftChild != null)
                    queue.Enqueue(result.LeftChild);
                if (result.RightChild != null)
                    queue.Enqueue(result.RightChild);
            }
            Console.WriteLine("Узла с такой поизицией нет или узел с данной позицией не имеет левый листочек, вывод значения корневого узла:");
            return root.Value;
        }

        /// <summary>
        /// возвращает значение «правого брата» для вершины в позиции p.
        /// изначально надо было вернуть позицию
        /// </summary>
        public T RightSibling(int p)
        {
            Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();
            queue.Enqueue(root);
            if (root.LeftChild == null && root.RightChild == null)
                throw new Exception("Дерево имеет только корень дерева");
            while (queue.Count() != 0)
            {
                BinaryTreeNode<T> result = queue.Dequeue();
                if (result.Position == p && result.RightChild != null)
                    return result.RightChild.Value;
                if (result.LeftChild != null)
                    queue.Enqueue(result.LeftChild);
                if (result.RightChild != null)
                    queue.Enqueue(result.RightChild);
            }
            Console.WriteLine("Узла с такой поизицией нет или узел с данной позицией не имеет правый листочек, вывод значения корневого узла:");
            return root.Value;
        }

        /// <summary>
        /// возвращает элемент дерева (хранимую информацию) для вершины в позиции p.
        /// </summary>
        public T Element(int p)
        {
            Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();
            queue.Enqueue(root);
            if (root.LeftChild == null && root.RightChild == null)
                throw new Exception("Дерево имеет только корень дерева");
            while (queue.Count() != 0)
            {
                BinaryTreeNode<T> result = queue.Dequeue();
                if (result.Position == p)
                    return result.Value;
                if (result.LeftChild != null)
                    queue.Enqueue(result.LeftChild);
                if (result.RightChild != null)
                    queue.Enqueue(result.RightChild);
            }
            Console.WriteLine("Узла с такой поизицией нет, вывод значения корневого узла:");
            return root.Value;
        }

        /// <summary>
        /// проверяет, является ли p позицией внутренней вершины (не листа)
        /// </summary>
        public bool IsInternal(int p)
        {
            Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();
            queue.Enqueue(root);
            if (root.LeftChild == null && root.RightChild == null)
                throw new Exception("Дерево имеет только корень дерева");
            while (queue.Count() != 0)
            {
                BinaryTreeNode<T> result = queue.Dequeue();
                if (result.Position == p)
                    return (result.LeftChild != null || result.RightChild != null);
                if (result.LeftChild != null)
                    queue.Enqueue(result.LeftChild);
                if (result.RightChild != null)
                    queue.Enqueue(result.RightChild);
            }
            return false;
        }

        /// <summary>
        /// проверяет, является ли p позицией листа дерева.
        /// </summary>
        public bool IsExternal(int p)
        {
            Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();
            queue.Enqueue(root);
            if (root.LeftChild == null && root.RightChild == null)
                throw new Exception("Дерево имеет только корень дерева");
            while (queue.Count() != 0)
            {
                BinaryTreeNode<T> result = queue.Dequeue();
                if (result.Position == p)
                    return (result.LeftChild == null && result.RightChild == null);
                if (result.LeftChild != null)
                    queue.Enqueue(result.LeftChild);
                if (result.RightChild != null)
                    queue.Enqueue(result.RightChild);
            }
            return false;
        }

        /// <summary>
        /// проверяет, является ли p позицией корня.
        /// </summary>
        public bool IsRoot(int p)
        {
            return root.Position == p;
        }

        /// <summary>
        /// проверяет, является ли key ключом корневого узла.
        /// </summary>
        public bool IsRootByKey(int key)
        {
            return root.Key == key;
        }

        /// <summary>
        /// Поиск элемента в дереве
        /// </summary>
        public bool Find(int key)
        {
            BinaryTreeNode<T> rootCopy = root;
            while (true)
            {
                if (rootCopy.Key == key)
                    return true;
                else if (rootCopy.Key > key)
                    rootCopy = rootCopy.LeftChild;
                else
                    rootCopy = rootCopy.RightChild;
            }
        }
        
        /// <summary>
        /// удаление узла, в котором хранится значение
        /// </summary>
        public void Remove(int key)
        {
            Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();
            queue.Enqueue(root);
            BinaryTreeNode<T>[] nodes = new BinaryTreeNode<T>[0];
            while (queue.Count() != 0)
            {
                BinaryTreeNode<T> result = queue.Dequeue();
                if (result.Key != key)
                    nodes = nodes.Append(new BinaryTreeNode<T>(result.Value,result.Key)).ToArray();
                if (result.LeftChild != null)
                    queue.Enqueue(result.LeftChild);
                if (result.RightChild != null)
                    queue.Enqueue(result.RightChild);
            }
            root = nodes[0];
            for (int i = 1; i < nodes.Length; i++)
            {
                Add(nodes[i].Value,nodes[i].Key);
            }
        }

        //https://learnc.info/adt/binary_tree_traversal.html вывод деревьев

        /// <summary>
        /// Вывод в глубину прямой
        /// Прямой (pre-order)        
        /// Посетить корень    
        /// Обойти левое поддерево    
        /// Обойти правое поддерево
        /// </summary>
        public void PreOrderPrint()
        {
            PreOrderPrint(root);
        }
        private void PreOrderPrint(BinaryTreeNode<T> root1)
        {
            if(root1 == null)
                return;
            Console.Write(root1.Value + " ");
            if(root1.LeftChild != null)
                PreOrderPrint(root1.LeftChild);
            if(root1.RightChild != null)
                PreOrderPrint(root1.RightChild);
        }


        /// <summary>
        /// Вывод в глубину Симметричный или поперечный (in-order)
        /// Обойти левое поддерево
        /// Посетить корень
        /// Обойти правое поддерево
        /// </summary>
        public void InOrderPrint()
        {
            InOrderPrint(root);
        }
        private void InOrderPrint(BinaryTreeNode<T> root1)
        {
            if(root1 == null)
                return;
            if(root1.LeftChild != null)
                InOrderPrint(root1.LeftChild);
            Console.Write(root1.Value + " ");
            if(root1.RightChild != null)
                InOrderPrint(root1.RightChild);
        }


        /// <summary>
        /// Вывод в глубину В обратном порядке (post-order)
        /// Обойти левое поддерево
        /// Обойти правое поддерево
        /// Посетить корень
        /// </summary>
        public void PostOrderPrint()
        {
            PostOrderPrint(root);
        }
        private void PostOrderPrint(BinaryTreeNode<T> root1)
        {
            if(root1 == null)
                return;
            if(root1.LeftChild != null)
                PostOrderPrint(root1.LeftChild);
            if(root1.RightChild != null)
                PostOrderPrint(root1.RightChild);
            Console.Write(root1.Value + " ");
        }

        /// <summary>
        /// Вывод в ширину
        /// </summary>
        public void PrintDepth()
        {
            Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();
            queue.Enqueue(root);
            while (queue.Count() != 0)
            {
                BinaryTreeNode<T> result = queue.Dequeue();
                Console.Write(result.Value + " ");
                if (result.LeftChild != null)
                    queue.Enqueue(result.LeftChild);
                if (result.RightChild != null)
                    queue.Enqueue(result.RightChild);
            }
        }

        /// <summary>
        /// Сбалансировать дерево *
        /// </summary>
        public void Balance() 
        {
        }
        public void SmallLeftTurn(ref BinaryTreeNode<T> r)
        {
            var newRoot = r.RightChild;
            r.RightChild = r.RightChild.LeftChild;
            newRoot.LeftChild = r;
            r = newRoot;
        }
        public void SmallRightTurn(ref BinaryTreeNode<T> r)
        {
            var newRoot = r.LeftChild;
            r.LeftChild = r.LeftChild.RightChild;
            newRoot.RightChild = r;
            r = newRoot;
        }

        public void BigLeftTurn(ref BinaryTreeNode<T> r)
        {
        }
    }
}