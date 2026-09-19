using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Generation.FactoryMenhod
{
    internal class NewComputer : IComputer
    {
        public void Run()
        {
            Console.WriteLine("windows init");
        }
        public void Stop()
        {
            Console.WriteLine("windows stop");
        }
    }
}
