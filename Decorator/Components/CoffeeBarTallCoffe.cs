﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace facade_for_decorator
{
    public class CoffeeBarTallCoffe : ICoffeeBar
    {
        public void MakeCoffee()
        {
            Console.WriteLine("I'm a Tall Coffee!");
        }
    }
}