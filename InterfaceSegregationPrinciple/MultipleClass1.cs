using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    internal class MultipleClass1 : ILogin , IHomePage, IPrintUserInfo
    {

        /// <summary>
        /// IPrintUserInfo interface MultipleClass1 PrintInfo Method
        /// </summary>
        /// <param name="message"></param>
        public void PrintUserInfo(string message)
        {
            Console.WriteLine("IPrintUserInfo interface MultipleClass1 PrintInfo Method : " + message);
        }

        /// <summary>
        /// IPrintUserInfo interface MultipleClass1 AboutInfo Method
        /// </summary>
        /// <param name="message"></param>
        public void AboutInfo(string message)
        {
            Console.WriteLine("IPrintUserInfo interface MultipleClass1 AboutInfo Method : " + message);
        }
        /// <summary>
        /// IHomepage interface MultipleClass1
        /// </summary>
        /// <param name="message"></param>
        public void HomeMethod(string message)
        {
            Console.WriteLine("IHomepage interface MultipleClass1  : Message " + message);
        }
        /// <summary>
        /// ILogin interface : MultipleClass1
        /// </summary>
        /// <param name="message"></param>
        public void LoginMessage(string message)
        {
            Console.WriteLine("ILogin interface : MultipleClass1 \t Message " + message);
        }
    }
}
