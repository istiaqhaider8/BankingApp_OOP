using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    class SavingAccount:BankAccount
    {
        public double InterestAmount { set; get; }

        public override string withdraw(double amount)
        {
           if(Balance-amount > 0)
            {
                return base.withdraw(amount);
            }
            else
            {
                return " you have enough balance";
            }
        }
    }
}
