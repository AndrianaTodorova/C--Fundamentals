using System.Collections.Generic;

public class Person
{
    private string name;
    private string birth;
    private List<Person> parents;
    private List<Person> children;

    public Person()
    {
    }

    public Person(string name, string birth)
    {
        this.Name = name;
        this.BirthDay = birth;
        this.Parents = new List<Person>();
        this.Children = new List<Person>();
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }
    public string BirthDay
    {
        get { return this.birth; }
        set { this.birth = value; }
    }

    public List<Person> Parents
    {
        get { return this.parents; }
        set { this.parents = value; }
    }
    public List<Person> Children
    {
        get { return this.children; }
        set { this.children = value; }
    }

}