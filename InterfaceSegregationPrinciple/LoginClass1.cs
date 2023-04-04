using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{   
      class LoginClass1 : ILogin
    {/// <summary>
    /// LoginMethod That Provides Class and interface Information
    /// </summary>
    /// <param name="message"></param>
        public void LoginMessage(string message)
        {
            Console.WriteLine("ILogin interface : LoginClass1 \t Message " + message);
        }
    }
}
