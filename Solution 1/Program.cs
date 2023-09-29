using System;
using System.Text.RegularExpressions;

namespace Solution_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sLen = "";//строковая переменная для хранения введенного количества персон
            int iLen = 0;//числовая переменная для хранения количества персон
            try
            {
                //запрашиваем у пользователя количество персон и проверяем, что введено число
                do
                {
                    Console.WriteLine("Введите количество персон");
                    sLen = Console.ReadLine();
                }
                while (!int.TryParse(sLen, out iLen));
                Person[] person = new Person[iLen];//создаем массив объектов типа Person с заданным количеством
                Console.WriteLine();
                //заполнение информации о каждой персоне в массиве
                for (int i = 0; i < person.Length; i++)
                {
                    string pattern = @"^[А-ЯЁ][а-яё]*$";//регулярное выражение для проверки имени
                    string sName = "";//Переменная для хранения введенного пользователем имени
                    string sAge = "";//Переменная для хранения введенного пользователем возраста
                    int iAge = 0;//переменная для хранения возраста в виде числа
                    person[i] = new Person();//создание объекта типа Person для текущей персоны
                    //Запрос у пользователя имени и проверяем его при помощи регулярного выражения
                    do
                    {
                        Console.WriteLine($"Введите имя персонажа {i + 1}");
                        sName = Console.ReadLine();
                    }
                    while (!Regex.IsMatch(sName, pattern));
                    person[i].SetName(sName);//Установка имени для текущей персоны
                    //Запрос у пользователя возраста и проверка, что введено число
                    do
                    {
                        Console.WriteLine($"Введите возраст персонажа {i + 1}");
                        sAge = Console.ReadLine();
                    }
                    while (!int.TryParse(sAge, out iAge));
                    person[i].SetAge(iAge);//Установка возраста для текущей персоны
                    Console.WriteLine($"Введите адрес персонажа {i + 1}");
                    person[i].SetAddress(Console.ReadLine());//Установка адреса для текущей персоны
                    Console.WriteLine();
                }
                Console.Clear();
                //Вывод информации о каждой персоне
                for (int i = 0; i < person.Length; i++)
                {
                    Console.WriteLine($"Person-{i + 1}");
                    Console.WriteLine($"Имя: {person[i].GetName()}");
                    Console.WriteLine($"Возраст: {person[i].GetAge()}");
                    Console.WriteLine($"Адрес: {person[i].GetAddress()}");
                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);//Вывод сообщения об ошибке, если она произошла
            }
        }
    }
}
