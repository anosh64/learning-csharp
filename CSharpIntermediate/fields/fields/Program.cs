using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fields
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            customer.Promote();

            Console.WriteLine(customer.Orders.Count());

        }
    }
}
