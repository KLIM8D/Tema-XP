﻿using System.Collections.Generic;

namespace Repository.Models
{
    public partial class Category
    {
        public Category()
        {
            this.Artworks = new List<Artwork>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public virtual List<Artwork> Artworks { get; set; }
        public bool Active { get; set; }
    }
}