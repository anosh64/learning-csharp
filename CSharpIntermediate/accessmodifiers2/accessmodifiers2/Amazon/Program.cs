using System;
using System.Globalization;

namespace Amazon
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            //var rating = CalculateRating(excludeOrders: true);
            //if (rating == 0)
            //{
            //    Console.WriteLine("promoted to level 0");
            //}
            //else
            //    Console.WriteLine("promoted to level 1");

            Console.WriteLine("promote logic changed");
            var calculator = new RateCalc();
            var rating = calculator.Calculate(this);
        }

        //public int CalculateRating(bool excludeOrders)
        //{
        //    return 0;
        //}
    }
}