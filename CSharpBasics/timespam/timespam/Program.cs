using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timespam
{
    internal class Program
    {
        static void Main(string[] args)
        { // a timespan is a specified length of time. below me is a time span of 1 hour, 3 mins and 1 second.
            var timeSpan = new TimeSpan(1, 2, 94); // nice how it adds to the minutes because of 61 seconds.
            var timeSpan1 = new TimeSpan(1, 0, 0); // hours, minutes seconds. 1 hour this one
            var timeSpan2 = TimeSpan.FromHours(1); // 1 hour
            var timeSpan3 = TimeSpan.FromHours(24);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);

            var duration = end - start; // this is a timespan

            Console.WriteLine(duration);

            Console.WriteLine(timeSpan);

            // properties

            Console.WriteLine("total milliseconds in 24 hours: " + timeSpan3.TotalMilliseconds);
            Console.WriteLine("total seconds in 24 hours: " + timeSpan3.TotalSeconds);

            // add

            Console.WriteLine(timeSpan.Add(TimeSpan.FromMinutes(8)));

            // subtract

            Console.WriteLine(timeSpan.Subtract(TimeSpan.FromMinutes(8)));

            // toString

            Console.WriteLine(timeSpan.ToString());

            // parse

            Console.WriteLine(TimeSpan.Parse("01:03:34"));

        }
    }
}
