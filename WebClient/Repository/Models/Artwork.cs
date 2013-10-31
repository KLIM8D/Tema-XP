using System;
using System.Runtime.Serialization;

namespace Repository.Models
{
    [DataContract(IsReference = false)]
    public partial class Artwork
    {
        public int Id { get; set; }
        public int ArtistId { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public decimal SizeHeight { get; set; }
        public decimal SizeWidth { get; set; }
        public decimal Price { get; set; }
        public virtual Artist Artist { get; set; }
        public virtual Category Category { get; set; }
    }
}