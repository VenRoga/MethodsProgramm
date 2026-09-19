using ConsoleApp1.Generation.FactoryMenhod;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Generation
{
    internal class ClassB : ILogger
    {
        ILogger Ilogger;


        public ClassB()
        {
            Logger log = Logger.GetInstance();
            log.Log("Class B was init");

            Console.WriteLine(log.GetHashCode());
        }

        public void Log(string message) 
        {

        }
    }
}
