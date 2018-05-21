using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Behaviors;

namespace ConsoleApp1.ducks
{
    public abstract class Duck
    {
        public iFlyBehavior iFly;
        public iQuackBehavior iQuack;
        public void swim()
        {
            Console.WriteLine("I can swiming!");
        }

        public abstract void display();

        public void perfomeQuack()
        {
            iQuack.quack();
        }

        public void setFlyBehavior(iFlyBehavior iFly)
        {
            this.iFly = iFly;
        }

        public void perfomeFly()
        {
            iFly.fly();
        }
    }
}
