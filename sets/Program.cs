using System;
using System.Collections.Generic;

namespace sets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> Showroom = new HashSet<string>();
            Showroom.Add("Honda Accord");
            Showroom.Add("Toyota Camry");
            Showroom.Add("Ford Mustang");
            Showroom.Add("Dodge Charger");
            
            Console.WriteLine($"There are {Showroom.Count} cars in the showroom");

            HashSet<string> UsedLot = new HashSet<string>();
            UsedLot.Add("Jeep Cherokee");
            UsedLot.Add("Toyota Prius");

            Showroom.UnionWith(UsedLot);

            Showroom.Remove("Jeep Cherokee");

            HashSet<string> Junkyard = new HashSet<string>();
            Junkyard.Add("Toyota Camry");
            Junkyard.Add("Toyota Prius");
            Junkyard.Add("Mazda CX-5");
            Junkyard.Add("Honda Pilot");
            Junkyard.Add("Toyota Tacoma");
            Junkyard.Add("Subaru Forester");

            HashSet<string> clone = new HashSet<string>(Showroom);
            clone.IntersectWith(Junkyard);
            Showroom.UnionWith(Junkyard);
        }
    }
}
