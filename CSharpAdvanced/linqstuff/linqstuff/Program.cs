using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqstuff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();
            ////////////////////////////////////////////////////
            /*
            var cheapBooks = new List<Book>();

            foreach (var book in books)
            {
                if (book.Price < 10)
                {
                    cheapBooks.Add(book);
                }
            }
            */
            ////////////////////////////////////////////////////
            // why write all that when we could just write this gorgeous oneliner?

            var cheapBooks = books.Where(b => b.Price < 10); // linq + lambdaEx = nice code

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title + "   Price:" + book.Price);
            }
        }
    }
}
