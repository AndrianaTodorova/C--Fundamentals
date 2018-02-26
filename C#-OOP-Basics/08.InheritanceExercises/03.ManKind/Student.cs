using System;
using System.Text;
using System.Text.RegularExpressions;

public class Student : Human
{
    public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
    {
        this.FacultyNumber = facultyNumber;
    }

    private string facultyNumber;

    public string FacultyNumber
    {
        get { return this.facultyNumber; }
        set
        {
            string pattern = @"^[a-zA-Z0-9]{5,10}$";
            if (!Regex.IsMatch(value, pattern))
            {
                throw new ArgumentException("Invalid faculty number!");
            }
            this.facultyNumber = value;
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(base.ToString())
            .Append($"Faculty number: {this.FacultyNumber}");
        return sb.ToString();
    }
}