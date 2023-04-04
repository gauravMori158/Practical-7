using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple
{
      class MailSenderClass1
    {
        public string MailFrom { get; set; }
        public string MailTo { get; set; }
        public string MailBody { get; set; }
        public string MailSubject { get; set; }

        public void SendMail()
        {
            Console.WriteLine("From " + MailFrom);
            Console.WriteLine("To "+MailTo);
            Console.WriteLine("Body " +MailBody);
            Console.WriteLine("Subject " + MailSubject);

        }
    }
}
