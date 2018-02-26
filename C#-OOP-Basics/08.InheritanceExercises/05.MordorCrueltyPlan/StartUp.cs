using System;
using System.Linq;

namespace _05.MordorCrueltyPlan
{
    class StartUp
    {
        static void Main(string[] args)
        {

            Gandalf gand = new Gandalf();
            gand.Eat(Console.ReadLine().Split().Where(fn => fn != string.Empty).Select(fn => FoodFactory.GetFood(fn)));
            Console.WriteLine(gand);
        }
    }
}
