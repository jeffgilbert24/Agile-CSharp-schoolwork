using System;
using System.Collections.Generic;

namespace CHapter6Customer
{
    class MemberCustomer:Customer
    {
        // constructor
        public MemberCustomer(string employeeId, string employeeName)
            :base(employeeId, employeeName)
        {
        }
        // override MakePurchase() method
        public override void MakePurchase(decimal purchaseAmount)
        {
            if(purchaseAmount >0.0m)
            {
                CurrentPurchaseAmount = purchaseAmount;
                base.MakePurchase(purchaseAmount * (1 - memberDiscountRate));
            }
        }
        // ToString method
        public override string ToString()
        {
            string str;
            str = base.ToString() + string.Format("You saved {0:C} as a member.",
                CurrentPurchaseAmount * memberDiscountRate);
            if (AccumulatedPurchase > 1000m)
                str += string.Format("\nYou are qualified as a VIP customer. Please talk to a manage.");
            return str;
        }

    }
}
