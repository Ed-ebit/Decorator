using facade_for_decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facade_for_decorator
{
    public class Facade
    {        
        public static void Brew(string choiceCoffee, string choiceAddition)
        {
            Type coffee = Type.GetType("CoffeeBar" + choiceCoffee);
            //string coffee = "Coffeebar" + choiceCoffee;
            Type addition = Type.GetType("Addition" + choiceAddition);
            ICoffeeBar kaffee = (ICoffeeBar)Activator.CreateInstance(coffee);
            ICoffeeBar zusatz = (IAdditions)Activator.CreateInstance(addition);
            zusatz.MakeCoffee(); 

        }

        //ICoffeeBar kaffee = new TallCoffee();
        //IAdditions zusatz = new AdditionMilk(kaffee);
        //zusatz.MakeCoffee();
        //zusatz = new AdditionSugar(kaffee);
        //zusatz.MakeCoffee();
        //zusatz = new AdditionIce(kaffee);
        //zusatz.MakeCoffee();
    }
}
