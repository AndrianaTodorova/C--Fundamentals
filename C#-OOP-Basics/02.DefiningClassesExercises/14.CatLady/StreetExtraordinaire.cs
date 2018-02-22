class StreetExtraordinaire
{
    private string name;
    private string decibels;

    public StreetExtraordinaire(string name, string decibels)
    {
        this.name = name;
        this.decibels = decibels;
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }
    public string Decibels
    {
        get { return this.decibels; }
        set { this.decibels = value; }
    }
}