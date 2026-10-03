using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructors
{
    internal partial class Program
    {
        static void Main(string[] args) 
        {
            var customer = new Customer();
            customer.Id = 1;
            customer.Name = "anosh";

            var order = new Order();
            customer.Orders.Add(order);
            
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);


        }
    }
}
