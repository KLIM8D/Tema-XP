using System.Linq;
using Repository.Models;

namespace Repository.Resources
{
    public class BidRepository
    {
        private BPDbContext db;

        public BidRepository()
        {
            db = new BPDbContext();
        }

        public IQueryable<Bid> GetAllBids()
        {
            return db.Bids.Include("User").Include("Auction");
        }

        public Bid GetBidById(int value)
        {
            return db.Bids.Include("User").Include("Auction").FirstOrDefault(x => x.Id == value);
        }

        public IQueryable<Bid> GetAllBidsByAuction(Auction auction)
        {
            return db.Bids.Include("User").Include("Auction").Where(x => x.Auction == auction);
        }

        public IQueryable<Bid> GetAllBidsByUser(User user)
        {
            return db.Bids.Include("User").Include("Auction").Where(x => x.User == user);
        }

        public void InsertBid(Bid bid)
        {
            db.Bids.Add(bid);
            db.SaveChanges();
        }

        public void DisableBid(Bid bid)
        {
            db.Bids.Add(bid).Active = false;
        }

        public void DeleteBid(Bid bid)
        {
            db.Bids.Remove(bid);
            db.SaveChanges();
        }
    }
}