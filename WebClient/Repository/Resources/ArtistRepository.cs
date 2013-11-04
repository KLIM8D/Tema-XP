using System.Linq;
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

        public IQueryable<Artist> GetAllArtist()
        {
            return db.Artists;
        }

        public Artist GetArtistById(int value)
        {
            return db.Artists.FirstOrDefault(x => x.Id == value);
        }

        public void Insert(Artist artist)
        {
            db.Artists.Add(artist);
            db.SaveChanges();
        }

        public void Disable(int value)
        {
            Artist rArtist = GetArtistById(value);

            if (rArtist == null)
                return;

            rArtist.Active = false;
            db.SaveChanges();
        }
    }
}