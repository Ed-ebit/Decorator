using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace facade_for_decorator
{
    public class CoffeeBarEspresso : ICoffeeBar
    {
        public void MakeCoffee()
        {
            Console.WriteLine("I'm an Espresso!");
        }
    }
}