using System;

namespace _05.PizzaCalories
{
    class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                string pizzaName = Console.ReadLine().Split()[1];
                Pizza pizza = new Pizza(pizzaName);
                Dough dough = CreateDough();
                pizza.SetDought(dough);

                string command;
                while ((command = Console.ReadLine()) != "END")
                {
                    CreateTopping(command, pizza);
                }

                Console.WriteLine(pizza);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static Dough CreateDough()
        {
            string[] doughtInput = Console.ReadLine().Split();
            string flourType = doughtInput[1];
            string bakingTechnique = doughtInput[2];
            double doughWeight = double.Parse(doughtInput[3]);

            Dough dough = new Dough(flourType, bakingTechnique, doughWeight);
            return dough;
        }

        static void CreateTopping(string command, Pizza pizza)
        {

            string[] toppingInput = command.Split();
            string toppingName = toppingInput[1];
            double toppingWeight = double.Parse(toppingInput[2]);

            Topping topping = new Topping(toppingName, toppingWeight);
            pizza.AddTopping(topping);
        }
    }
}
