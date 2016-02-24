namespace Problem6ImplementDataStructure
{
    using System;
    using System.Collections.Generic;
    using System.Collections;

    public class ReversedList<T> : IReversedList<T>, IEnumerable<T>
    {
        private const int DefaultCapacity = 10;
        private int capacity;
        private int count;
        private T[] array;

        public ReversedList()
        {
            this.array = new T[DefaultCapacity];
            this.capacity = DefaultCapacity;
        }

        public ReversedList(int capacity)
        {
            this.array = new T[capacity];
            this.capacity = capacity;
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public T this[int index]
        {
            get
            {
                if (index > count || index < 0)
                {
                    throw new IndexOutOfRangeException("Invalid index!");
                }

                return this.array[count - index - 1];
            }

            set
            {
                if (index > count || index < 0)
                {
                    throw new IndexOutOfRangeException("Invalid index!");
                }

                this.array[count - index - 1] = value;
            }
        }

        public void Add(T item)
        {
            if (count >= capacity)
            {
                this.GrowingTwice();
            }
            array[count] = item;
            count++;
        }

        public void Remove(int index)
        {
            index = count - index - 1;
            if (index > count || index < 0)
            {
                throw new IndexOutOfRangeException("Invalid index!");
            }
            T[] newArray = new T[capacity];
            Array.Copy(this.array, 0, newArray, 0, index);
            Array.Copy(this.array, index + 1, newArray, index, this.array.Length - (index + 1));
            count--;
            this.array = newArray;
        }

        public void GrowingTwice()
        {
            T[] twiceBiggerList = new T[capacity * 2];
            Array.Copy(this.array, twiceBiggerList, count);
            this.capacity += capacity;
            this.array = twiceBiggerList;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (var i = 0; i < this.count; i++)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
