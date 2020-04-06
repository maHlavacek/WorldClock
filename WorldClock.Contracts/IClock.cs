using System;
using System.Collections.Generic;
using System.Text;

namespace WorldClock.Contracts
{
    public interface IClock
    {
        public string Location { get; set; }
        public int Offset { get; set; }
        public DateTime DateAndTime { get; set; }
    }
}
