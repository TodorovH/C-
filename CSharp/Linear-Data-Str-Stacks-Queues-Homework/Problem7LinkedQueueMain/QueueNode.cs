namespace Problem7LinkedQueueMain
{
    class QueueNode<T>
    {
        public T Value { get; private set; }
        public QueueNode<T> NextNode { get; set; }
        public QueueNode<T> PrevNode { get; set; }

        public QueueNode(T value)
        {
            this.Value = value;
        }
    }
}
