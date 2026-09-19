using ConsoleApp1.Generation;
using ConsoleApp1.Generation.AbstractFactory;
using ConsoleApp1.Generation.FactoryMenhod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Singlton.Run();
            //Prototype.Run();
            //FactoryMethod.Run();
            AbstractFactory.Run();
        }
    }
}
