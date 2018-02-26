using System;
public abstract class Animals
{
    private string name;
    private int age;
    private string gender;

    protected Animals(string name, int age, string gender)
    {
        Name = name;
        Age = age;
        Gender = gender;
    }

    public string Name
    {
        get { return this.name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Invalid input!");
            }
            this.name = value;
        }
    }

    public int Age
    {
        get { return this.age; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Invalid input!");
            }
            this.age = value;
        }
    }

    public string Gender
    {
        get { return this.gender; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Invalid input!");
            }
            this.gender = value;
        }
    }

    public abstract string ProduceSound();
    public override string ToString()
    {
        return $"{this.GetType().Name}{Environment.NewLine}{this.name} {this.age} {this.gender}{Environment.NewLine}{this.ProduceSound()}";
    }
}