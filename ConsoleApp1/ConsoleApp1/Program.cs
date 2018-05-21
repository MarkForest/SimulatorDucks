using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.ducks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck mallardDuck = new MallardDuck();
            RedHeadDuck redHeadDuck = new RedHeadDuck();
            RubbenDuck rubbenDuck = new RubbenDuck();
            WoodenDuck woodenDuck = new WoodenDuck();

            mallardDuck.display();
            mallardDuck.swim();
            mallardDuck.quack();
            mallardDuck.fly();
            Console.WriteLine("==============");
            redHeadDuck.display();
            redHeadDuck.swim();
            redHeadDuck.quack();
            redHeadDuck.fly();
            Console.WriteLine("==============");
            rubbenDuck.display();
            rubbenDuck.swim();
            rubbenDuck.quack();
          
            Console.WriteLine("==============");
            woodenDuck.display();
            woodenDuck.swim();
    
            Console.ReadKey();

        }
    }
}
