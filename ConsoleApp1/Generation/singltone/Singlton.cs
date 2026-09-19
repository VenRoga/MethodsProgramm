using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Generation
{
    internal class Singlton
    {
        public static void Run()
        {
            ClassA classA = new ClassA();
            ClassB classB = new ClassB();
            ClassB classB1 = new ClassB();
            ClassB classB2 = new ClassB();
            ClassB classB3 = new ClassB();
            ClassB classB4 = new ClassB();
            ClassB classB5 = new ClassB();
            ClassB classB6 = new ClassB();
        }
    }
}
