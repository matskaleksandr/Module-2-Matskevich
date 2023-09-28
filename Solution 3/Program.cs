using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            string nameAutor = "";
            int birthDayAutor;
            string nameBook = "";
            string sExit = "";
            int iDateBook = 0;
            try
            {
                while (sExit != "-")
                {
                    Console.WriteLine("Имя автора");
                    nameAutor = Console.ReadLine();
                    Console.WriteLine("Дата рождения автора");
                    birthDayAutor = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Название книги");
                    nameBook = Console.ReadLine();
                    Console.WriteLine("Дату выхода книги");
                    iDateBook = Convert.ToInt32(Console.ReadLine());
                    Author author = new Author(nameAutor, birthDayAutor);
                    Book book = new Book(nameBook, iDateBook, author);
                    books.Add(book);
                    Console.WriteLine("Введите \"-\" если хотите закончить.");
                    sExit = Console.ReadLine();
                }
                for (int i = 0; i < books.Count; i++)
                {
                    Console.WriteLine("Название: " + books[i].Title); Console.WriteLine("Год выпуска: " + books[i].Year);
                    Console.WriteLine("Автор: " + books[i].Author.Name + ", Год рождения автора: " + books[i].Author.BirthYear); Console.WriteLine();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
