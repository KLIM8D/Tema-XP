using System;
using System.Collections.Generic;

namespace Repository.Models
{
    public class Auction
    {
        public int Id { get; set; }
        public decimal MinPrice { get; set; }
        public decimal Interval { get; set; }
        public virtual Artwork Artwork { get; set; }
        public virtual List<Bid> Bids { get; set; }
        public DateTime Expires { get; set; }
        public bool Active { get; set; }
    }
}
