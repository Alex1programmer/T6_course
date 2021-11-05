using System;
using System.Collections.Generic;


    public class Galaxy
    {
        public string Name { get; private set; }//— название;
    public Dictionary<string, Planet> Planets { get; private set; }//— планеты.

    public Galaxy(string name) //конструктор
        {
            Name = name;
            Planets = new Dictionary<string, Planet>();
        }

        public void AddPlanet(string name, double radious, double temperature, bool atmosphere, bool life) //добавление планеты
        {
            Planets.Add(name, new Planet(name, radious, temperature, atmosphere, life));
        }


        public void AddPlanet(Planet P)//добавление нового спутника
        {
            Planets.Add(P.Name_, P);
        }

        public void Pl_with_life()
        {
            foreach (Planet Pl in Planets.Values)
            {

                Pl.show_alive(1);
            }

        }

        public double sum_of_temp()
        {
            double sum = 0;
            foreach (Planet Pl in Planets.Values)
            {
                sum += Pl.Temperature;
            }
            return sum;
        }
    }