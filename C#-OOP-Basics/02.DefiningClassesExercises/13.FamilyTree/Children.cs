 public class Children
{
    private string name;
    private string birthday;

    public Children()
    {
    }

    public Children(string name, string birthday)
    {
        this.name = name;
        this.birthday = birthday;
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }
    public string BirthDay
    {
        get { return this.birthday; }
        set { this.birthday = value; }
    }
}