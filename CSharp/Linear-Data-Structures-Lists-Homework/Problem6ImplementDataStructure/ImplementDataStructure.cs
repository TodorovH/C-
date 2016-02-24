namespace Problem6ImplementDataStructure
{
    using System;

    class ImplementTheDataStructure
    {
        static void Main(string[] args)
        {
            ReversedList<string> testArray = new ReversedList<string>();

            testArray.Add("item1");
            testArray.Add("item2");
            testArray.Add("item3");
            testArray.Add("item4");
            testArray.Add("item5");
            testArray.Add("item6");

            for (int i = 0; i < testArray.Count; i++)
            {
                Console.WriteLine(testArray[i]);
            }

            Console.WriteLine();

            testArray.Remove(2);

            for (int i = 0; i < testArray.Count; i++)
            {
                Console.WriteLine(testArray[i]);
            }

            Console.WriteLine();

            testArray.Add("item0");

            foreach (var item in testArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
    }
}
