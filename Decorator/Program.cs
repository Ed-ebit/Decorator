
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
                Console.WriteLine("bitte Kaffeesorte aussuchen:\n 1 Großer Kaffee\n2 Americano\n3 Espreso");
                choiceCoffee = Console.ReadLine();
                if (!choiceList.Contains(choiceCoffee))
                {
                    Console.WriteLine("ungültige Eingabe");
                    Thread.Sleep(800);
                } 

                    if (choiceCoffee == "1")
                {
                    choiceCoffee = "TallCoffee";
                    break;
                }
                if (choiceCoffee == "2")
                {
                    choiceCoffee = "Americano";
                    break;
                }
                if (choiceCoffee == "3")
                {
                    choiceCoffee = "Espresso";
                    break;
                }
                else
                {
                    Console.WriteLine("ungültige Eingabe");
                    Thread.Sleep(800);
                }
            }
            while (true)
            {
                Console.WriteLine("bitte Zusatz aussuchen:\n 1 Milch\n2 Zucker\n3 Eiswürfel");
                choiceAddition = Console.ReadLine();
                if (choiceAddition == "1")
                {
                    choiceAddition = "Milk";
                    break;
                }
                if (choiceAddition == "2")
                {
                    choiceAddition = "Sugar";
                    break; 
                }
                if (choiceAddition == "3")
                {
                    choiceAddition = "Ice";
                    break;
                }
                else
                {
                    Console.WriteLine("ungültige Eingabe");
                    Thread.Sleep(800);
                }
            }
            Facade.Brew(choiceCoffee, choiceAddition);

        }
    }
}