﻿class Employee
{
    private string name;
    private double salary;
    private string position;
    private string department;
    private string email;
    private int age;

    public Employee(string name, double salary, string position, string department)
    {
        this.name = name;
        this.salary = salary;
        this.position = position;
        this.department = department;
    }

    public Employee(string name, double salary, string position, string department, string email, int age)
        : this(name,salary,position,department)
    {
        this.email = email;
        this.age = age;
    }
    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }
    public double Salary
    {
        get { return this.salary; }
        set { this.salary = value; }
    }
    public string Position
    {
        get { return this.position; }
        set { this.position = value; }
    }
    public string Department
    {
        get { return this.department; }
        set { this.department = value; }
    }

    public string Email
    {
        get { return this.email; }
        set { this.email = value; }
    }

    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }
}
