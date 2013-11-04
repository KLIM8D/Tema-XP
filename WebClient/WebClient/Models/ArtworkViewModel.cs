using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Repository.Models;

namespace WebClient.Models
{
    public class ArtworkViewModel
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [Range(1, 99999)]
        public decimal Price { get; set; }

        public decimal SizeHeight { get; set; }
        public decimal SizeWidth { get; set; }
        public Artist Artist { get; set; }
        public Category Category { get; set; }

        public virtual List<ArtistViewModel> Artists { get; set; }
        
        public IEnumerable<SelectListItem> ArtistItems
        {
            get { return new SelectList(Artists, "Id", "FullName"); }
        }

        public virtual List<CategoryViewModel> Categories { get; set; }

        public IEnumerable<SelectListItem> CategoryItems
        {
            get { return new SelectList(Categories, "Id", "Title"); }
        }
    }
}