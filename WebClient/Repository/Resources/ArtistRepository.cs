using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repository.Models;

namespace Repository.Resources
{
    public class ArtistRepository
    {
        private BPDbContext db;

        public ArtistRepository()
        {
            db = new BPDbContext();
        }
    }
}