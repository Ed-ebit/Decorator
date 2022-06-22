
namespace facade_for_decorator
{
    class Program
    {


        //public enum CoffeeList
        //{
        //    TallCoffee = 1,
        //    Americano = 2,
        //    Espresso = 3,
        //};
        //public enum AdditionList
        //{
        //    Milk = 1,
        //    Sugar = 2,
        //    Ice = 3,
        //};


        public static void Main()
        {

            string choiceCoffee = "";
            string choiceAddition = "";
            while (true)
            {
                Console.WriteLine("bitte Kaffeesorte aussuchen:\n 1 Großer Kaffee\n2 Americano\n3 Espresso");
                choiceCoffee = Console.ReadLine();
                switch (choiceCoffee)
                {
                    case "1":
                        choiceCoffee = "TallCoffee";
                        break;
                    case "2":
                        choiceCoffee = "Americano";
                        break;
                    case "3":
                        choiceCoffee = "Espresso";
                        break;
                    default:
                        Console.WriteLine("ungültige Eingabe");
                        Thread.Sleep(800);
                        continue;
                }
                break;
            }
            //case (!choiceList.Contains(choiceCoffee)):
            //    Console.WriteLine("ungültige Eingabe");
            //    Thread.Sleep(800);

            while (true)
            {
                Console.WriteLine("bitte Zusatz aussuchen:\n 1 Milch\n2 Zucker\n3 Eiswürfel");
                choiceAddition = Console.ReadLine();
                switch (choiceAddition)
                {
                    case "1":
                        choiceAddition = "Milk";
                        break;
                    case "2":
                        choiceAddition = "Sugar";
                        break;
                    case "3":
                        choiceAddition = "Ice";
                        break;
                    default:
                        Console.WriteLine("ungültige Eingabe");
                        Thread.Sleep(800);
                        continue;
                }
                break;
            }
            Facade.Brew(choiceCoffee, choiceAddition);

        }
    }
}