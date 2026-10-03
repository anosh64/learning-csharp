using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24hourtime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a 24 hour time value e.g. 17:00");
            var input = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(input) == true)
            {
                Console.WriteLine("invalid time");
                Environment.Exit(0);
            }
            var usertime = Convert.ToDateTime(input);

            var correctformat = usertime.ToString("HH:mm");

            var components = correctformat.Split(':');
            if (components.Length < 2 )
            {
                Console.WriteLine("invalid time");
            }

            try
            {
                var hour = Convert.ToInt32(components[0]);
                var minute = Convert.ToInt32(components[1]);

                if (hour <= 23 && hour >= 0 && minute <= 59 && minute >= 00 )
                {
                    Console.WriteLine("ok");
                }

            }
            catch (Exception)
            {
                Console.WriteLine("invalid");
            }

        }
    }
}
