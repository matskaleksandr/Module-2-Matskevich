using System;
using System.Text.RegularExpressions;

namespace Solution_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sLen = "";
            int iLen = 0;
            do
            {
                Console.WriteLine("Введите количество персон");
                sLen = Console.ReadLine();
            }
            while (!int.TryParse(sLen, out iLen));
            Person[] person = new Person[iLen];
            Console.WriteLine();
            for (int i = 0; i < person.Length; i++)
            {
                string pattern = @"^[А-ЯЁ][а-яё]*$";
                string sName = "";
                string sAge = "";
                int iAge = 0;
                person[i] = new Person();
                do
                {
                    Console.WriteLine($"Введите имя персонажа {i + 1}");
                    sName = Console.ReadLine();
                }
                while (!Regex.IsMatch(sName, pattern));
                person[i].SetName(sName);
                do
                {
                    Console.WriteLine($"Введите возраст персонажа {i + 1}");
                    sAge = Console.ReadLine();
                }
                while (!int.TryParse(sAge, out iAge));
                person[i].SetAge(iAge);
                Console.WriteLine($"Введите адрес персонажа {i + 1}");
                person[i].SetAddress(Console.ReadLine());
                Console.WriteLine();
            }
            Console.Clear();
            for (int i = 0; i < person.Length; i++)
            {
                Console.WriteLine($"Person-{i + 1}");
                Console.WriteLine($"Имя: {person[i].GetName()}");
                Console.WriteLine($"Возраст: {person[i].GetAge()}");
                Console.WriteLine($"Адрес: {person[i].GetAddress()}");
                Console.WriteLine();
            }
        }
    }
}
