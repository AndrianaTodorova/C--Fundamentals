class Children
{
    private string childName;
    private string childBirthday;

    public Children(string childName, string childBirthday)
    {
        this.childName = childName;
        this.childBirthday = childBirthday;
    }

    public string ChildName
    {
        get { return this.childName; }
        set { this.childName = value; }
    }
    public string ChildBirthday
    {
        get { return this.childBirthday; }
        set { this.childBirthday = value; }
    }
    public override string ToString()
    {
        return $"{this.childName} {this.childBirthday}";
    }
}