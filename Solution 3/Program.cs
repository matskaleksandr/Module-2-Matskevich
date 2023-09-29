using System;
using System.Collections.Generic;

namespace Solution_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();//создание списока для хранения книг
            string nameAutor = "";//переменная для хранения имени автора
            int birthDayAutor;//переменная для хранения года рождения автора
            string nameBook = "";//переменная для хранения названия книги
            string sExit = "";//переменная для управления выходом из цикла
            int iDateBook = 0;//переменная для хранения года выпуска книги
            try
            {
                while (sExit != "-")
                {
                    Console.WriteLine("Имя автора");
                    nameAutor = Console.ReadLine();//ввод имени автора
                    Console.WriteLine("Дата рождения автора");
                    birthDayAutor = Convert.ToInt32(Console.ReadLine());//ввод дня рождения автора
                    Console.WriteLine("Название книги");
                    nameBook = Console.ReadLine();//ввод названия книги
                    Console.WriteLine("Дату выхода книги");
                    iDateBook = Convert.ToInt32(Console.ReadLine());//ввод даты выхода книги
                    Author author = new Author(nameAutor, birthDayAutor);//создание объекта автора
                    Book book = new Book(nameBook, iDateBook, author);//создание объекта книги с указанием автора
                    books.Add(book);//добавление книги в список
                    Console.WriteLine("Введите \"-\" если хотите закончить.");
                    sExit = Console.ReadLine();//пользователь вводит "-", чтобы завершить ввод книг
                }
                //выводим информацию о каждой книге и её авторе
                for (int i = 0; i < books.Count; i++)
                {
                    Console.WriteLine("Название: " + books[i].Title);
                    Console.WriteLine("Год выпуска: " + books[i].Year);
                    Console.WriteLine("Автор: " + books[i].Author.Name + ", Год рождения автора: " + books[i].Author.BirthYear);
                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);//вывод сообщение об ошибке, если она произошла
            }
        }
    }
}
