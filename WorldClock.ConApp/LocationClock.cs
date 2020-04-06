/* Klasse: 8ABIF 
 * Katalognummer: ad160270 
 * Name: Hlavacek Martin
 * Datum: 06.04.2020*/

using System;

namespace WorldClock.ConApp
{
    public class LocationClock : Clock
    {
        public LocationClock(double offset, string location)
        {
            Location = location;
            Offset = offset;
            AtomClock.Instance.TimeSyncPending += OnTimeSyncPending;
        }

        private void OnTimeSyncPending(object sender, DateTime e)
        {
            CalculateDateAndTime(e);
        }

        private void CalculateDateAndTime(DateTime time)
        {
            DateAndTime = time.AddHours(Offset);
        }

    }
}
