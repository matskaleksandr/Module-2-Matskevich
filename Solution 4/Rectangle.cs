using System;

namespace Solution_4
{
    class Rectangle : IDrawable
    {
        private int width = 0;//переменная для хранения ширины
        private int height = 0;//перемнная для хранения высоты
        public Rectangle(int width, int height)//конструктор класса
        {
            this.width = width;
            this.height = height;
        }
        public void Draw()
        {
            Console.WriteLine($"Прямоугольник:\nШирина: {width}\nВысота: {height}\n");//вывод информации ширины и высоты
        }
    }
}
