using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator.Decorator
{
    public class AdditionMilk : IAdditions
    {

        public ICoffeeBar CoffeeBar { get; set; }

        
        public void MakeCoffee()
        {
            CoffeeBar.MakeCoffee();

            Console.WriteLine("Milk has been added");

        }
    }
}