using System;

namespace ccnstructorsAndInheritance
{
    public class Vehicle
    {
        private readonly string _regNumber;

        //public Vehicle()
        //{
        //    Console.WriteLine("vehicle is being initialised");
        //}

        public Vehicle(string regNumber)
        {
            _regNumber = regNumber;

            Console.WriteLine($"vehicle is being initialised {regNumber}");
        }
    }
}