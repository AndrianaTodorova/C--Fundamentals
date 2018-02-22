using System.Collections.Generic;
using System.Runtime.CompilerServices;

class Trainer
{
    private string name;
    private int badges;
    private List<Pokemon> pokemons;

    public Trainer(string name)
    {
        this.name = name;
        this.badges = 0;
        this.pokemons = new List<Pokemon>();

    }

    public List<Pokemon> Pokemons
    {
        get { return this.pokemons; }
        set { this.pokemons = value; }
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public int Badge
    {
        get { return this.badges; }
        set { this.badges = value; }
    }

    public override string ToString()
    {
        return $"{this.name} {this.badges} {this.Pokemons.Count}";
    }
}
