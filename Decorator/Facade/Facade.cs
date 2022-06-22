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
            ICoffeeBar coffee;
            IAdditions addition;
            string instanciateCoffee = "facade_for_decorator.CoffeeBar" + choiceCoffee + ", facade_for_decorator";
            //Console.WriteLine(instanciateCoffee);
            Type coffeeType = Type.GetType(instanciateCoffee);

            string instanciateAddition = "facade_for_decorator.Addition" + choiceAddition + ", facade_for_decorator";
            Type additionType = Type.GetType(instanciateAddition);
            //Console.WriteLine(Type.GetType(instanciateAddition));
            //Console.WriteLine(typeof(CoffeeBarAmericano).AssemblyQualifiedName);
            //string coffee = "Coffeebar" + choiceCoffee;
            //Type addition = Type.GetType("Addition" + choiceAddition);
            if (coffeeType == null)
            {
                throw new Exception("verkackt");
            }
            else
            {
                coffee = (ICoffeeBar)Activator.CreateInstance(coffeeType);
            }

            if (additionType == null)
            {
                throw new Exception("verkackt");
            }
            else
            {
                addition = (IAdditions)Activator.CreateInstance(additionType);//braucht Parameterlosen Konstruktor :/
            }
            addition.CoffeeBar = coffee;
            addition.MakeCoffee(); 

        }
    }
}
