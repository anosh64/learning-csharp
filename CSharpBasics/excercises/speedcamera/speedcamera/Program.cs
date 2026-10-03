using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace speedcamera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool doitagain = true;
            while (doitagain == true)
            {
                Console.WriteLine("what is the speed limit?");
                long speedLimit = Convert.ToInt64(Console.ReadLine());

                Console.WriteLine("what is the speed of the car?");
                long speed = Convert.ToInt64(Console.ReadLine());

                long overspeed = speed - speedLimit;
                const long demerit = 5;

                long demeritAmount = overspeed / demerit;

                if (demeritAmount <= 0)
                {
                    Console.WriteLine("ok");
                }
                else if (demeritAmount > 0 && demeritAmount <= 12)
                {
                    Console.WriteLine(demeritAmount + " DEMERIT POINT(S)");
                }
                else
                {
                    Console.WriteLine("Your license has been suspended.");
                }

                //switch (demeritAmount)
                //{
                //    case 0:
                //        Console.WriteLine("ok");
                //        break;
                //    case 1:
                //        Console.WriteLine("ONE DEMERIT POINT");
                //        break;
                //    case 2:
                //        Console.WriteLine("TWO DEMERIT POINTS");
                //        break;
                //    case 3:
                //        Console.WriteLine("THREE DEMERIT POINTS");
                //        break;
                //    case 4:
                //        Console.WriteLine("FOUR DEMERIT POINTS");
                //        break;
                //    case 5:
                //        Console.WriteLine("FIVE DEMERIT POINTS");
                //        break;
                //    case 6:
                //        Console.WriteLine("SIX DEMERIT POINTS");
                //        break;
                //    case 7:
                //        Console.WriteLine("SEVEN DEMERIT POINTS");
                //        break;
                //    case 8:
                //        Console.WriteLine("EIGHT DEMERIT POINTS");
                //        break;
                //    case 9:
                //        Console.WriteLine("NINE DEMERIT POINTS");
                //        break;
                //    case 10:
                //        Console.WriteLine("TEN DEMERIT POINTS");
                //        break;
                //    case 11:
                //        Console.WriteLine("ELEVEN DEMERIT POINTS");
                //        break;
                //    case 12:
                //        Console.WriteLine("TWELVE DEMERIT POINTS");
                //        break;
                //    default:
                //        Console.WriteLine("Your license has been suspended");
                //        break;
                //}
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("do you want to continue? y/N");
                string doyouwannadoitagain = Console.ReadLine();

                if (doyouwannadoitagain == "y")
                    doitagain = true;
                else if (doyouwannadoitagain == "n")
                {
                    Console.WriteLine("ok");
                    doitagain = false;
                }
                else
                {
                    Console.WriteLine("bye");
                    doitagain = false;
                }
            }




        }
    }
}
