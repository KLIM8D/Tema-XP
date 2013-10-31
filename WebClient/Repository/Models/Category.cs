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

        public int Id { get; set; }
        public string Title { get; set; }
        public virtual List<Artwork> Artworks { get; set; }
    }
}