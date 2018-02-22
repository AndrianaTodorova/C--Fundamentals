public class Parents
{
    private string name;
    private string birthday;

    public Parents()
    {
    }

    public Parents(string name, string birthday)
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