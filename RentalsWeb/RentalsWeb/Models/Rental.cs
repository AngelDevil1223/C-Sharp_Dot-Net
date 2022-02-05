using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AliaksandrWeb.Models
{
    public class Rental
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public DateTime RentedAt { get; set; }
        public DateTime MustReturn { get; set; }
        public DateTime FinallyReturn { get; set; }
        public decimal Price { get; set; }
        public decimal AddedPriceDelay { get; set; }
        public string LogisticCard { get; set; }
    }
}
