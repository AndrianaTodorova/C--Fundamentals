class Car
{
    private string model;
    private double speed;

    public Car(string model, double speed)
    {
        this.model = model;
        this.speed = speed;
    }

    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }
    public double Speed
    {
        get { return this.speed; }
        set { this.speed = value; }
    }

    public override string ToString()
    {
        return $"{this.model} {this.Speed}";
    }
}