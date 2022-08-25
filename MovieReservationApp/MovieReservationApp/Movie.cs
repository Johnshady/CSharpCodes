using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieReservationApp
{
    internal class Movie
    {
        public Movie()
        {
            Viewer = new List<Viewer>();
        }
        public string MovieTitle { get; set; }
        public string Date { get; set; }
        public Theatre Theatre { get; set; }
        public List <Viewer> Viewer { get; set; }
    }
}
