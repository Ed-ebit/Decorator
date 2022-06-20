using facade_for_decorator.Decorator;

namespace facade_for_decorator {
    class Program
    {
        public static void Main()
        {
            string choiceCoffee = "";
            string choiceAddition = "";
            while (true) {
                Console.WriteLine("bitte Kaffeesorte aussuchen:\n 1 Großer Kaffee\n2 Americano\n3 Espreso");
                choiceCoffee = Console.ReadLine();
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

                Brew(choiceCoffee, choiceAddition);
            }

        }
    }
}