using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfKurtovoKonare
{
    public abstract class Account : IAccountInterest
    {
        private Customer customer;
        private double balance;
        private double interestRate;

        public Account(Customer customer, double balance, double interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public double Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Balance cannot be negative");
                }
                this.balance = value;
            }
        }

        public double InterestRate
        {
            get
            {
                return this.interestRate;
            }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Interest rate cannot be negative nor larger than 100");
                }
                this.interestRate = value;
            }
        }

        public Customer Customer
        {
            get
            {
                return this.customer;
            }

            set
            {
                this.customer = value;
            }
        }

        public void depositMoney(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("The amount of money deposit can't be negative");
            }
            this.balance += amount;
        }

        public abstract double CalculateInterest(int months);

        public override string ToString()
        {
            return String.Format("Acount: {0} Balance: {1}\nInterest rate: {2}",
                this.GetType().Name, this.balance, this.interestRate);
        }
    }
}
