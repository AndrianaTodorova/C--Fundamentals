using System;

namespace _02.BookShop
{
    class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                string author = Console.ReadLine();
                string title = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());

                Book book = new Book(title,author,price);
                GoldenEditionBook goldenEditionBook = new GoldenEditionBook(title,author,price);

                Console.WriteLine(book);
                Console.WriteLine(goldenEditionBook);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
