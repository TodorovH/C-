namespace Problem3ImplArrayBasedStack
{
    using System;

    public class ArrayBasedStack<T>
    {
        private T[] elements;
        public int Count { get; private set; }
        private const int InitialCapacity = 16;

        public ArrayBasedStack(int capacity = InitialCapacity)
        {
            this.elements = new T[capacity];
            this.Count = 0;
        }

        public void Push(T element)
        {
            if (this.Count == this.elements.Length)
            {
                this.Grow();
            }

            elements[this.Count] = element;
            this.Count++;
        }

        public T Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Empty stack!");
            }

            this.Count--;

            return this.elements[this.Count];
        }

        public T[] ToArray()
        {
            T[] result = new T[this.Count];
            int len = this.Count;
            for (int i = 0; i < len; i++)
            {
                this.Count--;
                result[i] = this.elements[this.Count];
            }
            return result;
        }

        private void Grow()
        {
            T[] newElements = new T[2 * this.elements.Length];
            Array.Copy(this.elements, newElements, this.Count);
            this.elements = newElements;
        }
    }
}
