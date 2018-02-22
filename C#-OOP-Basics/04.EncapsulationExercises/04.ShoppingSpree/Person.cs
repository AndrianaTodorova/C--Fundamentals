using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class Person
{
    private string name;
    private decimal money;
    private List<Product> products;

    public Person()
    {
        this.Products = new List<Product>();
    }
    public Person(string name, decimal money)
    :this()
    
    {
        this.Name = name;
        this.Mone = money;
      
    }

    public string Name
    {
        get { return this.name; }
       set
        {
            if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name cannot be empty");
            }

            this.name = value;
        }
    }

    public decimal Mone
    {
        get { return this.money; }
        set {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }

            this.money = value;
        }
    }

    public List<Product> Products
    {
        get { return this.products; }
        set { this.products = value; }
    }

    public string TryBuyProduct(Product product)
    {
        if (this.Mone < product.Cost)
        {
            return $"{this.Name} can't afford {product.Name}";
        }

        this.Mone -= product.Cost;
        this.Products.Add(product);
        return $"{this.Name} bought {product.Name}";
    }

    public override string ToString()
    {
        string product = this.Products.Count > 0 ? string.Join(", ", this.Products) : "Nothing bought";
        string result = $"{name} - {string.Join(", ", product)}";
        return result;
    }
}