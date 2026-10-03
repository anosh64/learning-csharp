using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortedlistofuniquenumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter 5 unique numbers seperated by a space. should be no duplicates");
            Console.WriteLine("example: 1 2 3 4 5");
            var userInput = Console.ReadLine();

            if (userInput.Length > 10) {
                Console.WriteLine("i said 5 not more than that");
                Console.WriteLine("bye");
                Environment.Exit(0);
            }

            int[] intarray = Array.ConvertAll(userInput.Split(' '), int.Parse);

            if (intarray.Length > intarray.Distinct().Count())
            {
                Console.WriteLine("i said no duplicates");
                Console.WriteLine("bye");
                Environment.Exit(0);
            }

            var sortedintarray = intarray;

            Array.Sort(sortedintarray);

            foreach (int i in sortedintarray)
            {
                Console.WriteLine(i);
            }

        }
    }
}
