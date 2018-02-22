using System;
using System.Collections.Generic;
using System.Linq;

public class Topping
{
    private const int MIN_WEIGHT = 1;
    private const int MAX_WEIGHT = 50;
    private const int DEFAULT_MULTIPLIER = 2;
    private Dictionary<string, double> validTypeAndCalories = new Dictionary<string, double>
    {
        ["meat"] = 1.2,
        ["veggies"] = 0.8,
        ["cheese"] = 1.1,
        ["sauce"] = 0.9

    };
    private string type;
    private double weight;

    public Topping(string type, double weight)
    {
        this.Type = type;
        ValidateWeight(type, weight);
        this.Weight = weight;
    }

    private double Multiplier => validTypeAndCalories[this.Type];
    public double Calories => DEFAULT_MULTIPLIER * this.Weight * Multiplier;
    private void ValidateWeight(string type, double weight)
    {
        if (weight < MIN_WEIGHT || weight > MAX_WEIGHT)
        {
            throw new ArgumentException($"{type} weight should be in the range [{MIN_WEIGHT}..{MAX_WEIGHT}].");
        }
    }

    public string Type
    {
        get { return this.type; }
        set
        {
            if (!this.validTypeAndCalories.Any(f => f.Key == value.ToLower()))
            {
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            }
            this.type = value.ToLower();
        }
    }
    public double Weight
    {
        get { return this.weight; }
        set
        {
            this.weight = value;
        }
    }
}