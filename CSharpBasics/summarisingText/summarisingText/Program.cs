using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace summarisingText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = "this is going to be a really really really really really long string of text.";
            Console.WriteLine(stringUtility.SummariseText(text, 30)); 
        }
    }
}
