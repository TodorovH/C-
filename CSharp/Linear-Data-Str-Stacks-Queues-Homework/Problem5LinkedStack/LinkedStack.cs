namespace Problem5LinkedStack
{
    using System;

    public class LinkedStack<T>
    {
        private Node<T> firstNode;
        public int Count { get; private set; }

        public void Push(T element)
        {
            this.firstNode = new Node<T>(element, this.firstNode);
            this.Count++;
        }

        public T Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Empty stack!");
            }
            var result = this.firstNode.Value;
            this.firstNode = this.firstNode.NextNode;
            this.Count--;
            return result;
        }

        public T[] ToArray()
        {
            T[] result = new T[this.Count];
            int len = this.Count;
            for (int i = 0; i < len; i++)
            {
                result[i] = this.Pop();
            }

            return result;
        }
    }
}
