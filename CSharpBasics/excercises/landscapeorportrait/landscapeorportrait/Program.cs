using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace landscapeorportrait
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("width of image?");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("height of image?");
            int height = Convert.ToInt32(Console.ReadLine());

            if (width > height)
            {
                Console.WriteLine("your image is landscape");
            }
            else
            {
                Console.WriteLine("your image is portrait");
            }
            }
        }
    }
