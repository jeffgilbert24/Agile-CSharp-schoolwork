using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHapter6Customer
{
    class Customer
    {
        // fields
        public const decimal VIPDiscountRate = 0.10m;
        public const decimal memberDiscountRate = 0.05m;
        private string customerID;
        private string customerName;
        private decimal accumalatedPurchase;
        private decimal currentPurchaseAmount;
        // properties
        public string CustomerId
        {
            get { return customerID; }
            set { customerID = value; }
        }
        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }
        public decimal CurrentPurchaseAmount
        {
            get { return currentPurchaseAmount; }
            set { currentPurchaseAmount = value; }
        }
        public decimal AccumulatedPurchase
        {
            get { return accumalatedPurchase; }
            set { accumalatedPurchase = value; }
        }
        // constructor
        public Customer(string customerId, string customerName)
        {
            this.customerID = customerID;
            this.customerName = customerName;
            accumalatedPurchase = 0.0m;
        }
        // methods
        public virtual void MakePurchase(decimal purchaseAmount)
        {
            if(purchaseAmount > 0)
            {
                AccumulatedPurchase += purchaseAmount;
            }
        }
        // ToString()method
        public override string ToString()
        {
            string str;
            str = string.Format("{0}: Total Purchase this year {1:C}", customerName,
                AccumulatedPurchase);
            return str;
        }
    }
}
