namespace Problem7LinkedQueueMain
{
    using System;

    public class LinkedQueue<T>
    {
        private QueueNode<T> head;
        private QueueNode<T> tail;
        public int Count { get; private set; }

        public void Enqueue(T element)
        {
            if (this.Count == 0)
            {
                this.head = this.tail = new QueueNode<T>(element);
            }
            else
            {
                var newTail = new QueueNode<T>(element);
                newTail.PrevNode = this.tail;
                this.tail.NextNode = newTail;
                this.tail = newTail;
            }
            this.Count++;
        }

        public T Dequeue()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Empty list");
            }

            var firstElement = this.head.Value;
            this.head = this.head.NextNode;

            if (this.head != null)
            {
                this.head.PrevNode = null;
            }
            else
            {
                this.tail = null;
            }

            this.Count--;
            return firstElement;
        }

        public T[] ToArray()
        {
            var arr = new T[this.Count];
            int count = 0;
            var currentNode = this.head;
            while (currentNode != null)
            {
                arr[count++] = currentNode.Value;
                currentNode = currentNode.NextNode;
            }

            return arr;
        }
    }
}
