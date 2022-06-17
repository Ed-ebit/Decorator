using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator.Decorator
{
    public class AdditionSugar : IAdditions
    {
        public ICoffeeBar CoffeeBar { get ; set ; }

        private string state;
        public AdditionSugar(ICoffeeBar coffeeBar)
        {
            CoffeeBar = coffeeBar;
            state = "sweeetened";
        }

        public void MakeCoffee()
        {
            CoffeeBar.MakeCoffee();
            Console.WriteLine("sugar has been added.");
            Console.WriteLine(" new state acquired: " + state);
        }
    }
}