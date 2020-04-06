/* Klasse: 8ABIF 
 * Katalognummer: ad160270 
 * Name: Hlavacek Martin
 * Datum: 06.04.2020*/

using System;
using System.Timers;

namespace WorldClock.ConApp
{
    public class AtomClock : Clock
    {
        private static AtomClock instance;
        private Timer timer;

        public event EventHandler<DateTime> TimeSyncPending;

        public static AtomClock Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new AtomClock();
                }
                return instance;
            }
        }

        private AtomClock()
        {
            Location = "Austria (Atomuhr)";
            Offset = 0;
            timer = new Timer(250);
            timer.Start();
            timer.Elapsed += Timer_Elapsed;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            DateAndTime = DateTime.Now;
            TimeSyncPending?.Invoke(this, DateAndTime);
        }

        public void Stop()
        {
            timer.Stop();
        }
    }
}
