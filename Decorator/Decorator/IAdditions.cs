using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace facade_for_decorator
{
    public interface IAdditions : ICoffeeBar
    {
        public ICoffeeBar CoffeeBar { get; set; }
    }
}