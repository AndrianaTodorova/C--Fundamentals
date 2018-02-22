using System;
using System.Collections.Generic;
using System.Linq;

public class StackOfStrings
{
    private List<string> data;

    public void Push(string item)
    {
        this.data.Add(item);
    }

    public string Pop()
    {
        var element = this.data.Last();
        this.data.Remove(element);
        return element;
    }

    public string Peek()
    {
        var element = this.data.Last();
        return element;
    }

    public bool IsEmpty()
    {
        return this.data.Count == 0;
    }
}