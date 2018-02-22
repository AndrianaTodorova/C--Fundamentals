using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Person
{
    private string name;
    private Company company;
    private Car car;
    private List<Pokemons> pokemons;
    private List<Parents> parents;
    private List<Children> children;

    public Person(string name)
    {
        this.Name = name;
        this.Pokemons = new List<Pokemons>();
        this.Parents = new List<Parents>();
        this.Children = new List<Children>();
    }

    public Car Car
    {
        get { return this.car; }
        set { this.car = value; }
    }

    public List<Children> Children
    {
        get { return this.children; }
        set { this.children = value; }
    }

    public List<Parents> Parents
    {
        get { return this.parents; }
        set { this.parents = value; }
    }

    public List<Pokemons> Pokemons
    {
        get { return this.pokemons; }
        set { this.pokemons = value; }
    }

    public Company Company
    {
        get { return this.company; }
        set { this.company = value; }
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(this.name);

        sb.AppendLine("Company:");
        if (this.company != null)
        {
            sb.AppendLine(this.company.ToString());
        }

        sb.AppendLine("Car:");
        if (this.car != null)
        {
            sb.AppendLine(this.car.ToString());
        }

        sb.AppendLine("Pokemon:");
        if (this.pokemons.Count > 0)
        {
            sb.AppendLine(string.Join(Environment.NewLine, this.pokemons.Select(pok => pok.ToString())));
        }

        sb.AppendLine("Parents:");
        if (this.parents.Count > 0)
        {
            sb.AppendLine(string.Join(Environment.NewLine, this.parents.Select(par => par.ToString())));
        }

        sb.AppendLine("Children:");
        if (this.children.Count > 0)
        {
            sb.AppendLine(string.Join(Environment.NewLine, this.children.Select(c => c.ToString())));
        }

        return sb.ToString();
    }
}
