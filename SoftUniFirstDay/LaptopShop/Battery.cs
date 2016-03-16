using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop
{
    public class Battery
    {
        private string batteryType;
        private double batteryLife;

        public string BatteryType
        {
            get
            {
                return this.batteryType;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("No data!! Enter information model of the battery");
                }

                this.batteryType = value;
            }
        }

        public double BatteryLife
        {
            get
            {
                return this.BatteryLife;
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Error!! Enter an actual battery lifetime");
                }

                this.batteryLife = value;
            }
        }

        public Battery(string batteryType, double batteryLife)
        {
            this.BatteryType = batteryType;
            this.BatteryLife = batteryLife;
        }

        public Battery(string batteryType)
        {
            this.BatteryType = batteryType;

        }

        public Battery()
        {
                
        }
    }
}

