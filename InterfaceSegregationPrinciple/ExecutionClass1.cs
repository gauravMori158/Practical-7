using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
     
      class ExecutionClass1
    {
        public static void Main(string[] args)
        {
            
            LoginClass1 loginClass1= new LoginClass1();
            loginClass1.LoginMessage("Login successfull ...");

            HomeClass1 homeClass1= new HomeClass1();
            homeClass1.HomeMethod("Body Of Home");
            PrintInfoClass1 printInfoClass1 = new PrintInfoClass1();
            printInfoClass1.AboutInfo("Gaurav Mori");
            printInfoClass1.PrintUserInfo("User1 101");

            MultipleClass1 multipleClass1= new MultipleClass1();
            multipleClass1.LoginMessage("Login successfull ... Multi Class");
            multipleClass1.HomeMethod("Body Of Home Multi Class");
            multipleClass1.AboutInfo("Gaurav Mori Multi Class");
            multipleClass1.PrintUserInfo("User1 101 Multi Class");
        }
    }
}
