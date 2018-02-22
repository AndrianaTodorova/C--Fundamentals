using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ShoppingSpree
{
    class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                string[] inputPerson = Console.ReadLine().Split(new [] {';', ' '},StringSplitOptions.RemoveEmptyEntries);

                List<Person> persons = new List<Person>();
                for (int i = 0; i < inputPerson.Length; i++)
                {

                    string[] data = inputPerson[i].Split('=');
                    string name = data[0];
                    decimal money = decimal.Parse(data[1]);
                    Person person = new Person(name, money);
                    persons.Add(person);
                }

                string[] inputProduct = Console.ReadLine().Split(new[] { ';', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                List<Product> products = new List<Product>();
                for (int i = 0; i < inputProduct.Length; i++)
                {
                    string[] data = inputProduct[i].Split('=');
                    string name = data[0];
                    decimal cost = decimal.Parse(data[1]);
                    var product = new Product(name, cost);
                    products.Add(product);
                }

                string output = Console.ReadLine();
                while (output != "END")
                {
                    string[] split = output.Split(' ');
                    string namePerson = split[0];
                    string productsName = split[1];
                    Person currentPerson = persons.First(p => p.Name == namePerson);
                    Product currentProduct = products.First(p => p.Name == productsName);
                    string outputPrint = currentPerson.TryBuyProduct(currentProduct);
                    Console.WriteLine(outputPrint);
                    output = Console.ReadLine();

                }

                foreach (var person in persons)
                {
                    Console.WriteLine(person);
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
           
        }
    }
}
