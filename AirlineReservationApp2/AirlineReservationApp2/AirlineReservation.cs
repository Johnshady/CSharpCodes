using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationApp2
{
    internal class AirlineReservation
    {
        List<Flight> flight;
        Dictionary<long, Passenger> passenger;
        public AirlineReservation()
        {
            var plane = new List<Plane>()
            {
                new Plane(){Name="Emirates Airline", AirCraft_Number=100001 , NumberOfSeat= 700},
                new Plane(){Name="Nigeria Fly", AirCraft_Number=100002 , NumberOfSeat= 400},
                new Plane(){Name="The Eagle", AirCraft_Number=100003 , NumberOfSeat= 900}
            };
            var flight = new List<Flight>();
            var passenger = new Dictionary<long, Passenger>();
        }

        public void AddAPassenger(long passportNumber, string firstName, string lastName)
        {
            var passengers = new Passenger { First_Name = firstName, Last_Name = lastName, Passport_No = passportNumber };
            passenger.Add(passportNumber, passengers);
        }
    }
}
