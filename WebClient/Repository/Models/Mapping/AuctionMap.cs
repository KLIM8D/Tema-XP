using System.Data.Entity.ModelConfiguration;

namespace Repository.Models.Mapping
{
    public class AuctionMap : EntityTypeConfiguration<Auction>
    {
        public AuctionMap()
        {
            this.HasKey(t => t.Id);

            this.ToTable("Auctions");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Expires).HasColumnName("Expires");
            this.Property(t => t.MinPrice).HasColumnName("MinPrice");
            this.Property(t => t.Active).HasColumnName("Active");

            this.HasRequired(t => t.Artwork);
        }         
    }
}