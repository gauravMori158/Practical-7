using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple
{
    public interface ILogger
    {
        public void Info(string message);
        public void Warn(string message);
        public void Error(string message , Exception ex);

    }
    class LoggerClass1 : ILogger
    {
        public LoggerClass1()
        {
            Console.WriteLine("1. Login");
        }
        public void Info(string message )
        {
            Console.WriteLine("Message : " + message);
        }
        public void Warn (string message ) {

            Console.WriteLine("Warn :" + message);
        }
        public void Error(string message ,Exception ex ) {

            Console.WriteLine(message   + "  "+ ex.Message);
        }
    }
}
