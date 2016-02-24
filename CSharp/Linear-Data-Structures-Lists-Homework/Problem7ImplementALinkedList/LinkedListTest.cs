namespace Problem7ImplementALinkedList
{
    using System;

    class LinkedListTest
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            list.Add(5);
            list.Add(11);
            list.Add(7);

            list.Print();

            list.Add(1, 90);

            list.Print();

            list.Remove(0);

            list.Print();

            list.Remove(1);

            list.Print();

            list.Add(0, 5);
            list.Add(17);
            list.Add(1);
            list.Add(5);

            list.Print();

            list.FirstIndexOf(5);
            list.LastIndexOf(5);

            list.Clear();

            list.Print();

            Console.WriteLine("Is it Empty?: " + list.Empty);
            Console.WriteLine("Count = " + list.Count);
        }
    }
}

