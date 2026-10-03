using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumOfTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number (this is number 1):");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("now enter number 2");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int adding = num1 + num2;
            int subtracting = num1 - num2;
            int multiplying = num1 * num2;
            int dividing = num1 / num2;
            int remaindering = num1 % num2;

            // todo: add operation variants where the operation is non-commutitive, e.g. dividing2 = num2/num1

            if (adding > subtracting && adding > multiplying && adding > dividing && adding > remaindering) {
                Console.WriteLine("adding is the max, it was " + adding);
            }
            else if (subtracting > adding && subtracting > multiplying && subtracting > dividing && subtracting > remaindering)
            {
                Console.WriteLine("subtracting is the max, it was " + subtracting);
            }
            else if (multiplying > adding && multiplying > subtracting && multiplying > dividing && multiplying > remaindering)
            {
                Console.WriteLine("multiplying is the max, it was " + multiplying);
            }
            else if (dividing > adding && dividing > subtracting && dividing > multiplying && dividing > remaindering)
            {
                Console.WriteLine("dividing is the max, it was " + dividing);
            }
            else if (remaindering > adding && remaindering > subtracting && remaindering > multiplying && remaindering > dividing)
            {
                Console.WriteLine("remaindering is the max, it was " + remaindering);
            }
        }
    }
}
