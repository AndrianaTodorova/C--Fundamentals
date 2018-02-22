class Cymric
{
    private string name;
    private double furLength;

    public Cymric(string name, double furLength)
    {
        this.name = name;
        this.furLength = furLength;
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }
    public double FurLength
    {
        get { return this.furLength; }
        set { this.furLength = value; }
    }
}