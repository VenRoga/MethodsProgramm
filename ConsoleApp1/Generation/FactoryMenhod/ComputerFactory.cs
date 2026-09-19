using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Generation.FactoryMenhod
{
    internal class ComputerFactory
    {
        public static IComputer CreateNewComputer()
        {
            return new NewComputer();
        }
        public static IComputer CreateOldComputer()
        {
            return new OldComputer();
        }
    }
}
