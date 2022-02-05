using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AliaksandrWeb.Models
{
    public class Movie
    {
        public Movie() => Rentals = new HashSet<Rental>();
        public int Id { get; set; }
        public string MovieName { get; set; }
        public string MovieCode { get; set; }

        public virtual ICollection<Rental> Rentals { get; set; }
    }
}
