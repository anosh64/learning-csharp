using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximumofnumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write a series of numbers, seperated by commas.");
            Console.WriteLine("for example: 5, 8, 192, 6");
            Console.WriteLine();

            var series = Console.ReadLine();

            char[] converttochar = series.ToCharArray();

            char omitcomma = ',';

           var commaless = converttochar.Where(val => val != omitcomma).ToArray();

           string nums = new string(commaless);

            int[] intarray = Array.ConvertAll(nums.Split(' '), int.Parse);

            int maximum = intarray[0];

            for (int i = 0; i < intarray.Length; i++)
            {
                if (intarray[i] > maximum)
                {
                    maximum = intarray[i];
                    continue;
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine("the largest number of the numbers you have given is:");
            Console.WriteLine();
            Console.WriteLine(maximum);

        }
    }
}
