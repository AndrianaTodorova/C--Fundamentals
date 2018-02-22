using System;
using System.Runtime.CompilerServices;

class Car
{
    private string model;
    private double fuelAmount;
    private double fuelConsumption;
    private double distanceTraveled;

    public Car(string model, double fuelAmount, double fuelConsumption)
    {
        Model = model;
        FuelAmount = fuelAmount;
        FuelConsumption = fuelConsumption;
        Distance = 0;
    }

    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }
    public double FuelAmount
    {
        get { return this.fuelAmount; }
        set { this.fuelAmount = value; }
    }
    public double FuelConsumption
    {
        get { return this.fuelConsumption; }
        set { this.fuelConsumption = value; }
    }
    public double Distance
    {
        get { return this.distanceTraveled; }
        set { this.distanceTraveled = value; }
    }

    public void Drive(double kilometers)
    {
        double result = kilometers * this.FuelConsumption;
        if (result <= this.FuelAmount )
        {
            FuelAmount -= result;
            Distance += kilometers;
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
    }
}
