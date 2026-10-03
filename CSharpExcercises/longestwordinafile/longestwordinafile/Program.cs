using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom;

namespace longestwordinafile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"..\..\randomfile.txt";

            var readFile = File.ReadAllText(path).Split(' ');

            var orderByDescending = readFile.OrderByDescending(s => s.Length).First();

            Console.WriteLine($"longest word: {orderByDescending}");

        }
    }
}
