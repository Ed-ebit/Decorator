using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace facade_for_decorator
{
    public class CoffeeBarAmericano : ICoffeeBar
    {
        public void MakeCoffee()
        {
            Console.WriteLine("I'm a Coffee Americano!");
        }
    }
}