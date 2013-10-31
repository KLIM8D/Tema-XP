using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Repository.Models
{
    [DataContract(IsReference = false)]
    public partial class Category
    {
        public Category()
        {
            this.Artworks = new List<Artwork>();
        }

        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public virtual List<Artwork> Artworks { get; set; }
    }
}