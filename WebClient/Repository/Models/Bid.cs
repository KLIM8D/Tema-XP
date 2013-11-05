using System;

namespace Repository.Models
{
    public class Bid
    {
        public int Id { get; set; }
        public virtual User User { get; set; }
        public virtual Auction Auction { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
        public bool Active { get; set; }
    }
}
