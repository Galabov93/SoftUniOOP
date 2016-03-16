using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy.Employees
{
    public class SalesEmployee : Employee
    {
        public SalesEmployee(string id, string firstName, string lastName, Department depart, List<Sale> sales)
            : base(id, firstName, lastName, depart)
        {
        }

        public class Sale
        {
            private string productName;
            private DateTime date;
            private decimal price;

            public Sale(string productName, DateTime date, decimal price)
            {
                this.ProductName = productName;
                this.Date = date;
                this.Price = price;
            }

            public string ProductName
            {
                get { return this.productName; }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException("Product name cannot be null or empty.");
                    }
                    if (value.Length < 3 || value.Length > 20)
                    {
                        throw new ArgumentOutOfRangeException("Product name shoud be in range [3 ... 20].");
                    }

                    this.productName = value;
                }
            }

            public DateTime Date
            {
                get { return this.date; }
                set
                {
                    if (value.Year < 0)
                    {
                        throw new ArgumentException("Year cannot be negative.");
                    }

                    this.date = value;
                }
            }

            public decimal Price
            {
                get { return this.price; }
                set
                {
                    if (value < 0)
                    {
                        throw new ArgumentException("Price cannot be negative.");
                    }

                    this.price = value;
                }
            }

            public override string ToString()
            {
                return String.Format("{1} \n\r{0} - {2}", this.ProductName, this.Date, this.Price);
            }
        }
    }
}

