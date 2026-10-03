using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pascalcaseification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter some stuff and it wil be turned into PascalCase.");
            var input = Console.ReadLine();
            var lowerInput = input.ToLower();

            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

            var toPascalCase = textInfo.ToTitleCase(lowerInput).Replace(" ", "");

            Console.WriteLine(toPascalCase);
        }
    }
}
