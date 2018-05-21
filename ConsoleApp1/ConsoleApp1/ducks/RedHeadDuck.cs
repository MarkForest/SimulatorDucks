using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.intarfaces;

namespace ConsoleApp1.ducks
{
    public class RedHeadDuck : Duck, iQuackable, iFlyable
    {
        public override void display()
        {
            Console.WriteLine("Hello i am RedHead Duck");
        }

        public void fly()
        {
            Console.WriteLine("I can fly");
        }

        public void quack()
        {
            Console.WriteLine("Quack Quack");
        }
    }
}
