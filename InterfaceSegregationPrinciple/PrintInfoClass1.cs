using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
      class PrintInfoClass1 : IPrintUserInfo
    {/// <summary>
     /// IPrintUserInfo interface PrintinfoClass1 PrintInfo Method
     /// </summary>
     /// <param name="message"></param>
        public void PrintUserInfo(string message)
        {
            Console.WriteLine("IPrintUserInfo interface PrintinfoClass1 PrintInfo Method : " + message);
        }
        /// <summary>
        /// IPrintUserInfo interface PrintinfoClass1 AboutInfo Method
        /// </summary>
        /// <param name="message"></param>
        public void AboutInfo(string message)
        {
            Console.WriteLine("IPrintUserInfo interface PrintinfoClass1 AboutInfo Method : " + message);
        }
        
    }
}
