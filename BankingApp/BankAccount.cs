using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    class BankAccount
    {
        public string CustomerName { set; get; }
        public string AccountNo { set; get; }
        public double Balance {private set; get; }

        public string Deposit(double amount)
        {
            Balance += amount;
            return "Deposited"+ amount;
        }

        public string withdraw(double amount)
        {
            Balance -= amount;
            return "withdrawn";
        }
    }
}
