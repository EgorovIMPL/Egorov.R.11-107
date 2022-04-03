using System;
using System.Collections.Generic;
using System.Linq;

namespace Egorov.R._11_107.HomeWork_INF_04._04._2022
{
    public class BinaryTreeNode<T>
    {
        public T Value;
        public int Key;
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
        private BinaryTreeNode<T> root;

        public BinarySearchTree(T value, int key)
        {
            root = new BinaryTreeNode<T>(value,key);
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
                    if (key == rootCopy.Key)
                    {
                        rootCopy.Value = value;
                        return;
                    }
                    else if(key < rootCopy.Key)
                    {
                        if (rootCopy.LeftChild == null)
                        {
                            rootCopy.LeftChild = new BinaryTreeNode<T>(value, key, rootCopy);
                            return;
                        }
                        else
                            rootCopy = rootCopy.LeftChild;
                    }
                    else
                    {
                        if (rootCopy.RightChild == null)
                        {
                            rootCopy.RightChild = new BinaryTreeNode<T>(value, key, rootCopy);
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
            BinaryTreeNode<T> rootCopy = root;
            while (true)
            {
                if (rootCopy.Key == p)
                {
                    return rootCopy.Parent.Value;
                }
                else if (rootCopy.Key > p)
                    rootCopy = rootCopy.LeftChild;
                else
                    rootCopy = rootCopy.RightChild;
            }
        }

        /// <summary>
        /// возвращает значение «самого левого сына» для вершины в позиции p.
        /// изначально надо было вернуть позицию
        /// </summary>
        public T LeftMostChild(int p)
        {
            BinaryTreeNode<T> rootCopy = root;
            while (true)
            {
                if (rootCopy.Key == p)
                {
                    return rootCopy.LeftChild.Value;
                }
                else if (rootCopy.Key > p)
                    rootCopy = rootCopy.LeftChild;
                else
                    rootCopy = rootCopy.RightChild;
            }
        }

        /// <summary>
        /// возвращает значение «правого брата» для вершины в позиции p.
        /// изначально надо было вернуть позицию
        /// </summary>
        public T RightSibling(int p)
        {
            BinaryTreeNode<T> rootCopy = root;
            while (true)
            {
                if (rootCopy.Key == p)
                {
                    return rootCopy.RightChild.Value;
                }
                else if (rootCopy.Key > p)
                    rootCopy = rootCopy.LeftChild;
                else
                    rootCopy = rootCopy.RightChild;
            }
        }

        /// <summary>
        /// возвращает элемент дерева (хранимую информацию) для вершины в позиции p.
        /// </summary>
        public T Element(int p)
        {
            BinaryTreeNode<T> rootCopy = root;
            while (true)
            {
                if (rootCopy.Key == p)
                {
                    return rootCopy.Value;
                }
                else if (rootCopy.Key > p)
                    rootCopy = rootCopy.LeftChild;
                else
                    rootCopy = rootCopy.RightChild;
            }
        }

        /// <summary>
        /// проверяет, является ли p позицией внутренней вершины (не листа)
        /// </summary>
        public bool IsInternal(int p)
        {
            BinaryTreeNode<T> rootCopy = root;
            while (true)
            {
                if (rootCopy.Key == p)
                {
                    return (rootCopy.LeftChild != null || rootCopy.RightChild != null);
                }
                else if (rootCopy.Key > p)
                    rootCopy = rootCopy.LeftChild;
                else
                    rootCopy = rootCopy.RightChild;
            }
        }

        /// <summary>
        /// проверяет, является ли p позицией листа дерева.
        /// </summary>
        public bool IsExternal(int p)
        {
            BinaryTreeNode<T> rootCopy = root;
            while (true)
            {
                if (rootCopy.Key == p)
                {
                    return (rootCopy.LeftChild == null && rootCopy.RightChild == null);
                }
                else if (rootCopy.Key > p)
                    rootCopy = rootCopy.LeftChild;
                else
                    rootCopy = rootCopy.RightChild;
            }
        }

        /// <summary>
        /// проверяет, является ли p позицией корня.
        /// </summary>
        public bool IsRoot(int p)
        {
            return true;
        }

        /// <summary>
        /// проверяет, является ли key ключом корневого узла.
        /// </summary>
        public bool IsRootByKey(int key)
        {
            return true;
        }

        /// <summary>
        /// Поиск элемента в дереве
        /// </summary>
        public bool Find(int key)
        {
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// удаление узла, в котором хранится значение
        /// </summary>
        public void Remove(int key)
        {
            if (root.Key == key)
            {
                root = null;
                return;
            }
            BinaryTreeNode<T> rootCopy = root;
            while (true)
            {
                if (rootCopy.LeftChild.Key == key)
                {
                    rootCopy.LeftChild = null;
                    return;
                }
                else if (rootCopy.RightChild.Key == key)
                {
                    rootCopy.LeftChild = null;
                    return;
                }
                else if (rootCopy.Key > key)
                    rootCopy = rootCopy.LeftChild;
                else
                    rootCopy = rootCopy.RightChild;
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
        }


        /// <summary>
        /// Вывод в глубину Симметричный или поперечный (in-order)
        /// Обойти левое поддерево
        /// Посетить корень
        /// Обойти правое поддерево
        /// </summary>
        public void InOrderPrint()
        {
        }


        /// <summary>
        /// Вывод в глубину В обратном порядке (post-order)
        /// Обойти левое поддерево
        /// Обойти правое поддерево
        /// Посетить корень
        /// </summary>
        public void PostOrderPrint()
        {
        }

        /// <summary>
        /// Вывод в ширину
        /// </summary>
        public void PrintDepth()
        {
        }

        /// <summary>
        /// Сбалансировать дерево *
        /// </summary>
        public void Balance() 
        { 
        }

   

    }
}