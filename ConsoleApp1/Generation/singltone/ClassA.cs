using ConsoleApp1.Generation.FactoryMenhod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Generation
{
    internal class ClassA : ILogger
    {
        ILogger ILogger;



        public ClassA()
        {    
            Logger log = Logger.GetInstance();
            log.Log("Class A was init");

            Console.WriteLine(log.GetHashCode());
        }

        public void Log(string message)
        {
            ILogger.Log(message);
        }
    }
}
