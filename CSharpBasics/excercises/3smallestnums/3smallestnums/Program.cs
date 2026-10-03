using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _3smallestnums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("provide a list of numbers seperated by commas, if less than 5 numbers");
            Console.WriteLine("or if it's empty, then it iwll be an invalid list. else, it will display 3 smallest numbers.");
            Console.WriteLine("example list: 5, 1, 8, 17");

            var numbers = Console.ReadLine().Split(',');
            var numberss = string.Join(string.Empty, numbers).Split(' ');

            var numlist = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers.Length > 1)
                {
                    int numToInt = Convert.ToInt32(numberss[i]);
                    numlist.Add(numToInt);
                }
                else
                {
                    Console.WriteLine("invalid list");
                    Console.WriteLine("i said it shouldn't be empty");
                    Console.WriteLine("bye");
                    Environment.Exit(0);
                }
                
            }

            numlist.Sort();

            if (numlist.Count < 5 && numlist.Count == 1)
            {
                Console.WriteLine("invalid list");
                Console.WriteLine("i said more than 5 numbers");
                Console.WriteLine("bye");
                Environment.Exit(0);
            }

            else
            {
                for (int i = 0;i < 3;i++)
                {
                    Console.WriteLine(numlist[i]);
                }
            }

        }
    }
}
