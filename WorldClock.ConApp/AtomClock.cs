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
            timer = new Timer(250);
        }


    }
}
