using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duplicatechecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a few numbers seperated by a hyphen");
            var userInput = Console.ReadLine().Split('-');

            var numbers = new List<int>();

            foreach (var number in userInput)
            {
                var numero = Convert.ToInt32(number);
                numbers.Add(numero);
            }

            var numbersDistinct = numbers.Distinct().ToList();

            if (numbers.Count > numbersDistinct.Count)
            {
                Console.WriteLine("duplicates");
            }
            else
            {
                Console.WriteLine("no duplicates");
            }
        }
    }
}