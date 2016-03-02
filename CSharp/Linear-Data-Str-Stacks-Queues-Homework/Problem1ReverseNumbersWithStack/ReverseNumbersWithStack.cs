namespace LinearDataStrStacksQueuesHW
{
    using System;
    using System.Collections.Generic;

    class ReverseNumbersWithStack
    {
        static void Main(string[] args)
        {

            Stack<int> numbers = new Stack<int>();
            String line = Console.ReadLine();
            if (line.Length > 0)
            {
                try
                {
                    String[] numbersArr = line.Split(' ');
                    foreach (String number in numbersArr)
                    {
                        numbers.Push(int.Parse(number));
                    }
                    while (numbers.Count > 0)
                    {
                        Console.Write(numbers.Pop() + " ");
                    }
                    Console.WriteLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid input!");
                }
                
            }
            else
            {
                Console.WriteLine("(empty)");
            }
        }
    }
}
