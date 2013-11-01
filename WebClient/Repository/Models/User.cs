using System.Collections.Generic;

namespace Repository.Models
{
    public partial class User
    {
        public User()
        {
            this.Bids = new List<Bid>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public bool Active { get; set; }
        public virtual List<Bid> Bids { get; set; }
    }
}
