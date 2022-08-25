using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                AirlineReservation airlineReservation = new AirlineReservation();
                Console.WriteLine("WELCOME TO OUR AIRLINE MANAGEMENT SYSTEM\n\n");
                Console.WriteLine("OPERATIONS: Register a passenger :    Add a flight :    Add a passenger to a flight :    View flight details \n\n\n\n\n");
                var options = Console.ReadLine();

                if (options == "Register a passenger")
                {
                    Console.WriteLine("ENTER YOUR FIRST NAME\n\n");
                    var firstname = Console.ReadLine();
                    Console.WriteLine("ENTER YOUR LAST NAME\n\n");
                    var lastname = Console.ReadLine();
                    Console.WriteLine("ENTER THE NUMBER ON YOUR PASSPORT\n\n");
                    var passportnumber = long.Parse(Console.ReadLine());
                    airlineReservation.AddAPassenger(passportnumber, firstname, lastname);
                    Console.WriteLine("THE PASSENGER HAS BEEN SUCCESSFULLY ADDED");
                }
            }

        }
    }

}