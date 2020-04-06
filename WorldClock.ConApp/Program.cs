/* Klasse: 8ABIF 
 * Katalognummer: ad160270 
 * Name: Hlavacek Martin
 * Datum: 06.04.2020*/

using System;
using System.Collections.Generic;
using System.Threading;

namespace WorldClock.ConApp
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Clock> clocks = new List<Clock>();
            clocks.Add(new LocationClock(-6, "New York"));
            clocks.Add(new LocationClock(-5, "Sao Paulo"));
            clocks.Add(new LocationClock(-1, "London"));
            clocks.Add(new LocationClock(0, "Frankfurt"));
            clocks.Add(new LocationClock(6, "Hong Kong"));
            clocks.Add(new LocationClock(7, "Tokyo"));
            clocks.Add(new LocationClock(8, "Sydney"));
            clocks.Add(new LocationClock(2.5, "Afghanistan"));
            clocks.Add(new LocationClock(0, "Kairo"));

            while (Console.ReadKey().Key != ConsoleKey.X)
            {
                Console.WriteLine("**********WorldClock***********");
                Console.WriteLine("******Von Hlavacek Martin******");
                Console.WriteLine(AtomClock.Instance.ToString());
                foreach (var item in clocks)
                {
                    Console.WriteLine(item.ToString());
                }

                Thread.Sleep(1000);
                Console.Clear();
            }
            AtomClock.Instance.Stop();
        }
    }
}
