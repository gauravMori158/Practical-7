using SolidPrinciple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
      class ExecutionClass1
    {
        public static void Main(string[] args)
        {
            InvoiceClass1 invoiceClass1 = new InvoiceClass1();
            invoiceClass1.AddInvoice();
            invoiceClass1.RemoveInvoice();
        }
    }
}
