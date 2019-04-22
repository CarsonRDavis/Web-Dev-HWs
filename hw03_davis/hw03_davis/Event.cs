using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hw03_davis
{
    public class Event
    {
        internal List<Attendee> attendees = new List<Attendee>();
        internal List<int> seatNumbers = new List<int>();

        public Event(string name, int firstSeat, int lastSeat)
        {
            this.name = name;
            this.firstSeat = firstSeat;
            this.lastSeat = lastSeat;
        }

        public string name { get; }

        public int firstSeat { get; }

        public int lastSeat { get; }
    }
}