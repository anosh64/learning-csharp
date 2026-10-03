using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accessmodifiers
{
    public class Person
    {
        private DateTime _birthDate;

        public void SetBirthdate(DateTime birthdate)
        {
            _birthDate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _birthDate;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(2008, 12, 27));
            Console.WriteLine(person.GetBirthdate());
        }
    }
}
