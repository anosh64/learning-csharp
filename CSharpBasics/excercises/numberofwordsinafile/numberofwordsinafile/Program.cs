using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace numberofwordsinafile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\anosh\source\repos\csharp\excercises\numberofwordsinafile\numberofwordsinafile\randomfile.txt";

            var allwords = File.ReadAllText(path).Split(' ');

            var wordcount = 0;

            foreach (var word in allwords)
            {
                wordcount++;
            }

            Console.WriteLine($"number of words: {wordcount}");

        }
    }
}
