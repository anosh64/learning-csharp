using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorialcalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number and i will compute its factorial");
            int num = Convert.ToInt32(Console.ReadLine());
            int result = 1;

            for (int i = 1; i <= num; i++)
            {
                result = result * i;
            }

            Console.WriteLine(result);
        }
    }
}
