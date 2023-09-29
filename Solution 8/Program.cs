using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = null;//Создание переменной для хранения объекта круга
            Rectangle rectangle = null;//Создание переменной для хранения объекта прямоугольника
            Triangle triangle = null;//Создание переменной для хранения объекта треугольника
            string sn;//Строковая переменная для хранения введенного пользователем значения
            int n;//Числовая переменная для хранения введенного пользователем значения
            string sBreak = "";//строковая переменная для хранения значения, указывающего на выход из цикла
            while (sBreak != "-")
            {
                do
                {
                    do
                    {
                        Console.WriteLine("Создать круг, прямоугольник, треугольник (1, 2, 3)");
                        sn = Console.ReadLine();
                    }
                    while (!int.TryParse(sn, out n));//Проверка что введенное значение является числом
                }
                while (n != 1 && n != 3);//проверка что введенное число равно 1 или 2 или 3
                Console.Clear();
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Создан круг");
                        circle = new Circle();//Создание объекта круга
                        circle.Areas();//Вычисление площади и периметра круга
                        Console.WriteLine($"Площадь: {circle.Area()}");
                        break;
                    case 2:
                        Console.WriteLine("Создан прямоугольник");
                        rectangle = new Rectangle();//Создание объекта прямоугольника
                        rectangle.Areas();//Вычисление площади и периметра прямоугольника
                        Console.WriteLine($"Площадь: {rectangle.Area()}");
                        break;
                    case 3:
                        Console.WriteLine("Создан треугольник");
                        triangle = new Triangle();//Создание объекта треугольника
                        triangle.Areas();//Вычисление площади и периметра треугольника
                        Console.WriteLine($"Площадь: {triangle.Area()}");
                        break;
                }
                Console.WriteLine("Введите \"-\" если хотите закончить.");
                sBreak = Console.ReadLine();//"-" чтобы завершить цикл
            }
        }
    }
}
