using System;
using System.Text;

public class Human
{
    private string firstName;
    private string lastName;

    public Human(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string FirstName
    {
        get { return this.firstName; }
        set
        {
            if (!char.IsUpper(value[0]))
            {
                throw new ArgumentException($"Expected upper case letter! Argument: {nameof(this.firstName)}");
            }

            if (value.Length <= 3)
            {
                throw new ArgumentException($"Expected length at least 4 symbols! Argument: {nameof(this.firstName)}");
            }
            this.firstName = value;
        }
    }

    public string LastName
    {
        get { return this.lastName; }
        set
        {
            if (!char.IsUpper(value[0]))
            {
                throw new ArgumentException($"Expected upper case letter! Argument: {nameof(this.lastName)}");
            }
            if (value.Length <= 2)
            {
                throw new ArgumentException($"Expected length at least 3 symbols! Argument: {nameof(this.lastName)}");
            }
            this.lastName = value;
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"First Name: {this.FirstName}")
            .Append($"Last Name: {this.LastName}");
        return sb.ToString();
    }
}