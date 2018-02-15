using System;

namespace _04.HotelReservation
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split();
            decimal pricePerDay = decimal.Parse(command[0]);
            int numberOfDays = int.Parse(command[1]);
            Season seasons = (Season)Enum.Parse(typeof(Season), command[2]);
            Discount discount = Discount.None;
            if (command.Length > 3)
            {
                discount = (Discount) Enum.Parse(typeof(Discount), command[3]);
            }
            PriceCalculator priceCalc = new PriceCalculator();
            string total = priceCalc.Calculate(pricePerDay, numberOfDays, seasons, discount);
            Console.WriteLine(total);

        }
    }
}
