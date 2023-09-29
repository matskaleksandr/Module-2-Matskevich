using System;

namespace Solution_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = null;//Создание переменной для хранения объекта круга
            Rectangle rectangle = null;//Создание переменной для хранения объекта прямоугольника
            string sn;//Строковая переменная для хранения введенного пользователем значения
            int n;//Числовая переменная для хранения введенного пользователем значения
            string sBreak = "";//строковая переменная для хранения значения, указывающего на выход из цикла
            while (sBreak != "-")
            {
                do
                {
                    do
                    {
                        Console.WriteLine("Создать круг или прямоугольник (1 / 2)");
                        sn = Console.ReadLine();
                    }
                    while (!int.TryParse(sn, out n));//Проверка что введенное значение является числом
                }
                while (n != 1 && n != 2);//проверка что введенное число равно 1 или 2
                Console.Clear();
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Создан круг");
                        circle = new Circle();//Создание объекта круга
                        circle.AreaAndPerimeter();//Вычисление площади и периметра круга
                        Console.WriteLine($"Площадь: {circle.Area()}");
                        Console.WriteLine($"Периметр: {circle.Perimeter()}");
                        break;
                    case 2:
                        Console.WriteLine("Создан прямоугольник");
                        rectangle = new Rectangle();//Создание объекта прямоугольника
                        rectangle.AreaAndPerimeter();//Вычисление площади и периметра прямоугольника
                        Console.WriteLine($"Площадь: {rectangle.Area()}");
                        Console.WriteLine($"Периметр: {rectangle.Perimeter()}");
                        break;
                }
                Console.WriteLine("Введите \"-\" если хотите закончить.");
                sBreak = Console.ReadLine();//"-" чтобы завершить цикл
            }
        }
    }
}
