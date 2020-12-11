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

        static void Remainders()
        {
            int a = 100000;
            int b = 333;
            Console.WriteLine(a % b);
        }

        static void MinMaxInt()
        {
            Console.WriteLine("Integers");
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            Console.WriteLine($"The max int is {maxInt} and the min int is {minInt}.");
            Console.WriteLine($"Max overflow occurs when you try to exceed the maximum integer value, and underflow occurs when you try to exceed the minimum integer value.");
            Console.WriteLine($"Max int {maxInt} + 1: {maxInt + 1}");
            Console.WriteLine($"Min int ({minInt}) -1: {minInt - 1}");
            Console.WriteLine(maxInt == minInt - 1);
        }

        static void Doubles()
        {
            Console.WriteLine("Doubles");
            double a = 1.1;
            double b = 2.2;
            Console.WriteLine(a + b);
            Console.WriteLine(a / b);
            Console.WriteLine($"3.3/1.1: {3.3 / 1.1}");
            Console.WriteLine($"The range of doubles is {double.MinValue} to {double.MaxValue}");
        }

        static void Decimals()
        {
            Console.WriteLine("Decimals");
            decimal min = Decimal.MinValue;
            decimal max = Decimal.MaxValue;
            Console.WriteLine($"The min and max values for decimals are {min} and {max}");
        }

        static void CompareDoubleToDecimal()
        {
            double a = 1.0;
            double b = 3.0;
            Console.WriteLine(a / b);

            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine(c / d);
        }

        static double CalcAreaOfCircle(int radius)
        {
            Console.WriteLine($"{(radius * radius) * Math.PI} centimeters squared");
            return (radius * radius) * Math.PI;
        }

        static void Main(string[] args)
        {
            Console.Clear();
            Remainders();
            WorkingWithIntegers();
            MinMaxInt();
            Doubles();
            Decimals();
            CompareDoubleToDecimal();
            CalcAreaOfCircle(5);
        }
    }
}
