using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_3
{
    class Book
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public Author Author { get; set; }
        public Book(string title, int year, Author author)
        {
            Title = title;
            Year = year; Author = author;
        }
    }
}
