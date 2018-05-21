using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.ducks;
using ConsoleApp1.Behaviors;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>();
            ducks.AddRange(new Duck[] {
                new MallardDuck(),
                new RedHeadDuck(),
                new RubbenDuck(),
                new WoodenDuck()
            });
            

            foreach (var duck in ducks)
            {
                duck.display();
                duck.swim();
                duck.perfomeFly();
                duck.perfomeQuack();
                Console.WriteLine("===============");
            }

            ducks[3].setFlyBehavior(new RocketPowered());
            Console.WriteLine();
            foreach (var duck in ducks)
            {
                duck.display();
                duck.swim();
                duck.perfomeFly();
                duck.perfomeQuack();
                Console.WriteLine("===============");
            }
            Console.ReadKey();

        }
    }
}
