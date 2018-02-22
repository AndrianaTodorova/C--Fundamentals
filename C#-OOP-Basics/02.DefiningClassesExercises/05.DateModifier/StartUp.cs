using System;
class StartUp
{
    static void Main()
    {
        string firstDate = Console.ReadLine();
        string secondDate = Console.ReadLine();

        Console.WriteLine(DateModifier.GetDifference(firstDate, secondDate));
    }
}
