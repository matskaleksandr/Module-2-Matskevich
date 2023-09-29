using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_5
{
    class TemperatureSensor
    {
        private double currentTemperature;
        public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;
        public double CurrentTemperature
        {
            get { return currentTemperature; }
            set
            {
                if (currentTemperature != value)
                {
                    currentTemperature = value;
                    OnTemperatureChanged(new TemperatureChangedEventArgs(value));
                }
            }
        }
        protected virtual void OnTemperatureChanged(TemperatureChangedEventArgs eventTemp)
        {
            TemperatureChanged?.Invoke(this, eventTemp);
        }
    }
}
