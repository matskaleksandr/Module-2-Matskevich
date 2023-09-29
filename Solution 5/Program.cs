using System;

namespace Solution_5
{
    class Program
    {
        static void Main()
        {
            TemperatureSensor sensor = new TemperatureSensor();//создание объекта датчика температуры
            Thermostat thermostat = new Thermostat();//создание объекта термостата
            //подписываем метод Heating объекта термостата на событие TemperatureChanged датчика температуры
            sensor.TemperatureChanged += thermostat.Heating;
            string sTemp = "";//переменная для хранения введенной пользователем температуры
            int iTemp = 0;//переменная для хранения температуры
            while (true)
            {
                do
                {
                    Console.WriteLine("Введите температуру");//Вывод сообщения для пользователя о вводе температуры
                    sTemp = Console.ReadLine();//считывание введенной пользователем температуры в виде строки
                }
                while (!int.TryParse(sTemp, out iTemp));//проверка что введенное значение является числом
                sensor.CurrentTemperature = iTemp;//установка текущей температуры датчика температуры
            }
        }
    }
}
