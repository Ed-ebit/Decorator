using facade_for_decorator.Decorator;
using facade_for_decorator.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facade_for_decorator.Facade
{
    public class Facade
    {
        public Facade()
        {
            
        }
        
        public static void Brew(string choiceCoffee, string choiceAddition)
        {
            Type coffee = Type.GetType("CoffeeBar" + choiceCoffee);
            Type addition = Type.GetType("Addition" + choiceAddition);

            addition.MakeCoffee();

        }

        //ICoffeeBar kaffee = new CoffeeBarAmericano();
        //IAdditions zusatz = new AdditionMilk(kaffee);
        //zusatz.MakeCoffee();
        //zusatz = new AdditionSugar(kaffee);
        //zusatz.MakeCoffee();
        //zusatz = new AdditionIce(kaffee);
        //zusatz.MakeCoffee();
    }
}
