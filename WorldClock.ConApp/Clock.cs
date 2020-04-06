/* Klasse: 8ABIF 
 * Katalognummer: ad160270 
 * Name: Hlavacek Martin
 * Datum: 06.04.2020*/

using System;
using WorldClock.Contracts;

namespace WorldClock.ConApp
{
    public class Clock : IClock
    {
        public string Location { get; set; }
        public double Offset { get ; set; }
        public DateTime DateAndTime { get; set; }

        public override string ToString()
        {
            return Location.PadRight(30) + " " + DateAndTime.ToString("ddd.  dd.MMM.yyyy      HH:mm:ss");
        }
    }
}
