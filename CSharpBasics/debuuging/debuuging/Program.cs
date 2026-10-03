using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace debuuging
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
            var smallests = GetSmallests(numbers, 3);

            foreach (var number in smallests)
                Console.WriteLine(number);
            
        }

        public static List<int> GetSmallests(List<int> list, int count)
        {
            if (count > list.Count || count <= 0)
            {
                throw new ArgumentOutOfRangeException("count", "count cannot be greater than the number of elements in the list, or less than or equal to 0.");
            }
            var buffer = new List<int>(list);
            var smallests = new List<int>();

            while (smallests.Count < count)
            {
                var min = GetSmallest(buffer);
                smallests.Add(min);
                buffer.Remove(min);
            }
            return smallests;
        }
        public static int GetSmallest(List<int> list)
        {
            var min = list[0];
            for (var i = 1; i < list.Count; i++)
            {
                if (list[i] < min)
                    min = list[i];
            }
            return min;
        }
    }
}
