using System;
using System.Collections.Generic;
using System.Text;
using WorldClock.Contracts;

namespace WorldClock.ConApp
{
    public class Clock : IClock
    {
        public string Location { get; set; }
        public int Offset { get ; set; }
        public DateTime DateAndTime { get ; set ; }

        public delegate DateTime CalcDateAndTime(DateTime dateTime);

        public Clock()
        {
        }
    }
}
