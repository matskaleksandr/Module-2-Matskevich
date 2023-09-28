using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_4
{
    interface IDrawable
    {
        void Draw();
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IDrawable[] IDD = new IDrawable[3];
            IDD[0] = new Circle(19);
            IDD[1] = new Rectangle(10, 20);
            IDD[2] = new Triangle(8, 32, 11);
            for(int i = 0; i < 3; i++)
            {
                IDD[i].Draw();
            }
        }
    }
    class Circle : IDrawable
    {
        private int radius = 0;
        public Circle(int radius)
        {
            this.radius = radius;
        }

        public void Draw()
        {
            Console.WriteLine($"Круг:\nРадиус: {radius}\n");
        }
    }
    class Rectangle : IDrawable
    {
        private int width = 0;
        private int height = 0;
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public void Draw()
        {
            Console.WriteLine($"Прямоугольник:\nШирина: {width}\nВысота: {height}\n");
        }
    }
    class Triangle : IDrawable
    {
        private int iR1 = 0;
        private int iR2 = 0;
        private int iR3 = 0;
        public Triangle(int iR1, int iR2, int iR3)
        {
            this.iR1 = iR1;
            this.iR2 = iR2;
            this.iR3 = iR3;
        }
        public void Draw()
        {
            Console.WriteLine($"Прямоугольник:\nСторона 1: {iR1}\nСторона 2: {iR2}\nСторона 3: {iR3}\n");
        }
    }
}
