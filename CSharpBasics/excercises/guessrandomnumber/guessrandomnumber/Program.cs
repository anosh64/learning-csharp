using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessrandomnumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            var theNumber = random.Next(1, 10);

            int guessmax = 4;

            Console.WriteLine("guess the number between 1-10");

            for (int i = 1; i <= guessmax; i++)
            {
                int triesRemaining = guessmax - i;
                Console.Write("ATTEMPT " + i + ":  ");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess == theNumber)
                {
                    Console.WriteLine("you won!");
                    break;
                }
                else if (triesRemaining == 0)
                {
                    Console.WriteLine("you lost! the number was " + theNumber);
                    break;
                }
                else
                {
                    Console.WriteLine("wrong number! try again. " + triesRemaining + " tries remaining");
                    continue;
                }
            }
           

        }
    }
}
