using System;

namespace Solution_4
{
    class Triangle : IDrawable
    {
        private int iR1 = 0;//переменная для хранения первой стороны
        private int iR2 = 0;//переменная для хранения второй стороны
        private int iR3 = 0;//переменная для хранения третьей стороны
        public Triangle(int iR1, int iR2, int iR3)//конструктор класса
        {
            this.iR1 = iR1;
            this.iR2 = iR2;
            this.iR3 = iR3;
        }
        public void Draw()
        {
            Console.WriteLine($"Прямоугольник:\nСторона 1: {iR1}\nСторона 2: {iR2}\nСторона 3: {iR3}\n");//вывод информации о трёх сторнах треугольника
        }
    }
}
