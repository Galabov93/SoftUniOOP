using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfKurtovoKonare.Accounts
{
    class Mortage : Account
    {
        public Mortage(Customer customer, double balance, double interestRate)
           : base(customer, balance, interestRate)
        {
        }

        public override double CalculateInterest(int months)
        {
            double interest = this.Balance * (1 + this.InterestRate * months);
            if (months < 6 && this.Customer == Customer.Individual)
            {
                return 0;
            }
            else if (months < 12 && this.Customer == Customer.Company)
            {
                return this.InterestRate = interest / 2;
            }
            return this.InterestRate = interest;
        }
    }
}
