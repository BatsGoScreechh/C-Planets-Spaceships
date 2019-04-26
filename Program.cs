using System;
using System.Collections.Generic;
using System.Collections;

namespace planets
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){"Mercury", "Mars"};

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            // Console.WriteLine(planetList[2]);

            List<string> planetList2 = new List<string>(){"Uranus", "Neptune"};

            planetList.AddRange(planetList2);

            planetList.Insert(1, "Earth");
            planetList.Insert(1, "Venus");
            planetList.Add("Pluto");
            planetList.ForEach(p => Console.WriteLine(p));

            List<string> rockyPlanets = planetList.GetRange(0, 4);

            rockyPlanets.ForEach(r => Console.WriteLine($"Rocky planets = {r}"));

            planetList.Remove("Pluto");
            planetList.ForEach(p => Console.WriteLine($"Completed List = {p}"));
        }
    }
}
