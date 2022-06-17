using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator.Decorator
{
    public class AdditionIce : IAdditions
    {
        public ICoffeeBar CoffeeBar {get; set;}
        public AdditionIce(ICoffeeBar coffeeBar)
        {
            CoffeeBar = coffeeBar;
        }

        public void MakeCoffee() {
            CoffeeBar.MakeCoffee();
            Console.WriteLine("Ice has been added, new function triggered:\n" +
                "THE WATERING :D " + watering());
        }
        public string watering() {
            return "\n your drink is being watered because u like to have less taste than other ppl!";
        }

    }
}