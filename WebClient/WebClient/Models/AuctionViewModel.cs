using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Repository.Models;

namespace WebClient.Models
{
    public class AuctionViewModel
    {
        [Required(ErrorMessage = "Skal angives")]
        [Range(1,99999, ErrorMessage = "Værdien skal være i mellem 1 og 99999")]
        [DataType(DataType.Currency)]
        public decimal MinPrice { get; set; }

        [Required(ErrorMessage = "Skal angives")]
        [DataType(DataType.Currency)]
        [Range(1, 99999, ErrorMessage = "Værdien skal være i mellem 1 og 99999")]
        public decimal Interval { get; set; }
        public Artwork Artwork { get; set; }
        public Bid Bid { get; set; }
        [Required(ErrorMessage = "Skal angives")]
        [DataType(DataType.DateTime)]
        public DateTime Expires { get; set; }
        public int ArtistId { get; set; }
        public virtual List<ArtistViewModel> Artists { get; set; }
        public IEnumerable<SelectListItem> ArtistItems
        {
            get { return new SelectList(Artists, "Id", "FullName"); }
        }
        public virtual List<Artwork> Artworks { get; set; }
        public IEnumerable<SelectListItem> ArtworkItems
        {
            get { return new SelectList(Artworks, "Id", "Title"); }
        }
    }
}