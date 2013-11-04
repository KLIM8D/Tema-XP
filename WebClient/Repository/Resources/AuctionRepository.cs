using System;
using System.Collections.Generic;
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
            return db.Auctions.FirstOrDefault(x => x.Id.Equals(id));
        }

        public void Insert(Auction auction)
        {
            db.Auctions.Add(auction);
            db.SaveChanges();
        }
    }
}
