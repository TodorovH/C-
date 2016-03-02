namespace Problem2CalcSeqWithQueue
{
    using System;
    using System.Collections.Generic;

    class CalculateSequenceWithQueue
    {
        static void Main(string[] args)
        {
            int count = 0;
            int N = int.Parse(Console.ReadLine());
            Queue<int> numbers = new Queue<int>();
            numbers.Enqueue(N);
            while (count < 50)
            {
                int tempNumber = numbers.Dequeue();

                numbers.Enqueue(tempNumber + 1);
                numbers.Enqueue(2 * tempNumber + 1);
                numbers.Enqueue(tempNumber + 2);

                count++;
                Console.Write(tempNumber + " ");
            }
            Console.WriteLine();
        }
    }
}
