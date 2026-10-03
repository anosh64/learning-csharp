using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine($"hi {to}, i am {Name}");
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;

            return person;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var anosh = Person.Parse("anosh");
            anosh.Introduce("sassysquas");
        }

    }
}
