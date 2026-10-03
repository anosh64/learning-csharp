using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datetime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2024, 12, 27);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.Write(now.Hour + ":" + now.Minute + ":" + now.Second + ":" + now.Millisecond);
            Console.WriteLine();

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy-MM-dd:mm:ss"));


        }
    }
}
