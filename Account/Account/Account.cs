using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Account
    {
        string accName;
        string accId;
        double balance;

        public string AccName
        {
            set { accName = value; }
            get { return accName; }
        }

        public string Accid
        {
            set { accId = value; }
            get { return accId; }
        }

        public double Balance
        {
            set { balance = value; }
            get { return balance; }
        }

        public Account(string accName, string accid, double balance)
        {
            this.accName = accName;
            this.accId=accid;
            this.balance = balance;
        }
        public void Deposit(double amount)
        {
            balance = balance + amount;
            {
                Console.WriteLine("Money Addition complete");
            }
        }

        public void Withdraw(double amount)
        {
            balance = balance - amount;
            {
                Console.WriteLine("Money Deduction complete");
            }
        }
    }
}
