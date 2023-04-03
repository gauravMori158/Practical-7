using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    class HighLevelClass   : IHighLevelClass
    {
        public string Message { get; set; }

        public  IPerson person { get; set; }

        /// <summary>
        /// Method That Makes Reference of logger type using that it will call the
        /// LoginMessage Method 
        /// </summary>
        public void MailSender()
        {
            ILogger logger =  Factory.GetLogger();
            logger.LoginMessage(person, "Login Successfull ... ");
        }
        /// <summary>
        /// Method That Makes Reference of userInfo type using that it will call the
        /// PrintUserInfo Method 
        /// </summary>
        public void PrintUser()
        {
            IUserInfo userInfo =  Factory.GetUserInfo();
            userInfo.PrintUserInfo(person  );
        }

    }
}
