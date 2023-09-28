using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_2
{
    class Circle : Shape
    {
        private double dRadius;
        private string sRadius;
        public void AreaAndPerimeter()
        {
            do
            {
                do
                {
                    Console.WriteLine("Введите радиус:");
                    sRadius = Console.ReadLine();
                }
                while (!double.TryParse(sRadius, out dRadius));
            }
            while (dRadius < 0);
            base.Area_ = Math.PI* dRadius *dRadius;
            base.Perimeter_ = Math.PI * dRadius;
        }
    }
}
