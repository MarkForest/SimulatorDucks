using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Behaviors
{
    public class Quack : iQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Quack Quack");
        }
    }
}
