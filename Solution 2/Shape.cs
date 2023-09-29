namespace Solution_2
{
    abstract class Shape
    {
        private double area = 0;//переменная для хранения площади
        private double perimeter = 0;//переменная для хранения периметра
        public double Area_//get/set значения площади
        {
            get { return area; }
            set { area = value; }
        }
        public double Perimeter_//get/set значения периметра
        {
            get { return perimeter; }
            set { perimeter = value; }
        }
        public double Area()//метод для возвращения площади
        {
            return area;
        }
        public double Perimeter()//метод для возвращения периметра
        {
            return perimeter;
        }
    }
}
