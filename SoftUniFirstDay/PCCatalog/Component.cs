using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCatalog
{
    public class Component
    {
        private string name;
        private decimal price;
        private string details;


        public Component() : this(null, 0, null)
        {
        }


        public Component(string name, decimal price)
        {
            Name = name;
            PriceDecimal = price;
        }

        public Component(string name, decimal price, string details) : this(name, price)
        {
            Name = name;
            PriceDecimal = price;
            this.details = details;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public decimal PriceDecimal
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", Name, PriceDecimal, details);
        }
    }
}
