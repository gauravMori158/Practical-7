using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    class Logger : ILogger
    {
        /// <summary>
        /// It prints user info based on login details
        /// </summary>
        /// <param name="person"></param>
        /// <param name="message"></param>
        public string LoginMessage(IPerson person, string message)
        {
            return $"{message}\nUser Name : {person.Name} \nId : {person.Id}\n";
        }
    }
}
