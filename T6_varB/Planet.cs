using System;
using System.Collections.Generic;
public class Planet : Planetoid
{
    public double Temperature { get; private set; } //— температуру ядра;
    public bool Atmosphere { get; private set; }//— наличие атмосферы;
    public bool Life { get; private set; }//— наличие жизни;
    public LinkedList<Moon> Moons { get; private set; }//— спутники.

    public Planet(string name, double radious, double temperature, bool atmosphere, bool life)//конструктор
    {
        Name_ = name;
        Radious_ = radious;
        Temperature = temperature;
        Atmosphere = atmosphere;
        Life = life;
        Moons = new LinkedList<Moon>();
    }

    public void AddMoon(string name, double radious, double range)//добавление нового спутника 
    {
        if (Moons.Count == 0)
            Moons.AddFirst(new Moon(name, radious, range));
        else
            Moons.AddLast(new Moon(name, radious, range));
    }

    public void AddMoon(Moon M)//добавление нового спутника
    {
        if (Moons.Count == 0)
            Moons.AddFirst(M);
        else
            Moons.AddLast(M);
    }

    public void show_alive(int fl) //полный вывод пранет с жизнью
    {
        if (Life == true|| fl==0)
        {
            Console.WriteLine("\n=================================<Planet");
            Console.WriteLine($"Name: {Name_}");
            Console.WriteLine($"Radious: {Radious_}");
            Console.WriteLine($"Temperature: {Temperature}");
            Console.WriteLine($"Atmosphere:  {Atmosphere}");
            Console.WriteLine($"Life: {Life}");


            if (Moons.Count != 0)
            {
                Console.WriteLine($"\nMoons==============={Moons.Count}");
                foreach (Moon M in Moons)
                {
                    M.showMoon();
                }
            }

        }
    }

    public double Kol_drob_sum()
    {
        double sum = 0;
        foreach (Moon M in Moons)
        {
            sum += M.MoonVolume();
        }
        return Moons.Count/sum;
    }
}
