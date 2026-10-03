using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumofallnumbersthatareinput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool shouldWeStartAdding = false;
            int result = 0;

            while (!shouldWeStartAdding)
            {
                Console.WriteLine("input a number or type 'ok'. if you type anything else i will close.");
                var input = Console.ReadLine();

                int num;
                bool inputIsInt = int.TryParse(input, out num);
                

                if (input == "ok")
                {
                    shouldWeStartAdding = true;
                }
                else if (inputIsInt == true)
                {
                    result += num;
                }
                else
                {
                    Environment.Exit(0);
                }
            }

            Console.WriteLine(result);
        }
    }
}
