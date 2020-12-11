using System;

namespace Tutorial
{
    class Program
    {
        static void WorkingWithIntegers()
        {
            int a = 18;
            int b = 10;
            int c = a + b;
            double d = 1.1;
            Console.WriteLine(c * d + b);
            Console.WriteLine(a / b);
            double e = a / b;
            Console.WriteLine(e);
        }

        static void Main(string[] args)
        {
            Console.Clear();
            WorkingWithIntegers();
        }
    }
}
