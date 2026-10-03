using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fullname = "anosH Anosh";

            var index = fullname.IndexOf(" ");

            var names = fullname.Split(' ');

            Console.WriteLine(string.Format("trim: '{0}'", fullname.Trim()));
            Console.WriteLine(string.Format("to upper: '{0}'", fullname.ToUpper()));
            Console.WriteLine(string.Format("to lower: '{0}'", fullname.ToLower()));
            Console.WriteLine(string.Format("only first name: '{0}'", fullname.Substring(0, index)));
            Console.WriteLine(string.Format("only last name: '{0}'", fullname.Substring(index + 1)));
            Console.WriteLine(string.Format("only first name (w/ split): '{0}'", names[0]));
            Console.WriteLine(string.Format("only last name (w/ split): '{0}'", names[1]));

            var somechangestofullname = fullname.Replace("anosH", "anosh")
                            .Replace("A", "a")
                            .Replace("o", "●");

            Console.WriteLine(somechangestofullname);

            float price = 29.95f;


            Console.WriteLine(price.ToString("C")); // now it's currency with decimal places
            Console.WriteLine(price.ToString("C0")); // now it's currency without decimal places

        }
    }
}
