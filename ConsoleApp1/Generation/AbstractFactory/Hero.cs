using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Generation.AbstractFactory
{
    internal class Hero
    {
        public string Name { get; }   
        IHit hit;
        IMove move;

        public Hero(IHit hit, IMove move, string name)
        {
            this.hit = hit;
            this.move = move;
            Name = name;
        }
        public void Hit()
        {
            hit.Hit();
        }
        public void Move() 
        {
            move.Move();
        }
    }
}
