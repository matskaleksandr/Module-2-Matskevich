using System;

namespace Solution_5
{
    class Program
    {
        static void Main()
        {
            TemperatureSensor sensor = new TemperatureSensor();
            Thermostat thermostat = new Thermostat();
            sensor.TemperatureChanged += thermostat.Heating;
            string sTemp = "";
            int iTemp = 0;
            while (true) 
            { 
                do
                {
                    Console.WriteLine("Введите температуру");
                    sTemp = Console.ReadLine();
                }
                while (!int.TryParse(sTemp, out iTemp));
                sensor.CurrentTemperature = iTemp;
            }
        }
    }
}