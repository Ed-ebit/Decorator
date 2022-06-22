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
            string instanciateCoffee = "facade_for_decorator.CoffeeBar" + choiceCoffee;// + ", facade_for_decorator";
            Console.WriteLine(instanciateCoffee);
            Type coffee = Type.GetType(instanciateCoffee);
            Console.WriteLine(Type.GetType(instanciateCoffee));
            Console.WriteLine(typeof(CoffeeBarAmericano).AssemblyQualifiedName);
            //string coffee = "Coffeebar" + choiceCoffee;
            //Type addition = Type.GetType("Addition" + choiceAddition);
            if (coffee == null)
            {
                throw new Exception("verkackt");
            }
            else
            {

                ICoffeeBar kaffee = (ICoffeeBar)Activator.CreateInstance(coffee);
            }

            //ICoffeeBar zusatz = (IAdditions)Activator.CreateInstance(addition);
            //zusatz.MakeCoffee(); 

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
