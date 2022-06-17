using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public class CoffeeBarEspresso : ICoffeeBar
    {
        public void MakeCoffee()
        {
            Console.WriteLine("I'm an Espresso!");
        }
    }
}