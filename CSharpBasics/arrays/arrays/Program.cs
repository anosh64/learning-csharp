using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 3, 7, 9, 2, 14, 6 };

            // length
            Console.WriteLine("Length: " + numbers.Length);

            // IndexOf()

            int index = Array.IndexOf(numbers, 9); // tells you index of object you're looking for

            Console.WriteLine("index of 9 is: " + index);

            // Clear()
            Array.Clear(numbers, 0, 2);

            Console.WriteLine("effect of clear()");
            foreach (var n in numbers)
                Console.WriteLine(n);

            // copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);
            Console.WriteLine("effect of copy()");
            foreach (var n in another)
                Console.WriteLine(n);

            // sort()
            Array.Sort(numbers);

            Console.WriteLine("effect of sort()");
            foreach (var n in numbers)
                Console.WriteLine(n);

            // reverse()

            Array.Reverse(numbers);
            Console.WriteLine("effect of reverse()");
            foreach (var n in numbers)
                Console.WriteLine(n);
        }
    }
}
