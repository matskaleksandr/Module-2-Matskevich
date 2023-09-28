using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = null;
            Rectangle rectangle = null;
            string sn;
            int n;
            string sBreak = "";
            while (sBreak != "-")
            {
                do
                {
                    do
                    {
                        Console.WriteLine("Создать круг или прямоугольник (1 / 2)");
                        sn = Console.ReadLine();
                    }
                    while (!int.TryParse(sn, out n));
                }
                while (n != 1 && n != 2);
                Console.Clear();
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Создан круг");
                        circle = new Circle();
                        circle.AreaAndPerimeter();
                        Console.WriteLine($"Площадь: {circle.Area()}");
                        Console.WriteLine($"Периметр: {circle.Perimeter()}");
                        break;
                    case 2:
                        Console.WriteLine("Создан прямоугольник");
                        rectangle = new Rectangle();
                        rectangle.AreaAndPerimeter();
                        Console.WriteLine($"Площадь: {rectangle.Area()}");
                        Console.WriteLine($"Периметр: {rectangle.Perimeter()}");
                        break;
                }
                Console.WriteLine("Введите \"-\" есдли хотите закончить.");
                sBreak = Console.ReadLine();
            }
        }
    }
}
