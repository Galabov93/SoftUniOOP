using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop
{

    class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private int ram;
        private string graphicsCard;
        private string _HDD;
        private string screen;
        private decimal price;
        private Battery battery;
       
        
        public Laptop(string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
        }


        public Laptop(string model, decimal price, string manufacturer, string processor, int ram,
            string graphicsCard, string hdd, string screen, string battery , double batteryLife) : this(model, price)
        {
            this.Model = model;
            this.Price = price;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.RamMemory = ram;
            this.GraphicsCard = graphicsCard;
            this.HardDrive = hdd;
            this.Screen = screen;
            this.battery = new Battery(battery, batteryLife);

        }


        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("No data!! Enter information on model of the laptop");
                }

                this.model = value;
            }
        }
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("No data!! Enter information for the manufacturer of the laptop");
                }

                this.manufacturer = value;
            }
        }
        public string Processor
        {
            get
            {
                return this.processor;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("No data!! Enter information for the processor of the laptop");
                }

                this.processor = value;
            }
        }
        public string GraphicsCard
        {
            get
            {
                return this.graphicsCard;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("No data!! Enter information for the graphic card of the laptop");
                }

                this.graphicsCard = value;
            }
        }
        public string HardDrive
        {
            get
            {
                return this._HDD;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("No data!! Enter information for the hdd of the laptop");
                }

                this._HDD = value;
            }
        }
        public int RamMemory
        {
            get
            {
                return this.ram;

            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Enter a positive number for ram memory");

                this.ram = value;
            }



        }
        public string Screen
        {
            get
            {
                return this.screen;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("No data!! Enter information for the screen of the laptop");
                }

                this.screen = value;
            }
        }
        public decimal Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Error!! Enter an actual price");
                }

                this.price = value;
            }
        }


        public override string ToString()
        {
            return String.Format("");
        }
    }
}
