using ConsoleApp1.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1.ducks
{
    public class RubbenDuck : Duck
    {
        public override void display()
        {
            Console.WriteLine("Hello i am Rubben Duck");
        }

        public RubbenDuck()
        {
            iFly = new NoFly();
            iQuack = new Squack();
        }
 
    }
}
