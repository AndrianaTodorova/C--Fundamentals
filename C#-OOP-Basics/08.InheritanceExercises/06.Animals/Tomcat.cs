using System;
public class Tomcat : Animals
{
    private const string Gender = "Male";
    public Tomcat(string name, int age) : base(name, age, Gender)
    {
    }

    public override string ProduceSound()
    {
        return "MEOW";
    }
}