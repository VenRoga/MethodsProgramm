using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Generation.AbstractFactory
{
    internal class AbstractFactory
    {
        public static void Run()
        {
            Hero pudge = HeroFactory.CreatePudge();
            Hero viper = HeroFactory.CreateViper();
            Hero ranger = HeroFactory.CreateRanger();

            pudge.Hit();
            viper.Hit();
            ranger.Hit();

            pudge.Move();
            viper.Move();
            ranger.Move();
        }
    }
}
