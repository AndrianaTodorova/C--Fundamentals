using System;
using System.Text;
using System.Text.RegularExpressions;

public class Book
{
    private string title;
    private string author;
    private double price;

    public Book(string title, string author, double price)
    {
        this.Title = title;
        this.Author = author;
        this.Price = price;
    }

 
    public string Title
    {
        get { return this.title; }
        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Title not valid!");
            }
            this.title = value;
        }
    }

    public string Author
    {
        get { return this.author; }
        set
        {
            string pattern = @"^([a-zA-Z]+\s*[^0-9]+)$";
            
            if (!Regex.IsMatch(value, pattern))
            {
                throw new ArgumentException("Author not valid!");
            }
            this.author = value;
        }
    }

    public virtual double Price
    {
        get { return this.price; }
        set
        {
            if (value <= 0)
            {
                throw  new ArgumentException("Price not valid!");
            }
            this.price = value;
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("Type: ").AppendLine(this.GetType().Name)
            .Append("Title: ").AppendLine(this.Title)
            .Append("Author: ").AppendLine(this.Author)
            .Append("Price: ").Append($"{this.Price:f2}")
            .AppendLine();
        return sb.ToString();
    }

    
}