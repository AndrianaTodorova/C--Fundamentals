class Siamese
{
    private string name;
    private string earSize;

    public Siamese(string name, string earSizes)
    {
        this.name = name;
        this.earSize = earSizes;
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }
    public string EarSize
    {
        get { return this.earSize; }
        set { this.earSize = value; }
    }
}