using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laptop_Shop
{
    public class Battery
    {
        protected string battery;
        protected double batteryLife;
        public double BatteryLife
        {
            get
            {
                return this.batteryLife;
            }
            set
            {
                if (batteryLife < 0)
                {
                    throw new ArgumentException("Battery life Cannot be negative");
                }
                this.batteryLife = value;
            }
        }
        public string BatteryType
        {
            get
            {
                return this.battery;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Battery name cannot be empty or null");
                }
                this.battery = value;
            }
        }

    }
}
