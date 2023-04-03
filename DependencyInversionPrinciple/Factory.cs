using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
      static class Factory
    {
        public static IPerson GetPerson()
        {
            return new Person();
        }

        public static IUserInfo GetUserInfo()
        {
            return new AdminInfo();
        }

        public static ILogger GetLogger()
        {
            return new Logger();    
        }

        public static IHighLevelClass GetHighLevelClass()
        {
            return new HighLevelClass();
        }

    }
}
