using System;
public class Kitten : Animals
{
    private const string Gender = "Female";
    public Kitten(string name, int age) : base(name, age, Gender)
    {
    }

    public override string ProduceSound()
    {
        return "Meow";
    }
}