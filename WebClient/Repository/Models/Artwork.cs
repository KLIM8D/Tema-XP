using System;
using System.Runtime.Serialization;

namespace Repository.Models
{
    [DataContract(IsReference = false)]
    public partial class Artwork
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public decimal SizeHight { get; set; }
        [DataMember]
        public decimal SizeWidth { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public decimal Price { get; set; }
    }
}