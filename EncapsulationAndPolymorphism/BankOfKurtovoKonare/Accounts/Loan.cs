using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfKurtovoKonare.Accounts
{
    public class Loan : Account
    {
        public Loan(Customer cust, double balance, double interestRate) : base(cust, balance, interestRate)
        {

        }

        public override double CalculateInterest(int months)
        {
            if (months < 3 && this.Customer == Customer.Individual)
            {
                return 0;
            }
            else if (months < 2 && this.Customer == Customer.Company)
            {
                return 0;
            }
            return this.Balance * (1 + this.InterestRate * months);
        }
    }
}
