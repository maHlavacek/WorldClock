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

            while (!Console.KeyAvailable)
            {
                Console.WriteLine("**********WorldClock***********");
                Console.WriteLine("******Von Hlavacek Martin******");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(AtomClock.Instance.ToString());
                Console.ResetColor();
                Console.WriteLine();
                foreach (var item in clocks)
                {
                    Console.WriteLine(item.ToString());
                }
                Console.WriteLine();
                Console.WriteLine("Programm mit beliebiger Taste beenden ...");
                Thread.Sleep(1000);
                Console.Clear();
            }
            AtomClock.Instance.Stop();
            Console.ReadLine();
        }
    }
}
