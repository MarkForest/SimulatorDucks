using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.ducks
{
    public abstract class Duck
    {
        public void swim()
        {
            Console.WriteLine("I can swiming!");
        }

        public abstract void display();
    }
}
