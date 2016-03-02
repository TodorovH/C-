namespace Problem3ImplArrayBasedStack
{
    using System;
    using System.Linq;

    class ImplementAArrayBasedStack
    {
        static void Main(string[] args)
        {
            var test = new ArrayBasedStack<int>();

            test.Push(3);
            test.Push(5);
            test.Push(-2);
            test.Push(7);

            var result = test.ToArray();
        }
    }
}

