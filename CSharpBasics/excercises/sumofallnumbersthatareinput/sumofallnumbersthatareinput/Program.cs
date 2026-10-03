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
            bool finished = false;

            int sum = 0;

            Console.WriteLine("type \"ok\" to end and give you your sum. (if you type anything else, we'll just ask again.)");

            while (!finished) 
            {
                Console.Write("please enter a number:  ");
                var userInput = Console.ReadLine();

                var userInputIfString = userInput.ToLower();

                bool intcheck;
                int intchckeroutput = 0;
                intcheck = int.TryParse(userInput, out intchckeroutput);

                if (intcheck == true)
                {
                    sum += intchckeroutput;
                    Console.WriteLine();
                    continue;
                }
                else if (intcheck == false && userInputIfString == "ok")
                {
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.WriteLine();
                    continue;
                }

            }

            Console.WriteLine(sum);

        }
    }
}
