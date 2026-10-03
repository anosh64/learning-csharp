using System.Collections.Generic;

namespace linqstuff
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>()
            {
                new Book() { Title = "c sharp for dummies", Price = 4 },
                new Book() { Title = "c sharp for dummies who are a bit smarter", Price = 8 },
                new Book() { Title = "c sharp for normal people", Price = 16 },
                new Book() { Title = "c sharp for above average people", Price = 32 },
                new Book() { Title = "c sharp for intellectuals", Price = 64 }
            };
        }
    }
}