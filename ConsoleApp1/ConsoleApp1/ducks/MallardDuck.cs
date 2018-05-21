using ConsoleApp1.intarfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ducks
{
    public class MallardDuck : Duck, iQuackable, iFlyable
    {
        public override void display()
        {
            Console.WriteLine("Hello i am Mallard Duck");
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
