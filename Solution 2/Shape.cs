using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_2
{
    abstract class Shape
    {
        private double area = 0;
        private double perimeter = 0;
        public double Area_
        {
            get { return area; }
            set { area = value; }
        }
        public double Perimeter_
        {
            get { return perimeter; }
            set { perimeter = value; }
        }
        public double Area()
        {
            return area;
        }
        public double Perimeter()
        {
            return perimeter;
        }
    }
}
