using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(random.Next(1, 10)); // min: 1, max: 10
            //}

            var passwordLength = 10;

            var buffer = new char[passwordLength]; // char array we are going to turn it into a string


            Console.WriteLine();
            for (int i = 0; i < passwordLength; i++)
            {
              buffer[i] =  (char)('a' + random.Next(0, 26)); // we can make passwords with this too, by turning our random numbers
                                                       // into ASCII letters, as they all have their own unique intiger code
                Console.Write(buffer[i]);
                // this could be done though casting
            }
            var password = new string(buffer);
            Console.WriteLine();
            Console.WriteLine(password);
            Console.WriteLine();

            ///////

            string wangtangpasswordtheorem = ""; 
            for (int i = 0;i < 10;i++)
            {
                var wangtangassist = (char)('a' + random.Next(0, 26));
                wangtangpasswordtheorem += wangtangassist;
                Console.WriteLine(wangtangpasswordtheorem);
            }
            Console.WriteLine(wangtangpasswordtheorem);
            //////
        }
    }
}
