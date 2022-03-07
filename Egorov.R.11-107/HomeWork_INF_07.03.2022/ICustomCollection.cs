namespace Egorov.R._11_107.HomeWork_INF_07._03._2022
{
    public interface ICustomCollection<T>
    {
        int Size();
        
        bool isEmpty();
        
        bool Contains(T elem);
        
        void Add(T elem);

        
        void AddRange(T[] elems);

        /// <summary>
        /// Удаление элемента со значением
        /// </summary>
        void Remove(T elem);

        /// <summary>
        /// Удаляет все элементы со значением
        /// </summary>
        void RemoveAll(T elem);

        /// <summary>
        /// Удаление элемента на позиции с номером 
        /// </summary>
        void RemoveAt(int index);

        /// <summary>
        /// Очищение коллекции
        /// </summary>
        void Clear();

        /// <summary>
        /// Переворачивает список
        /// </summary>
        void Reverse();

        /// <summary>
        /// Вставка элемента на конкретную позицию
        /// </summary>
        void Insert(int index, T elem);

        /// <summary>
        /// Возвращает позицию элемента
        /// </summary>
        int IndexOf(T elem);
    }
}