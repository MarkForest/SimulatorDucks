
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Behaviors;

namespace ConsoleApp1.ducks
{
    public class MallardDuck : Duck
    {
        public override void display()
        {
            Console.WriteLine("Hello i am Mallard Duck");
        }

        public MallardDuck()
        {
            iFly = new FlyWithWings();
            iQuack = new Quack();
        }
    }
}
