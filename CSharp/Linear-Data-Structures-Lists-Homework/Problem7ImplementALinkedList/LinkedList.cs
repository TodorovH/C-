namespace Problem7ImplementALinkedList
{
    using System;
    using System.Collections;

    public class LinkedList : IEnumerable
    {
        private ListNode firstElement;
        private int count;

        public LinkedList()
        {
            this.firstElement = null;
            this.count = 0;
        }

        public bool Empty
        {
            get { return this.count == 0; }
        }

        public int Count
        {
            get { return this.count; }
        }

        public object Add(int index, object o)
        {
            if (index < 0 || index > count)
            {
                throw new ArgumentOutOfRangeException("Index: " + index);
            }

            ListNode current = this.firstElement;
            if (this.Empty || index == 0)
            {
                this.firstElement = new ListNode(o, this.firstElement);
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }

                current.Next = new ListNode(o, current.Next);
            }

            count++;

            return o;
        }

        public object Add(object o)
        {
            return this.Add(count, o);
        }

        public object Remove(int index)
        {
            if (index < 0 || index > count - 1)
            {
                throw new ArgumentOutOfRangeException("Index: " + index);
            }

            if (this.Empty)
            {
                return null;
            }

            ListNode current = this.firstElement;

            object result = null;

            if (index == 0)
            {
                result = current.Data;
                this.firstElement = current.Next;
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }

                result = current.Next.Data;
                current.Next = current.Next.Next;
            }

            count--;

            return result;
        }

        public void Clear()
        {
            this.firstElement = null;
            this.count = 0;
        }

        public void FirstIndexOf(object o)
        {
            ListNode current = this.firstElement;
            int result = -1;

            for (int i = 0; i < count; i++)
            {
                if (current.Data.Equals(o))
                {
                    result = i;
                    break;
                }

                current = current.Next;
            }

            Console.WriteLine(result);
        }

        public void LastIndexOf(object o)
        {
            ListNode current = this.firstElement;
            int result = -1;

            for (int i = 0; i < count; i++)
            {
                if (current.Data.Equals(o))
                {
                    result = i;
                }

                current = current.Next;
            }

            Console.WriteLine(result);
        }

        public void Print()
        {
            ListNode current = this.firstElement;
            while (current != null)
            {
                Console.Write("|" + current.Data + "|->");
                current = current.Next;
            }

            Console.WriteLine();
        }

        public IEnumerator GetEnumerator()
        {
            var current = firstElement;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
