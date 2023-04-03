using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
     public interface ILogin
    {
           
        public void LoginMessage(string message);
    }

    public interface IHomePage
    {
        public void HomeMethod(string message);
    }

    public interface IPrintUserInfo
    {
        public void PrintUserInfo(string name);
        public void AboutInfo(string message);
    }
}
