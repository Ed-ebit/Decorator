﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace facade_for_decorator
{
    public class AdditionMilk : IAdditions
    {
        public ICoffeeBar CoffeeBar { get; }


        public AdditionMilk(ICoffeeBar coffeeBar)
        {
            CoffeeBar = coffeeBar;
        }


        public void MakeCoffee()
        {
            CoffeeBar.MakeCoffee();

            Console.WriteLine("Milk has been added");

        }
    }
}