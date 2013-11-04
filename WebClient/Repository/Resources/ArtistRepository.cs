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

        public Artist GetArtistByFullName(string value)
        {
            return db.Artists.FirstOrDefault(x => x.FirstName + " " + x.SurName == value);
        }

        public void InsertArtist(Artist artist)
        {
            db.Artists.Add(artist);
            db.SaveChanges();
        }

        public void DisableArtist(Artist artist)
        {
            db.Artists.Add(artist).Active = false;
            db.SaveChanges();
        }

        public void DeleteArtist(Artist artist)
        {
            db.Artists.Remove(artist);
            db.SaveChanges();
        }
    }
}