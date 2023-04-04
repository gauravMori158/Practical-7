using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{   
    
      class ExecutableClass1
    {
         
        public static void Main(string[] args)
        {
            Console.WriteLine("Actual Price : 10,000");

            DiscountClass1 discountClass1 = new DiscountClass1();
            double discount = discountClass1.Discount(10000);
            Console.WriteLine("General Discount " + discount);

            Console.WriteLine("Discount Based On Bank Card ");

            DiscountClass1 HdfcDiscount = new HdfcCardDiscount();
            discount = HdfcDiscount.Discount(10000);
            Console.WriteLine("HDFC Card Discount " + discount);

            DiscountClass1 SbiDiscount = new SBICardDiscount();
            discount = SbiDiscount.Discount(10000);
            Console.WriteLine("SBI Card Discount " + discount);



        }
    }
}
