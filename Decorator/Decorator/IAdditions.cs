using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator.Decorator
{
    public interface IAdditions : ICoffeeBar
    {
        public ICoffeeBar CoffeeBar { get; }
    }
}