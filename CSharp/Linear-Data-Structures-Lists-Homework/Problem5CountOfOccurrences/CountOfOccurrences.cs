namespace Problem5CountOfOccurences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class CountOfOccurrences
    {
        private static List<int> numbers;
        private static bool isInRange;

        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (!String.IsNullOrWhiteSpace(input))
            {
                try
                {
                    numbers = input.Split().Select(int.Parse).ToList();

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        int number = numbers[i];

                        if (Enumerable.Range(0, 1001).Contains(number))
                        {
                            isInRange = true;
                        }
                        else
                        {
                            isInRange = false;
                            break;
                        }
                    }

                    if (isInRange == true)
                    {
                        var numbersOccurance = numbers.GroupBy(x => x)
                            .ToDictionary(g => g.Key, g => g.Count())
                            .OrderBy(g => g.Key);

                        foreach (var number in numbersOccurance)
                        {
                            Console.WriteLine("{0} -> {1} times",
                                number.Key,
                                number.Value);
                        }
                    }
                    else
                    {
                        Console.WriteLine("The numbers should be between 0 and 1000!");
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            else
            {
                Console.WriteLine("The input cannot be empty!");
            }
        }
    }
}
