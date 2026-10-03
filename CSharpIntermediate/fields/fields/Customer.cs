using System.Collections.Generic;

namespace fields
{
    internal partial class Program
    {
        public class Customer
        {
            public int Id;
            public string Name;
            public List<Order> Orders = new List<Order>();
            public Customer() { }

            public Customer(int id)
            {
                this.Id = id;
            }
            public Customer(string name)
                : this()
            {
                this.Name = name;
            }

            public void Promote()
            {
                //Orders = new List<Order>();
                // ...
            }

        }
    }
}
