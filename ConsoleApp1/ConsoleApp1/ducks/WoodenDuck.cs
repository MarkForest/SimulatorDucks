﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Behaviors;
namespace ConsoleApp1.ducks
{
    public class WoodenDuck : Duck
    {
        public override void display()
        {
            Console.WriteLine("Hello i am Wooden Duck");
        }
        public WoodenDuck()
        {
            iFly = new NoFly();
            iQuack = new NoQuack();
        }
        
    }
}
