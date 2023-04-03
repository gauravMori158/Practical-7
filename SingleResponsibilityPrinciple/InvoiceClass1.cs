using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple
{
      class InvoiceClass1
    {
        public int InvAmount { get; set; }
        public DateTime InvDate { get; set; }

        public ILogger logerInterface;
        public MailSenderClass1 mailSender;

        public InvoiceClass1()
        {
            logerInterface = new LoggerClass1();
            mailSender= new MailSenderClass1();
        }

        public void AddInvoice ()
        {
            try {
            
                logerInterface.Info(" Process Started ... " +DateTime.Now);
                mailSender.MailFrom = "gkmori@abc.com";
                mailSender.MailTo = "mori@asd.com";
                mailSender.MailBody = "Hi from Sender";
                mailSender.MailSubject = " Fun Mail ";
                mailSender.SendMail();
            }

            catch(Exception ex)
            {
                 logerInterface.Error("Error While Generating Invoice " ,ex);
            }


        }
        public void RemoveInvoice ()
        {
            try
            {
                logerInterface.Info("Removing Process ... " + DateTime.Now);
            }
            catch (Exception ex)
            {
                logerInterface.Error("Error while Removing Invoice ", ex);
            }
        }
    }
}
