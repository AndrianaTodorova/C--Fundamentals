using System;
using System.Collections.Generic;
using System.Linq;

public class Pizza
{
    private const int MIN_LENGTH = 1;
    private const int MAX_LENGTH = 15;
    private const int MIN_TOPPINGS = 0;
    private const int MAX_TOPPINGS = 10;
    private string name;

    public Pizza()
    {
        this.Topping = new List<Topping>();
    }
    public Pizza(string name)
    :this()
    {
        this.Name = name;
    }

    private double ToppingCalories
    {
        get
        {
            if (this.Topping.Count == 0)
            {
                return 0;
            }

            return this.Topping.Select(t => t.Calories).Sum();
        }
    }

    private double Calories => this.Dough.Calories + this.ToppingCalories;
    private string Name
    {
        get { return this.name; }
        set
        {
            if (string.IsNullOrEmpty(value) || value.Length > MAX_LENGTH)
            {
                throw new ArgumentException($"Pizza name should be between {MIN_LENGTH} and {MAX_LENGTH} symbols.");
            }
            this.name = value;
        }
    }

    private Dough Dough { get; set; }
    private List<Topping> Topping { get; set; }

    public void SetDought(Dough dough)
    {
        if (this.Dough == null)
        {
            this.Dough = dough;
        }
     
    }
    public void AddTopping(Topping topping)
    {
        this.Topping.Add(topping);
        if (this.Topping.Count > MAX_TOPPINGS)
        {
            throw new ArgumentException($"Number of toppings should be in range [{MIN_TOPPINGS}..{MAX_TOPPINGS}].");
        }
    }

    public override string ToString()
    {
        return $"{this.Name} - {this.Calories:f2} Calories.";
    }
}