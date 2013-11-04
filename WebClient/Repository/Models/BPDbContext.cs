using System.Data.Entity;
using Repository.Models.Mapping;

namespace Repository.Models
{
    public class BPDbContext : DbContext
    {
        static BPDbContext()
        {
            /*Database.SetInitializer<BPDbContext>(null);*/
            Database.SetInitializer<BPDbContext>(new DropCreateDatabaseIfModelChanges<BPDbContext>());
        }

        public BPDbContext()
        {
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Artwork> Artworks { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Auction> Auctions { get; set; }
        public DbSet<Bid> Bids { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ArtistMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new ArtworkMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new AuctionMap());
            modelBuilder.Configurations.Add(new BidMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}