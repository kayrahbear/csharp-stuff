using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("CRON", "Cronos Group");
            stocks.Add("CGC", "Canopy Growth Corp");
            stocks.Add("GWPH", "GW Pharmaceuticals plc");

            List<Dictionary<string, double>> purchases = new List<Dictionary<string, double>>();
            purchases.Add (new Dictionary<string, double>(){ {"GM", 230.21} });
            purchases.Add (new Dictionary<string, double>(){ {"CRON", 580.98} });
            purchases.Add (new Dictionary<string, double>(){ {"CGC", 406.34} });
            purchases.Add (new Dictionary<string, double>(){ {"CGC", 136.34} });
            purchases.Add (new Dictionary<string, double>(){ {"CGC", 206.34} });


            Dictionary<string, double> stockReport = new Dictionary<string, double>();

            /*
            Iterate over the purchases and record the valuation
            for each stock.
            */
            foreach (Dictionary<string, double> purchase in purchases)
            {
                foreach (KeyValuePair<string, double> stock in purchase)
                {
                    // Does the full company name key already exist in the `stockReport`?
                    string full_company_name = stocks[stock.Key];
                    if (stockReport.ContainsKey(full_company_name))
                    {
                        // If it does, update the total valuation
                        stockReport[full_company_name] += stock.Value;
                    }
        
                    /*
                        If not, add the new key and set its value.
                    */
                    else
                    {
                        stockReport[full_company_name] = stock.Value;
                    }
                }
            }

            foreach(KeyValuePair<string, double> item in stockReport)
            {
                Console.WriteLine($"The position in {item.Key} is worth {item.Value}");
            }

            List<string> planetList = new List<string>(){"Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus"};

            List<Dictionary<string, string>> probes = new List<Dictionary<string, string>>();
            probes.Add(new Dictionary<string, string>(){ {"Mercury","MESSENGER"} });
            probes.Add(new Dictionary<string, string>(){ {"Mercury","Mariner 10"} });
            probes.Add(new Dictionary<string, string>(){ {"Venus","Mariner 5"} });
            probes.Add(new Dictionary<string, string>(){ {"Venus","Galileo"} });
            probes.Add(new Dictionary<string, string>(){ {"Mars","Odyssey"} });
            probes.Add(new Dictionary<string, string>(){ {"Mars","InSight"} });
            probes.Add(new Dictionary<string, string>(){ {"Jupiter","Juno"} });
            probes.Add(new Dictionary<string, string>(){ {"Jupiter","Cassini"} });
            probes.Add(new Dictionary<string, string>(){ {"Saturn","Pioneer 11"} });
            probes.Add(new Dictionary<string, string>(){ {"Saturn","Dragonfly"} });
            probes.Add(new Dictionary<string, string>(){ {"Uranus","Voyager 2"} });

            foreach (string planet in planetList) // iterate planets
            {
                List<string> matchingProbes = new List<string>();

                foreach(Dictionary<string, string> probe in probes) // iterate probes
                {
                    /*
                        Does the current Dictionary contain the key of
                        the current planet? Investigate the ContainsKey()
                        method on a Dictionary.

                        If so, add the current spacecraft to `matchingProbes`.
                    */
                    if (probe.ContainsKey(planet))
                    {
                            matchingProbes.Add(probe[planet]);
                    }

                }

                /*
                    Use String.Join(",", matchingProbes) as part of the
                    solution to get the output below. It's the C# way of
                    writing `array.join(",")` in JavaScript.
                */
                Console.WriteLine($"{planet}: {String.Join(", ", matchingProbes)}");
            }

        }  
    }
}
