using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    public  class DiscountClass1
    {
        /// <summary>
        /// Double Discount Method That Calculates General Discount For Every Amount
        /// </summary>
        /// <param name="amount"></param>
        /// <returns>Double Amount</returns>
        public virtual double  Discount(double amount)
        {
            return  amount -  amount * 0.01  ;
        }
    }

    public class HdfcCardDiscount : DiscountClass1
    { /// <summary>
      /// Double Discount Method That Calculates HDFC Bank Cradit Card Discount For Every Amount
      /// </summary>
      /// <param name="amount"></param>
      /// <returns>Double Amount</returns>
        public override double Discount (double amount)
        {          
            return  base.Discount(amount) -  amount * 0.05;         
        }
}

    public class SBICardDiscount : DiscountClass1
    {/// <summary>
     /// Double Discount Method That Calculates SBI Bank Cradit Card Discount For Every Amount
     /// </summary>
     /// <param name="amount"></param>
     /// <returns>Double Amount</returns>
        public override double Discount(double amount)
        {
            return base.Discount(amount) - amount * 0.03;

        }
    }
}
