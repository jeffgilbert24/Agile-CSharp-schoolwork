using System;
using System.Collections.Generic;
using static System.Console;
using static System.Convert;

namespace Chapter6Challenge6._2Banking
{
    class BankAccount
    {
        // fields
        private string accountNumber;
        private string customerId;
        private decimal openingBalance;
        // properties
        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }
        public string CustomerID
        {
            get { return customerId; }
            set { customerId = value; }
        }
        public decimal OpeningBalance
        {
            get { return openingBalance; }
            set { openingBalance = value; }
        }
        public BankAccount(string accontNumber, string customerId, decimal openingBalance)
        {
            this.accountNumber = accountNumber;
            this.customerId = customerId;
            this.openingBalance = openingBalance;
        }
        public override string ToString()
        {
            string str;
            str = string.Format($"Number:{AccountNumber} id:{CustomerID} Balance:{OpeningBalance}");
            return str;
        }


    }
}
