using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator.Decorator
{
    public class AdditionIce : IAdditions
    {
        public ICoffeeBar CoffeeBar { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void MakeCoffee() { }
    }
}