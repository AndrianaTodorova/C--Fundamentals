using System;
using System.Linq;

namespace _03.CountUppcaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Func<string, bool> checker = n => n[0] == n.ToUpper()[0];
            text.Where(checker).ToList().ForEach(n => Console.WriteLine(n));
        }
    }
}
