using System;

namespace BranchesAndLoops
{
    class Program
    {
        static void Compare()
        {
            int a = 1;
            int b = 2;
            if (a < b)
            {
                Console.WriteLine("a is less than b.");
            }
        }

        static void OperatorReference()
        {
            int a = 10;
            int b = 2;
            if (a < b || a == 0)
            {
                Console.WriteLine("Either a is less than b or a equals zero.");
            }
            else
            {
                Console.WriteLine("a is greater than or equal to b and a does not equal zero.");
            }
        }

        static void WhileExample()
        {
            int counter = 0;
            while (counter <= 10)
            {
                Console.WriteLine($"Counter equals {counter}");
                counter++;
            }
        }

        static void NestedLoop()
        {
            for (int row = 1; row < 11; row++)
            {
                for (int col = 1; col < 11; col++)
                {
                    Console.WriteLine($"Row is {row} and Column is {col}");
                }
            }
        }

        static void DivBy20()
        {
            for (int num = 1; num <= 21; num++)
            {
                if (num % 3 == 0)
                {
                    Console.WriteLine(num);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Clear();
            Compare();
            OperatorReference();
            WhileExample();
            NestedLoop();
            DivBy20();
        }
    }
}
