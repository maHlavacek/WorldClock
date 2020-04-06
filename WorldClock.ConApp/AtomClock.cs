using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace WorldClock.ConApp
{
    class AtomClock : Clock
    {
        private AtomClock instance;
        private Timer timer;

        public event EventHandler<DateTime> TimeSyncPending;

        public AtomClock Instance
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
            Location = "Austria";
            Offset = 0;
            DateAndTime = DateTime.Now;
            timer = new Timer(250);
            timer.Elapsed += Timer_Elapsed;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            TimeSyncPending?.Invoke(this, DateAndTime);
        }
    }
}
