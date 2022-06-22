
namespace facade_for_decorator {
    class Program
    {
        
        public static void Main()
        {

            //ICoffeeBar kaffee = new TallCoffee();
            //IAdditions zusatz = new AdditionMilk(kaffee);
            //zusatz.MakeCoffee();
            //zusatz = new AdditionSugar(kaffee);
            //zusatz.MakeCoffee();
            //zusatz = new AdditionIce(kaffee);
            //zusatz.MakeCoffee();
        string choiceCoffee = "";
            string choiceAddition = "";
            List<string> choiceList = new List<string>()
            {
                "1",
                "2",
                "3",
            };
            while (true) {
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
                        choiceAddition = "Milch";
                        break;
                    case "2":
                        choiceAddition = "Zucker";
                        break;
                    case "3":
                        choiceAddition = "Eiswürfel";
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