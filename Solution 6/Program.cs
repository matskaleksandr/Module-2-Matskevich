using System;

namespace Solution_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //создание объекта автомобиля
            Car car = new Car("Toyota", "Corolla", 2023, 25000);
            double discountedPrice = car.CalculatePriceWithDiscount(25);//рассчёт стоимости с учетом скидки 25%
            Console.WriteLine("Стоимость автомобиля с учетом скидки: $" + discountedPrice);
            double priceWithTax = car.CalculatePriceWithTax(5);//расчёт стоимости с учетом налога на добавленную стоимость 5%
            Console.WriteLine("Стоимость автомобиля с учетом налога: $" + priceWithTax);
        }
    }
}
