using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Repository.Models;

namespace Repository.Resources
{
    public class ArtworkRepository
    {
        private BPDbContext db;

        public ArtworkRepository()
        {
            db = new BPDbContext();
        }

        public IQueryable<Artwork> GetAllArtworks()
        {
            return db.Artworks;
        }

        public Artwork GetArtworkById(int id)
        {
            return db.Artworks.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<Artwork> GetArtworksByArtistId(int artistId)
        {
            return db.Artworks.Where(x => x.ArtistId == artistId);
        }

        public void Insert(Artwork artwork)
        {
            db.Artworks.Add(artwork);
            db.SaveChanges();
        }

        public void Disable(int value)
        {
            Artwork artwork = GetArtworkById(value);

            if (artwork == null)
                return;

            artwork.Active = false;
            db.SaveChanges();
        }
    }
}
