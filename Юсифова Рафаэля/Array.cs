using System;
using System.Collections.Generic;

namespace Юсифова_Рафаэля
{
    public class Array<T>
    {
        private T[] _items;
        private int _capacity;
        private readonly int _defaultCapacity = 6;


        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="capacity"></param>
        public Array(int capacity)
        {
            _items = new T[capacity];
            Capacity = capacity;
        }


        public int Length { get; private set; }

        /// <summary>
        /// свойство-индексатор
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T this[int index]
        {
            get { return _items[index]; }
            set { _items[index] = value; }
        }

        /// <summary>
        /// Изменение количества элементов в массиве
        /// </summary>
        public int Capacity
        {
            get => _capacity;
            private set
            {
                if (value == _capacity)
                {
                    return;
                }
                _capacity = value;
                Array.Resize(ref _items, value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="itemsLength"></param>
        /// <returns></returns>
        private int EnsureCapacity(int itemsLength = 0)
        {
            int tempCapacity = Capacity;
            while (itemsLength + Length >= tempCapacity)
            {
                tempCapacity *= 2;
            }
            return tempCapacity;
        }

        /// <summary>
        /// Добавление элементов
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            Capacity = EnsureCapacity();
            _items[Length++] = item;
        }

        /// <summary>
        /// Очистить
        /// </summary>
        public void Clear()
        {
            Capacity = _defaultCapacity;
            Length = 0;
            _items = new T[Capacity];
        }

        /// <summary>
        /// Добавление диапазона
        /// </summary>
        /// <param name="items"></param>
        public void AddRange(T[] items)
        {
            Capacity = EnsureCapacity(items.Length);
            Array.Copy(items, 0, _items, Length, items.Length);
            Length += items.Length;
            Capacity = Length;
        }

        /// <summary>
        /// Удаление
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Remove(T item)
        {
            bool check = false;
            List<T> vs = new List<T>();
            for (int i = 0; i < _items.Length; i++)
            {
                T val = _items[i];
                if (Convert.ToInt32(val) != 0)
                {
                    vs.Add(val);
                    if (vs.Remove(item))
                    {
                        check = true;
                        Length--;
                    }
                }
            }
            Capacity = Length;
            _items = vs.ToArray();
            return check;
        }
    }
}
