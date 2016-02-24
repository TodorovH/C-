namespace LinearDataStructuresListsHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SumAndAverage
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numbers = Console.ReadLine()
                                        .Split(' ')
                                        .Select(int.Parse)
                                        .ToList();

                Console.WriteLine(String.Format("Sum={0}; Average={1}",
                numbers.Sum(), numbers.Average()));
            }
            catch (Exception e)
            {
                Console.WriteLine("Sum=0; Average=0");
            }
        }
    }
}
