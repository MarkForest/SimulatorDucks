using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.intarfaces;

namespace ConsoleApp1.ducks
{
    public class RubbenDuck : Duck, iQuackable
    {
        public override void display()
        {
            Console.WriteLine("Hello i am Rubben Duck");
        }
        public  void quack() {
            Console.WriteLine("Squck Squck");
        }
    }
}
