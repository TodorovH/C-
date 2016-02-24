namespace LinearDataStructuresListsHomework
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SortWords
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                                    .Split(' ')
                                    .ToList();

            words.Sort();
            string output = string.Join(" ", words.ToArray());
            Console.WriteLine(output);
        }
    }
}
