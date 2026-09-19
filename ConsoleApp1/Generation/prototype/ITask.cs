using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Generation
{
    internal interface ITask
    {
        string GetDescription();
        ITask Clone();
    }
}
