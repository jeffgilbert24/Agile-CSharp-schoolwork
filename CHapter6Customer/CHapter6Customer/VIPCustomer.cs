// defines the VIP customer
using System;
using System.Collections.Generic;

namespace CHapter6Customer
{
    class VIPCustomer:Customer
    {
        // constructor
        public VIPCustomer(string customerId, string customerName)
            : base(customerId, customerName)
        {            
        }
        // override MakePurchased() Method
        public override void MakePurchase(decimal purchaseAmount)
        {
            if(purchaseAmount > 0m && AccumulatedPurchase > 1000m)
            {
                CurrentPurchaseAmount = purchaseAmount;
                base.MakePurchase(purchaseAmount * (1 - VIPDiscountRate));
            }else if (purchaseAmount > 0m)
            {
                CurrentPurchaseAmount = purchaseAmount;
                base.MakePurchase(purchaseAmount);
            }
        }
        // override ToString() method
        public override string ToString()
        {
            return base.ToString();
            {
                string str;
                str = base.ToString();
                if(AccumulatedPurchase >= 1000m)
                    str += string.Format("You saved {0:C} as an VIP.",
                        CurrentPurchaseAmount*VIPDiscountRate);
                return str;
            }
        }
    }
}
