using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public class CoffeBarTallCoffe : ICoffeeBar
    {
        public void MakeCoffee()
        {
            Console.WriteLine("I'm a Tall Coffee!");
        }
    }
}