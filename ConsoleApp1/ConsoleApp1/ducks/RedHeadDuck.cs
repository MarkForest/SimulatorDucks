using ConsoleApp1.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1.ducks
{
    public class RedHeadDuck : Duck
    {
        public override void display()
        {
            Console.WriteLine("Hello i am RedHead Duck");
        }
        public RedHeadDuck()
        {
            iFly = new FlyWithWings();
            iQuack = new Quack();
        }

    }
}
