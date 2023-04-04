using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    class Execution
    {
     
        public static void Main()
        {
            IPerson person = Factory.GetPerson();

            person.Name = "Mori";
            person.Age = 21;
            person.Address = "BVN";
            person.Id = 1;
            

            IHighLevelClass highLevelClass = Factory.GetHighLevelClass();
            highLevelClass.person = person ;
            highLevelClass.MailSender();
            highLevelClass.PrintUser();
 


        }
    }
}
