using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WebClient.Repository.Models
{
    [DataContract(IsReference = false)]
    public partial class Artist
    {
        public Artist()
        {
            this.Artworks = new List<Artwork>();
        }

        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string SurName { get; set; }
        [DataMember]
        public virtual List<Artwork> Artworks { get; set; } 
    }
}