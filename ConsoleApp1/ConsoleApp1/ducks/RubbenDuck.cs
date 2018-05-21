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

        public override void fly(){}
        public override void quack() {
            Console.WriteLine("Squck Squck");
        }
    }
}
