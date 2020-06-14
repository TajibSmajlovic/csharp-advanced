using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace LINQ
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var books = new BookRepository();

            // LINQ query operators
            var test =
                from b in books.Books
                where b.Price > 5
                orderby b.Title
                select b.Title; // or select just b

            // LINQ extension Methods
            var test1 = books.Books
                .Where(b => b.Price > 5)
                .OrderBy(b => b.Title)
                .Select(b => b.Title);

            foreach (var book in test1)
            {
                Console.WriteLine(book);
            }

            // var test2 = books.Books.SingleOrDefault(b => b.Title == "asd");
            // var test2 = books.Books.LastOrDefault(b => b.Title == "asd");

            // .Count()
            // .Max(b => b.Price)
            // .Average(b => b.Price)

            var test2 = books.Books.FirstOrDefault(b => b.Title == "asd");

            // skip 2 records, after that takes 3 records --- USED FOR PAGING
            var test3 = books.Books.Skip(2).Take(3);
        }
    }
}