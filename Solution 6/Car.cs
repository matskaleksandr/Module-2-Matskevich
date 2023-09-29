using System;

namespace Solution_6
{
    class Car
    {
        public string Brand { get; set; }//cвойство для марки автомобиля
        public string Model { get; set; }//cвойство для модели автомобиля
        public int Year { get; set; }//cвойство для года выпуска автомобиля
        public double Price { get; set; }//cвойство для цены автомобиля
        public Car(string brand, string model, int year, double price)//конструктор для создания объекта класса Car с заданными параметрами
        {
            Brand = brand;
            Model = model;
            Year = year;
            Price = price;
        }
        public double CalculatePriceWithDiscount(double discountPercentage)//метод для расчета цены с учетом скидки
        {
            //проверка на допустимость процента скидки
            if (discountPercentage < 0 || discountPercentage > 100)
            {
                throw new ArgumentException("Процент скидки должен быть от 0 до 100.");
            }
            //расчёт цены с учетом скидки
            double discountedPrice = Price - (Price * (discountPercentage / 100));
            return discountedPrice;
        }
        //метод для расчёта цены с учетом налога
        public double CalculatePriceWithTax(double taxPercentage)
        {
            //проверка на допустимость процента налога
            if (taxPercentage < 0)
            {
                throw new ArgumentException("Процент должен быть неотрицательным значением.");
            }
            //расчет цены с учетом налога
            double priceWithTax = Price + (Price * (taxPercentage / 100));
            return priceWithTax;
        }
    }
}
