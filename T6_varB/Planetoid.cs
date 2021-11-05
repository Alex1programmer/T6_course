public abstract class Planetoid
{
    private string Name;  // название
    private double Radious; // { get; private set; }   // радиус

    public string Name_
    {
        get { return Name; }
        set {Name = value; }
    }

    public double Radious_
    {
        get { return Radious; }
        set { Radious = value; }
    }

}