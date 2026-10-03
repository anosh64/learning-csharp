using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++) // this for loop checks numbers 1-10, and only gives even numbers
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine();
            for (int i = 10; i > 0; i--) // this does the same thing but reversed.
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine();

            string name = "anosh";

            for (int i = 0; i < name.Length; i++) // this for loop goes through and wries each induvidual letter of the `name` string
            {
                Console.WriteLine(name[i]);
            }

            Console.WriteLine();
            
            foreach (char c in name) // does literally the same thing as that for loop but it's better cause it's shorter.
            {
                Console.WriteLine(c);
            }

            // now lets do an array and go through it with foreach

            Console.WriteLine();

            int[] ints = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }

            // while loops

            Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine();

            int ii = 0;
            while (ii <=10) // does the same thing as the original for loop lol
            {
                if (ii % 1 == 0)
                {
                    Console.WriteLine(ii);
                }
                ii++;
            } // it's better to use a while loop if you have no idea how many times you're going to
              // need to iterate. if you do know, it's far better (in my opinion) to use a for loop

        }
    }
}
