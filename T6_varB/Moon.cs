using System;

public class Moon : Planetoid
{
    public double Range { get; private set; }
    public Moon(string name, double radious, double range) //constructor
    {
        Name_ = name;
        Radious_ = radious;
        Range = range;
    }

    public double MoonVolume() //objem sputnika
    {
        //V = 4/3 πr³

        return (4 * 3.14 * Math.Pow(Radious_, 3)) / 3;
    }

    public void showMoon()
    {
        Console.WriteLine($"\nName: {Name_}");
        Console.WriteLine($"Radious: {Radious_}");
        Console.WriteLine($"Range from planet: {Range}");

    }
}