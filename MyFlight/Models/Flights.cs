using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFlight.Models
{
    public class Flights
    {
        public int FlightNumber { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime FlightDate { get; set; }
        public DateTime Hour { get; set; }
        public int NumOfEvaliableSeats { get; set; }
        public int TotalSeatsAmount { get; set; }




    }
}