using System;
using System.Collections.Generic;
using System.Linq;

public class Dough
{
    private const int MIN_WEIGHT = 1;
    private const int MAX_WEIGHT = 200;
    private const int DEFAULT_MULTIPLIER = 2;
    private Dictionary<string, double> validFlourTypes = new Dictionary<string, double>
    {
        ["white"] = 1.5,
        ["wholegrain"] = 1.0
    };
    private Dictionary<string, double> validBakingTechniques = new Dictionary<string, double>
    {
        ["crispy"] = 0.9,
        ["chewy"] = 1.1,
        ["homemade"] = 1.0
    };
    private double weight;
    private string flourType;
    private string bakingTechnique;

    public Dough( string flourType, string bakingTechnique, double weight)
    {
        this.Weight = weight;
        this.FlourType = flourType;
        this.BakingTechnique = bakingTechnique;
    }

    private double FlourMultiplier => validFlourTypes[this.FlourType];
    private double BakingTechniqueMultiplier => validBakingTechniques[this.BakingTechnique];
    public double Calories => DEFAULT_MULTIPLIER * this.Weight * FlourMultiplier * BakingTechniqueMultiplier;
    public double Weight
    {
        get { return this.weight; }
        set
        {
            if (value < MIN_WEIGHT || value > MAX_WEIGHT)
            {
                throw new ArgumentException($"Dough weight should be in the range [{MIN_WEIGHT}..{MAX_WEIGHT}].");
            }
            this.weight = value;
        }
    }
    public string FlourType
    {
        get { return this.flourType; }
        set
        {
            if (!this.validFlourTypes.Any(f => f.Key == value.ToLower()))
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            this.flourType = value.ToLower();
        }
    }
    public string BakingTechnique
    {
        get { return this.bakingTechnique; }
        set
        {
            if (!this.validBakingTechniques.Any(f => f.Key == value.ToLower()))
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            this.bakingTechnique = value.ToLower();
        }
    }
}
