using System;

namespace Solution_4
{
    class Circle : IDrawable
    {
        private int radius = 0;//переменная радиуса круга
        public Circle(int radius)
        {
            this.radius = radius;
        }
        public void Draw()
        {
            Console.WriteLine($"Круг:\nРадиус: {radius}\n");//вывод радиуса круга
        }
    }
}
