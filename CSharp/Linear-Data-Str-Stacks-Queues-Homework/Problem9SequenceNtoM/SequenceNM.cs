using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9SequenceNtoM
{
    class SequenceNM
    {
        static void Main(string[] args)
        {
            int[] nAndM = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = nAndM[0];
            int m = nAndM[1];
            bool haveSolution = false;

            Queue<Number> numbers = new Queue<Number>();

            Number tempN = new Number(n, null);

            numbers.Enqueue(tempN);

            while (numbers.Count > 0)
            {
                Number element = numbers.Dequeue();

                if (element.Value < m)
                {
                    numbers.Enqueue(new Number(element.Value + 1, element));
                    numbers.Enqueue(new Number(element.Value + 2, element));
                    numbers.Enqueue(new Number(element.Value * 2, element));
                }

                if (element.Value == m)
                {
                    element.Print(element);
                    Console.Write(element.Value);

                    haveSolution = true;
                    Console.WriteLine();
                    break;
                }
            }

            if (!haveSolution)
            {
                Console.WriteLine("(no solution)");
            }
        }
    }
}
