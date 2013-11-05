using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            return db.Auctions.Include("Artwork").Include("Artist").FirstOrDefault(x => x.Id.Equals(id));
        }

        public Bid GetHighestBid(int auctionId)
        {
            return db.Bids.Where(x => x.Auction.Id.Equals(auctionId)).OrderByDescending(x => x.Price).FirstOrDefault();
        }

        public void Insert(Auction auction)
        {
            db.Auctions.Add(auction);
            db.Entry(auction.Artwork).State = EntityState.Unchanged;
            db.SaveChanges();
        }
    }
}
