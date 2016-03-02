namespace Problem9SequenceNtoM
{
    using System;

    class Number
    {
        public int Value { get; private set; }
        public Number Prev { get; private set; }

        public Number(int value, Number prev)
        {
            this.Value = value;
            this.Prev = prev;
        }

        public void Print(Number number)
        {
            number = number.Prev;
            if (number.Prev != null)
            {
                Print(number);
            }
            Console.Write(number.Value + " -> ");
        }
    }
}
