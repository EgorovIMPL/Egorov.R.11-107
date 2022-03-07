using System;
namespace Egorov.R._11_107.HomeWork_INF_07._03._2022
{
    public class CustomArrayCollection<T> : ICustomCollection<T>
    {
        private T[] array;

        public CustomArrayCollection() 
        {
            array = new T[0];
        }

        public CustomArrayCollection(T el)
        {
            array = new T[1] { el };
        }

        public CustomArrayCollection(T[] array) 
        {
            this.array = array;
        }

        public void Add(T elem)
        {
            throw new NotImplementedException();
        }

        public void AddRange(T[] elems)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public int Size()
        {
            throw new NotImplementedException();
        }
    }
}