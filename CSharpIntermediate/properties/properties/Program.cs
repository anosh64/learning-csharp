using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(2024, 12, 27));
            Console.WriteLine(person.Age);
        }
    }
}
