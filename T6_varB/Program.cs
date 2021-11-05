using System;
using System.Collections.Generic;

namespace T6_varB
{   
    class Program
    {
        static void Main(string[] args)
        {
            Moon M1 = new Moon("Turia", 123, 67.8);
            Moon M2 = new Moon("Clurus", 32, 68.4);

            Planet A = new Planet("Охроднин", 12, 222, true, true);
            A.AddMoon(M1);
            A.AddMoon(M2);

            //==============================================================-1планета (2 луны, жизнь)

            Moon MM1 = new Moon("Netus", 53, 23);
            Moon MM2 = new Moon("Pie342", 352, 4);
            Moon MM3 = new Moon("Argos", 797, 68.4);

            Planet B = new Planet("K2432", 1432, 562, true, false);
            B.AddMoon(MM1);
            B.AddMoon(MM2);
            B.AddMoon(MM3);

            //===============================================================-2планета (3 луны, жизни нет)

            Galaxy Gal = new Galaxy("Red Tumanus");
            Gal.AddPlanet(A);
            Gal.AddPlanet(B);

            //Gal.Pl_with_life();

            //================================================================-1 галактика (2 планеты, 784grad)


            //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<0>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
/**/
            //Moon M21 = new Moon("Kapel", 123, 67.8);
            

            Planet A1 = new Planet("Зеемля", 12, 132, true, true);
            A1.AddMoon("Kapel", 123, 67.8);
            
            //==============================================================-1планета (1 лунa, жизнь)

            Moon MM21 = new Moon("luna23", 53, 23);
            Moon MM22 = new Moon("tural", 352, 4);
            Moon MM23 = new Moon("o5s", 797, 68.4);

            Planet B1 = new Planet("RCT2432", 1432, 562, true, false);
            B1.AddMoon(MM21);
            B1.AddMoon(MM22);
            B1.AddMoon(MM23);

            //===============================================================-2планета (3 луны, жизни нет)

            Galaxy Gal1 = new Galaxy("Blue Tumanus");
            Gal1.AddPlanet(A1);
            Gal1.AddPlanet(B1);

            //Gal1.Pl_with_life();

            //================================================================-2 галактика (2 планеты, 694grad)

            var g_temper = double.MinValue;
            double temp;
            string nazvaG = "", nazvaP = "";

            var sootn1 = double.MinValue;


            /*Вывести информацию обо всех планетах, на которых присутствует жизнь, и их спутниках в заданной галактике*/
            Dictionary<string, Galaxy> Galaxyes = new Dictionary<string, Galaxy>();
            Galaxyes.Add(Gal.Name, Gal);
            Galaxyes.Add(Gal1.Name, Gal1);

            string nazv = Console.ReadLine();
            Galaxyes[nazv].Pl_with_life();

            /*Вывести информацию о планетах и их спутниках, имеющих наименьший радиус и наибольшее количество спутников.*/


            /*Вывести информацию о планете, галактике, в которой она находится, и ее спутниках, имеющей максимальное 
             * количество спутников, но с наименьшим общим объемом этих спутников.*/
            foreach (Galaxy G in Galaxyes.Values)
            {
                foreach (Planet P in G.Planets.Values)
                {
                    temp = P.Kol_drob_sum();
                    if (sootn1 < temp)
                    {
                        nazvaP = P.Name_;
                        nazvaG = G.Name;
                    }
                }
            }

            Console.WriteLine($"<>=========<>=========<>=========<>\nГалактика: {nazvaG}");
            Galaxyes[nazvaG].Planets[nazvaP].show_alive(0);


            /*Найти галактику, сумма ядерных температур планет которой наибольшая*/



            foreach (Galaxy G in Galaxyes.Values)
            {
                temp = G.sum_of_temp();
                if (g_temper < temp)
                { 
                    g_temper = temp;
                    nazvaG=G.Name;
                }
            }

            Console.WriteLine($"\nгалактика с наиб. суммой ядерных температур планет: {nazvaG}");


            //====================================================<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>

            

        }
    }
}
