using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    class UserInfo : IUserInfo
    {
        /// <summary>
        /// Print User Info method That Prints User Details , like Name,id,Age and address 
        /// </summary>
        /// <param name="person"></param>
        public void PrintUserInfo(IPerson person)
        {
            Console.WriteLine("\n\n..............User Info ..................");
            Console.WriteLine($"Post : Employee \nUser Name : {person.Name} \nId : {person.Id}\nAge : {person.Age}\n" +
                $"Address : {person.Address}");

        }
    }
}
