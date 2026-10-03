using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        static void useParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3, 4, 5, 6));

            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5, 6, 7 }));
        }
        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                point.Move(40, 60);
                Console.WriteLine($"point is at ({point.X}, {point.Y})");
            }
            catch (Exception)
            {
                Console.WriteLine("an unexpected error happened");
            }
        }
    }
}
