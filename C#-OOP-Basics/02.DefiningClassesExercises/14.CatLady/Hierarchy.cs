using System.Collections.Generic;

class Hierarchy
{
    private List<Cymric> cymric;
    private List<Siamese> siamese;
    private List<StreetExtraordinaire> street;

    public Hierarchy(List<Cymric> cymric, List<Siamese> siamese, List<StreetExtraordinaire> street)
    {
        this.cymric = cymric;
        this.siamese = siamese;
        this.street = street;
    }

    public List<Cymric> Cymric
    {
        get { return this.cymric; }
        set { this.cymric = value; }
    }
    public List<Siamese> Siamese
    {
        get { return this.siamese; }
        set { this.siamese = value; }
    }
    public List<StreetExtraordinaire> Street
    {
        get { return this.street; }
        set { this.street = value; }
    }
}