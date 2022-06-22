using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace facade_for_decorator
{
    public class AdditionSugar : IAdditions
    {
        public ICoffeeBar CoffeeBar { get; set; }

        private string state;

        public void MakeCoffee()
        {
            CoffeeBar.MakeCoffee();
            Console.WriteLine("sugar has been added.");
            Console.WriteLine(" new state acquired: " + state);
        }
    }
}