using System;
using System.Collections.Generic;

namespace PCCatalog
{
    public class Computer
    {
        private List <Component> componentsList;

        public Computer(string name, List<Component> components )
        {
            Name = name;
            this.componentsList = components;
        }


        public Computer(decimal price, string name)
        {
            this.Price = price;
            Name = name;
        }

        public decimal Price { get; set; }

        public string Name { get; set; }

        public List<Component> Components
        {
            get { return this.componentsList; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("You must add one component to run this program!");
                }
                this.componentsList = value;
            }
        }

        public decimal CalculateThePrice()
        {
            foreach (var I in componentsList)
            {
                this.Price += I.PriceDecimal;
            }

            return this.Price;
        }


        public override string ToString()
        {
            string output = "Computer name: " + this.Name + "\n\n";
            foreach (var component in this.componentsList)
            {
                output += component.ToString();
            }
            decimal prc = CalculateThePrice();
            output += "Computer price: " + prc + " lv.\n-----------------------------\n";
            return output;
        }
    }
}
