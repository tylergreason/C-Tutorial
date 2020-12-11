using System;
using System.Collections.Generic;
namespace list_tutorial
{
    class Program
    {
        static void ListExample()
        {
            var names = new List<string> { "Tyler", "Name2", "Name3" };
            names.Sort();
            names.Add("this name was added with .Add()");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name}!");
            }
            Console.WriteLine($"This is the name as position 0: {names[0]}.");
            Console.WriteLine($"The list is {names.Count} entries long.");
            string searchTerm = "Tyler";
            var index = names.IndexOf(searchTerm);
            if (index > -1)
            {
                Console.WriteLine($"The index of {searchTerm} is {index}.");
            }
            else
            {
                Console.WriteLine($"The index is {index}, which indicates {searchTerm} was not found.");
            }
        }

        static void IntList()
        {
            var intList = new List<int> { 1, 1 };
            for (var i = 1; i < 20; i++)
            {
                Console.WriteLine(intList[intList.Count - 1]);
                var prev1 = intList[intList.Count - 1];
                var prev2 = intList[intList.Count - 2];
                intList.Add(prev1 + prev2);
            }
        }
        static void Main(string[] args)
        {
            Console.Clear();
            ListExample();
            IntList();
        }
    }
}
