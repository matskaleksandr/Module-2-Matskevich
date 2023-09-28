using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_2
{
    class Rectangle : Shape
    {
        private double dLength;
        private string sLength;
        private double dWidth;
        private string sWidth;
        public void AreaAndPerimeter()
        {
            do
            {
                do
                {
                    Console.WriteLine("Введите длина:");
                    sLength = Console.ReadLine();
                }
                while (!double.TryParse(sLength, out dLength));
            }
            while (dLength < 0);

            do
            {
                do
                {
                    Console.WriteLine("Введите ширину:");
                    sWidth = Console.ReadLine();
                }
                while (!double.TryParse(sWidth, out dWidth));
            }
            while (dWidth < 0);

            base.Area_ = dWidth * dLength;
            base.Perimeter_ =  dWidth + dWidth + dLength + dLength;
        }
    }
}
