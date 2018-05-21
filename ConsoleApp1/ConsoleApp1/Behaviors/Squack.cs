using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Behaviors
{
    public class Squack : iQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Squack Squack");
        }
    }
}
