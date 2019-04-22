using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hw03_davis
{
    public class Attendee
    {
        public Attendee(string name, int seatNumber, int age) 
        {
            this.name = name;
            this.seatNumber = seatNumber;
            this.age = age;
            
            if(age < 13)
            {
                ticketPrice = 5;
            }
            else
            {
                ticketPrice = 10;
            }
        }

        public string name { get; }
        
        public int seatNumber { get; }

        public int age { get; }

        public double ticketPrice { get; }

        public string toString()
        {
            string msg = "";

            msg += name + "\t\t " + seatNumber + "\t " + age + "\t $" + ticketPrice + ".00" + Environment.NewLine;

            return msg;
        }

    }
}