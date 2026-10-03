using System;

namespace ccnstructorsAndInheritance
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber)
            : base(registrationNumber)
        {
            Console.WriteLine($"car is being initialised {registrationNumber}");
        }
    }
}