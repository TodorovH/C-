namespace Problem4RemoveOddOccurences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class RemoveOddOccurences
    {
        static void Main(string[] args)
        {
            try
            {
                Dictionary<int, int> numbers = new Dictionary<int, int>();
                List<int> numbersList = Console.ReadLine()
                                                    .Split(' ')
                                                    .Select(int.Parse)
                                                    .ToList();

                for (int i = 0; i < numbersList.Count; i++)
                {
                    if (numbers.ContainsKey(numbersList.ElementAt(i)))
                    {
                        numbers[numbersList.ElementAt(i)] += 1;
                    }
                    else
                    {
                        numbers.Add(numbersList.ElementAt(i), 1);
                    }
                }

                foreach (var pair in numbers)
                {
                    if (pair.Value % 2 != 0)
                    {
                        while (numbersList.Contains(pair.Key))
                        {
                            numbersList.Remove(pair.Key);
                        }
                    }
                }

                Console.WriteLine(String.Join(" ", numbersList.ToArray()));
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
