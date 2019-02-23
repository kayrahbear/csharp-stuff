using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){"Mercury", "Mars"};
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            List<string> endPlanetsList = new List<string>(){"Uranus", "Pluto"};
            planetList.AddRange(endPlanetsList);
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            
            foreach (string planet in planetList){
                Console.WriteLine(planet);
            }

            Random random = new Random();
            List<int> numbers = new List<int> {
                random.Next(10),
                random.Next(10),
                random.Next(10),
                random.Next(10),
                random.Next(10),
            };

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers.Contains(i))
                {
                    Console.WriteLine($"numbers list contains {i}");
                }
                
                Console.WriteLine($"numbers list does not contain {i}");
            }
        }
    }
}
