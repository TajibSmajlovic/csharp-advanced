using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LINQ
{
    public class BookRepository
    {
        public IEnumerable<Book> Books { get; } = new List<Book>() { new Book() { Title = "asd", Price = 6 }, new Book() { Title = "dsa", Price = 8 } };
    }
}