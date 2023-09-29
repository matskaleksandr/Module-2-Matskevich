using System;

namespace Solution_5
{
    class TemperatureSensor
    {
        private double currentTemperature;//поле для хранения текущей температуры
        public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;//событие возникающее при изменении температуры
        //свойство для доступа к текущей температуре
        public double CurrentTemperature
        {
            get { return currentTemperature; }
            set
            {
                //проверка изменилась ли температура
                if (currentTemperature != value)
                {
                    //обновление текущей температуры
                    currentTemperature = value;
                    //генерация события при изменении температуры
                    OnTemperatureChanged(new TemperatureChangedEventArgs(value));
                }
            }
        }
        //метод для генерации события изменения температуры
        protected virtual void OnTemperatureChanged(TemperatureChangedEventArgs eventTemp)
        {
            //Вызов события
            TemperatureChanged?.Invoke(this, eventTemp);
        }
    }
}
