using System;

namespace Solution_5
{
    class Thermostat
    {
        //метод обрабатывающий событие изменения температуры
        public void Heating(object sender, TemperatureChangedEventArgs e)
        {
            double temperature = e.NewTemperature;//получение новой температуры из аргумента события
            Console.Clear();//очистка консоли
            //проверяем температуру и выводим соответствующее сообщение
            if (temperature >= 20)
            {
                Console.WriteLine($"Текущая температура - {temperature}°C < 20°C. Выключаем отопление.");
            }
            else
            {
                Console.WriteLine($"Текущая температура - {temperature}°C > 20°C. Включаем отопление.");
            }
        }
    }
}
