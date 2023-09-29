using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_5
{
    class Thermostat
    {
        public void Heating(object sender, TemperatureChangedEventArgs e)
        {
            double temperature = e.NewTemperature;
            Console.Clear();
            if (temperature >= 20)
            {
                Console.WriteLine($"Текущая температура - {temperature}°C < 20°C. Выключаем отопление.");
            }
            if (temperature < 20)
            {
                Console.WriteLine($"Текущая температура - {temperature}°C > 20°C. Включаем отопление.");
            }
        }
    }
}
