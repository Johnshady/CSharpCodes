using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Theatre> theaters = new List<Theatre>()
            {
                new Theatre(){Location = "Ajonye Foundation, opposite agblo hotel, otukpo, benue state", Capacity = 59, Name = "Channel tv"},
                new Theatre(){Location = "Makurdi street, otukpo, benue state", Capacity = 70, Name = "Disney jnr"},
                new Theatre(){Location = "Hadijah street, otukpo, benue state", Capacity = 474,Name = "African Magic tv" },
            };

            var movies = new List<Movie>();
            var viewers = new Dictionary<long, Viewer>();
            while(true)
            {
                Console.WriteLine("Commands Are: Register Viewer, Add Movie, Sell Movie Ticket, View Movie Details");

                var command = Console.ReadLine();
                if (command.Equals("Register Viewer", StringComparison.OrdinalIgnoreCase))
                try
                {
                    {
                        Console.WriteLine("Enter name of viewer");
                        var name = Console.ReadLine();
                        Console.WriteLine("Enter phone number of viewer");
                        var phonenumber = long.Parse(Console.ReadLine());

                        viewers.Add(phonenumber, new Viewer { Name = name, PhoneNumber = phonenumber });
                        Console.WriteLine("Viewer registered successfully");
                    }
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }
                
                else if (command.Equals("Add movie", StringComparison.OrdinalIgnoreCase))
                try
                {
                    Console.WriteLine("Enter movie title");
                    var movieTitle = Console.ReadLine();
                    Console.WriteLine("Enter date of show");
                    var dateOfShow = Console.ReadLine();
                    Console.WriteLine("Enter theatre name");
                    var theatreName = Console.ReadLine();
                    var theatre = theaters.Where(x => x.Name == theatreName).First();

                    movies.Add(new Movie { MovieTitle = movieTitle, Date = dateOfShow, Theatre = theatre });
                    Console.WriteLine("Movie Added Successfully");
                }
                catch(Exception)
                {
                    Console.WriteLine("THEATRE DOES NOT EXIST");
                }
                else if (command.Equals("Sell Movie Ticket", StringComparison.OrdinalIgnoreCase))
                try
                {
                    Console.WriteLine("Enter phone number of viewer");
                    var phoneNumber = long.Parse(Console.ReadLine());
                    Console.WriteLine("Enter movie bargain for");
                    var movieTitle = Console.ReadLine();

                    var viewer = viewers[phoneNumber];
                    var movie = movies.Where(x => x.MovieTitle == movieTitle).First();
                    movie.Viewer.Add(viewer);
                    Console.WriteLine("Viewer added successfully to this movie");
                }
                catch(Exception)
                {
                    Console.WriteLine("PHONE NUMBER DOES NOT EXIST");
                }
                else if (command.Equals("View Movie Details", StringComparison.OrdinalIgnoreCase))
                try
                {
                    Console.WriteLine("Enter movie title to check details");
                    var movieTitle = Console.ReadLine();
                    var movie = movies.Where(x => x.MovieTitle == movieTitle).First();
                    Console.WriteLine($"Movie title: {movie.MovieTitle}, Date of show: {movie.Date}, Theatre of play: {movie.Theatre.Name}");

                    foreach (var viewer in movie.Viewer)
                    {
                        Console.WriteLine($"Name: {viewer.Name}, phone number: {viewer.PhoneNumber}");
                    }
                }
                catch(Exception)
                {
                    Console.WriteLine("MOVIE TITLE DOES NOT EXIST");
                }
                else
                {
                    Console.WriteLine("KINDLY INPUT A VALID COMMAND.");
                }
                
                

            }
        }
    }
}
