using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Generation.AbstractFactory
{
    internal class Fly : IMove
    {
        public void Move()
        {
            Console.WriteLine("I fly");
        }
    }
}
