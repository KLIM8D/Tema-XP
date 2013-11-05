using System.Data.Entity;
using System.Linq;
using Repository.Models;

namespace Repository.Resources
{
    public class AuctionRepository
    {
        private readonly BPDbContext db;

        public AuctionRepository()
        {
            db = new BPDbContext();
        }

        public IQueryable<Auction> GetAllAuctions()
        {
            return db.Auctions;
        }

        public Auction GetAuctionById(int id)
        {
            return db.Auctions.FirstOrDefault(x => x.Id.Equals(id));
        }

        public void InsertAuction(Auction auction)
        {
            db.Entry(auction.Artwork).State = EntityState.Unchanged;
            db.Auctions.Add(auction);
            db.SaveChanges();
        }

        public void DisableAuction(Auction auction)
        {
            db.Auctions.Add(auction).Active = false;
            db.SaveChanges();
        }

        public void DeleteAuction(Auction auction)
        {
            db.Auctions.Remove(auction);
            db.SaveChanges();
        }
    }
}