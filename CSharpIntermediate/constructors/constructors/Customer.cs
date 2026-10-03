using System.Collections.Generic;

namespace constructors
{
    internal partial class Program
    {
        public class Customer
        {
            public int Id;
            public string Name;
            public List<Order> Orders;

            public Customer()
            {
                Orders = new List<Order>(); // orders is no longer null, null exception avoided!
            }

            public Customer(int id)
                : this() // calls the default constructor first ALWAYS before calling this one
            {
                this.Id = id;
            }

            public Customer(int id, string name)
                : this(id)      // calls the id constructor first ALWAYS before calling this one 
            {                   // : this() is complicated to maintain. only use it when you NEED to. like in this situation
                this.Id = id;   // to dodge a null exception, we had to force default constructor always.
                this.Name = name;
            }
        }
    }
}
