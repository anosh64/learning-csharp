using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace consecutiveNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input a list of numbers seperated by hyphens. check if they are consective or not");
            var numbers = Console.ReadLine()
                          .Trim()
                          .Split('-');

            ConsecutiveSequenceCheck(numbers);
        }

        public static void ConsecutiveSequenceCheck(string[] sequence)
        {

            var numbers = new List<int>();
            foreach (var number in sequence)
                numbers.Add(Convert.ToInt32(number));

            var isConsecutive = true;
            int difference = numbers[1] - numbers[0];

            if (Math.Abs(difference) != 1)
            {
                isConsecutive = false;
            }
            else
            {
                for (var i = 1; i < numbers.Count; i++)
                {
                    if (numbers[i] - numbers[i - 1] != difference)
                    {
                        isConsecutive = false;
                        break;
                    }
                }
            }

            var message = isConsecutive ? "consecutive" : "not consecutive";
            Console.WriteLine(message);
        }
    }
    }

