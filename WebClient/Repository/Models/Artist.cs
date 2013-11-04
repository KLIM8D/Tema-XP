using System.Collections.Generic;

namespace Repository.Models
{
    public partial class Artist
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public virtual List<Artwork> Artworks { get; set; }
        public bool Active { get; set; }
    }
}