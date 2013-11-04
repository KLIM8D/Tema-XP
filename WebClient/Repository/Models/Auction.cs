using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
