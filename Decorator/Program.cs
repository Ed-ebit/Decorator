using Decorator.Decorator;

namespace Decorator {
    class Program
    {
        public static void Main()
        {
            ICoffeeBar kaffee = new CoffeeBarAmericano();
            IAdditions zusatz = new AdditionMilk(kaffee);
            zusatz.MakeCoffee();
            zusatz = new AdditionSugar(kaffee);
            zusatz.MakeCoffee();
            zusatz = new AdditionIce(kaffee);
            zusatz.MakeCoffee();

        }
    }
}