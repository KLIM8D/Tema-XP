using System.Linq;
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

        public Artwork GetArtworkById(int value)
        {
            return db.Artworks.FirstOrDefault(x => x.Id == value);
        }

        public void InsertArtwork(Artwork artwork)
        {
            db.Artworks.Add(artwork);
            db.SaveChanges();
        }

        public void DisableArtwork(Artwork artwork)
        {
            db.Artworks.Add(artwork).Active = false;
            db.SaveChanges();
        }

        public void DeleteArtwork(Artwork artwork)
        {
            db.Artworks.Remove(artwork);
            db.SaveChanges();
        }
    }
}