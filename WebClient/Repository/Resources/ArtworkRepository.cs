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

        public void Insert(Artwork artwork)
        {
            db.Artworks.Add(artwork);
            db.SaveChanges();
        }

        public void Disable(int value)
        {
            Artwork rArtwork = GetArtworkById(value);

            if (rArtwork == null)
                return;

            rArtwork.Active = false;
            db.SaveChanges();
        }
    }
}