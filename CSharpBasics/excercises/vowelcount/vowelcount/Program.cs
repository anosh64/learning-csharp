using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vowelcount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter an english word and we will count the amount of vowels in it.");
            var input = Console
                        .ReadLine()
                        .ToLower()
                        .Trim();

            var vowels = new char[5] { 'a', 'e', 'i', 'o', 'u' };
            int vowelcount = 0;

            foreach (var character in input)
            {
                if (vowels.Contains(character)) vowelcount++;
            }

            Console.WriteLine(vowelcount);

        }
    }
}
