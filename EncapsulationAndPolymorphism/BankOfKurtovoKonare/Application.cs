using BankOfKurtovoKonare.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfKurtovoKonare
{
   public class Application
    {
        static void Main(string[] args)
        {
            Account acc = new Deposit(Customer.Individual,22,2);
            Account acc1 = new Loan(Customer.Company, 230, 6);
            Account acc2 = new Mortage(Customer.Individual, 230, 26);
            Account acc3 = new Deposit(Customer.Company, 230, 16);
            Account acc4 = new Loan(Customer.Individual, 230, 67);
            Account acc5 = new Loan(Customer.Company, 21230, 6);
            Account acc6 = new Deposit(Customer.Company, 30, 60);
            Account acc7 = new Loan(Customer.Company, 23220, 6);

            List<IAccountInterest> listOfAccounts = new List<IAccountInterest>();
            listOfAccounts.Add(acc);
            listOfAccounts.Add(acc1);
            listOfAccounts.Add(acc2);
            listOfAccounts.Add(acc3);
            listOfAccounts.Add(acc4);
            listOfAccounts.Add(acc5);
            listOfAccounts.Add(acc6);
            listOfAccounts.Add(acc7);

            foreach (var item in listOfAccounts)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }



        }
    }
}
