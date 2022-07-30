using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //BankAccount aBankAccount = new BankAccount();
            //aBankAccount.CustomerName = "Istiaq Haider";
            //aBankAccount.AccountNo = "123123";
            //aBankAccount.Deposit(1233);
            //double balance = aBankAccount.Balance;


            SavingAccount aSavingAccount = new SavingAccount();
            aSavingAccount.CustomerName = "Tofiq Akba";
            aSavingAccount.AccountNo = "123433";
            aSavingAccount.Deposit(127312);
            double abalance = aSavingAccount.Balance;
        }
    }
}
