using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda_expressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // a lambda expression is an anonymous method
            // syntax is args => expression
            // for example, here I will use delegate Func<> to create
            // a lambda expression. this will square the number that is input.
            Func<int, int> square = x => x * x;

            // call the delegate

            Console.WriteLine(square(5));

            // if no arguments, syntax is like:
            // () => ...
            // if one argument, syntax is like:
            // x => ...
            // if multiple arguments, syntax is like:
            // (x, y, z) => ...

          ////////////>>>>>||||<<<<<<\\\\\\\\\\\
   ////////////////////  BookStore  \\\\\\\\\\\\\\\\\
        
        // this would be a normal function to return all the books that are under 10 pounds

        var books = new BookRepository().GetBooks();

        var cheapBooks = books.FindAll(IsUnderTenPounds);

        foreach (var book in cheapBooks)
        {
            Console.WriteLine(book.Title);
        }

            // this code is lonnggg, yes this includes that IsUnderTenPounds method,
            // and in place of all that why not write this short, gorgeous oneliner?

            var cheapBooksRemastered = books.FindAll(book => book.Price < 10);

            // can't escape the foreach tho unfortunately
            foreach (var book in cheapBooksRemastered)
            {
                Console.WriteLine(book.Title);
            }

        }

        static bool IsUnderTenPounds(Book book)
        {
            if (book.Price < 10)
            {
                return true;
            }
            return false;
        }
    }
}
