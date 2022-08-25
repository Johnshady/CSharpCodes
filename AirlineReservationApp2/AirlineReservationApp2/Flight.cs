using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationApp2
{
    internal class Flight
    {
        public Flight()
        {
            Passenger = new List<Passenger>();
        }
        public long Flight_Number { get; set; }
        public string TakeOff { get; set; }
        public string Destination { get; set; }
        public string Date_Of_Flight { get; set; }
        public List<Passenger> Passenger { get; set; }
        public Plane Planes { get; set; }
    }
}

