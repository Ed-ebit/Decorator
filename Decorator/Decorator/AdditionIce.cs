﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace facade_for_decorator
{
    public class AdditionIce : IAdditions
    {
        public ICoffeeBar CoffeeBar { get; set; }

        public void MakeCoffee() {
            CoffeeBar.MakeCoffee();
            Console.WriteLine("Ice has been added, new function triggered:\n" +
                "It's called THE WATERING :D " + watering());
        }
        public string watering() {
            return "\n Your drink is being watered because u like to have less taste than other ppl!";
        }

    }
}