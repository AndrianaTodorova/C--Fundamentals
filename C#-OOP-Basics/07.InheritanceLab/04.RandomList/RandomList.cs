using System;
using System.Collections.Generic;

public class RandomList : List<string>
{
    private Random rnd;

    public RandomList(Random rnd)
    {
        this.rnd = rnd;
    }

    public string RandomString()
    {
        int index = this.rnd.Next(0, base.Count - 1);
        var str = base[index];
        base.RemoveAt(index);
        return str;
    }
   
}