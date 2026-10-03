using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace namereverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write your name");
            var name = Console.ReadLine();

            var namearray = new char[name.Length];

            for (int i = 0; i < name.Length; i++) 
            {
                char c = name[i];
                namearray[i] = c;
            }

            Array.Reverse(namearray);

            var reversename = new string(namearray);
            Console.WriteLine(reversename);

        }
    }
}
