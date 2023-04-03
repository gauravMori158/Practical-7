using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
      class HomeClass1 : IHomePage
    {
        /// <summary>
        /// home Method that displays Inteface imformation
        /// </summary>
        /// <param name="message"></param>
        public void HomeMethod(string message)
        {
            Console.WriteLine("IHomepage interface HomeClass1  : Message "+message);
        }
    }
}
