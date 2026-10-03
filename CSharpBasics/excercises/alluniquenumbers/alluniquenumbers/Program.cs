using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alluniquenumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool finished = false;

            var numbers = new List<int>();

            while (!finished)
            {
                Console.WriteLine("please enter a number. type \"quit\" to end.");
                var number = Console.ReadLine();

                int intcheckoutput = 0;
                bool intcheck = int.TryParse(number, out intcheckoutput);

                if (intcheck == false && number.ToLower() == "quit")
                {
                    finished = true;
                    var numbersDistinct = numbers.Distinct();
                    foreach (int i in numbersDistinct)
                    {
                        Console.WriteLine(i);
                    }
                }
                else if (intcheck == true)
                {
                    numbers.Add(intcheckoutput);
                }
                else
                {
                    continue;
                }

            }
        }
    }
}
