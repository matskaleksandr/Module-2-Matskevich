using System;

namespace Solution_5
{
    class TemperatureChangedEventArgs : EventArgs
    {
        //свойство представляющее новую температуру
        public double NewTemperature { get; }
        //конструктор класса, принимающий новую температуру
        public TemperatureChangedEventArgs(double newTemperature)
        {
            NewTemperature = newTemperature;//инициализация свойства новой температурой
        }
    }
}
