using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpconditionals
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            // i'll do the conditioal statements later


            // If Else and switch case

            int hour = 22;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("it's morning");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("it's afternoon");
            }
            else
            {
                Console.WriteLine("it's evening");
            }


            bool isGoldCustomer = true;

            //float price;
            //if (isGoldCustomer)
            //{
            //    price = 19.95f;
            //    Console.WriteLine("since you are a gold customer, you get a £10 discount. your price is now £"+price);
            //}
            //else
            //{
            //    price = 29.95f;
            //    Console.WriteLine("you aren't a gold customer so no £10 discount for you.");
            //}
            // the one above makes sense but this one's different
            float price = (isGoldCustomer) ? 19.95f : 29.95f;
            // the price is... if customer is gold, 19.95, else it's 29.95
            // this way is far shorter.


            var season = Season.Summer;

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("It's Autumn. An overrrated season.");
                    break;
                case Season.Summer: // now summer and winter have the same messge
                    //Console.WriteLine("we've got a promotion.");
                    //break;
                case Season.Winter:
                    Console.WriteLine("we've got a promotion.");
                    break;
                default:
                    Console.WriteLine("spring has sprung");
                    break;
            }


            }
    }
}
