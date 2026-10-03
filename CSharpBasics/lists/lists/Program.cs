using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // arrays are fixed, lists are not. they're flexible.

            var numbers = new List<int>() { 1, 8, 1, 21, 1, 5, 999999, 0, 6, 1, 12, 18, 24, 1, 30, 36, 42, 48, 1, 54, 60, 66, 72, 72, 1, 1};

            numbers.Add(8888);
            numbers.AddRange(new int[3] {5, 6, 7}); // adding an array to a list, you could also add a list to the list.

            foreach (var n in numbers)
                Console.WriteLine(n);

            int indexof72 = numbers.IndexOf(72); // tells you the index of an existing object in the array, if non existent returns -1
            int lastindexof72 = numbers.LastIndexOf(72); // tells you the index of an existing object in the array, if non existent returns -1
            Console.WriteLine();
            Console.WriteLine("index of 72: "+indexof72);

            Console.WriteLine("last index of 72: "+lastindexof72);

            Console.WriteLine();
            Console.WriteLine("count: " + numbers.Count);

            numbers.Remove(1);
            Console.WriteLine();

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers.Count);
                int number = numbers[i];
                if (number == 1)
                {
                    numbers.Remove(number);
                }
                else {
                    continue;
                }
            }
            foreach (var n in numbers)
                Console.WriteLine(n);

        }
    }
}
