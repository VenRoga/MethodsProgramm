using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Generation.builder
{
    internal class Builder
    {
        public void Run()
        {
            Building building = new Worker().foundation("Foundation1")
                .walls("walls1")
                .roof("roof1")
                .interior("interior1")
                .build();
        }
    }
}
