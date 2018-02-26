using System;
using System.Text;

public class Worker : Human
{
    public Worker(string firstName, string lastName, double salary, double hours) : base(firstName, lastName)
    {
        this.WeekSalary = salary;
        this.WorkingHours = hours;
    }

    private double weekSalary;

    public double WeekSalary
    {
        get { return this.weekSalary; }
        set
        {
            if (value < 10)
            {
                throw new ArgumentException($"Expected value mismatch! Argument: {nameof(this.weekSalary)}");
            }
            this.weekSalary = value;
        }
    }

    private double workHoursPerDay;

    public double WorkingHours
    {
        get { return this.workHoursPerDay; }
        set
        {
            if (value < 1 || value > 12)
            {
                throw new ArgumentException($"Expected value mismatch! Argument: {nameof(this.workHoursPerDay)}");
            }
            this.workHoursPerDay = value;
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(base.ToString())
            .AppendLine($"Week Salary: {this.WeekSalary:f2}")
            .AppendLine($"Hours per day: {this.workHoursPerDay:f2}")
            .Append($"Salary per hour: {(this.WeekSalary / (this.WorkingHours * 5)):f2}");
        return sb.ToString();
    }
}