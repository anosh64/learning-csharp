using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter a number to factorial it:  ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            long factorial = 1;

            for (int i = userInput; i >= 1; i--) 
            {
               factorial *= i;
            }

            Console.WriteLine(userInput + "! = " + factorial);
        }
    }
}
