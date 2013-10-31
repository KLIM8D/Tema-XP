using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Repository.Models
{
    [DataContract(IsReference = false)]
    public partial class Artist
    {
        public Artist()
        {
            this.Artworks = new List<Artwork>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public virtual List<Artwork> Artworks { get; set; }
        public bool Active { get; set; }
    }
}