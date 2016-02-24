namespace Problem3LongestSubsequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class LongestSubsequence
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numbers = Console.ReadLine()
                                         .Split(' ')
                                         .Select(int.Parse)
                                         .ToList();

                List<int> longestSubsequence = FindsTheLongestSubsequenceOfEqualNumbers(numbers);

                string output = string.Join(" ", longestSubsequence.ToArray());
                Console.WriteLine(output);
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input!");
            }
        }

        public static List<int> FindsTheLongestSubsequenceOfEqualNumbers(List<int> numbers)
        {
            List<int> longestSubsequence = new List<int>();
            int subsequenceCounter = 1;
            int counter = 1;
            int lastIndexOfSubsequence = 0;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    counter++;
                    if (subsequenceCounter < counter)
                    {
                        subsequenceCounter = counter;
                        lastIndexOfSubsequence = i + 1;
                    }
                }
                else
                {
                    counter = 1;
                }
            }

            for (int i = lastIndexOfSubsequence - subsequenceCounter + 1; i <= lastIndexOfSubsequence; i++)
            {
                longestSubsequence.Add(numbers[i]);
            }

            return longestSubsequence;
        }
    }
}
