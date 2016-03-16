using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfKurtovoKonare.Accounts
{
    public class Deposit : Account
    {
        public Deposit(Customer cust, double balance, double interestRate) : base(cust, balance, interestRate)
        {
        }

        public override double CalculateInterest(int months)
        {
            if (this.Balance < 1000)
            {
                return 0;
            }
            return this.Balance * (1 + this.InterestRate * months);
        }

        public void WithdrawMoney(int amount)
        {
            this.Balance -= amount;
        }


    }
}
