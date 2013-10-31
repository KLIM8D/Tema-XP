using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models.Mapping
{
    class AuctionMap : EntityTypeConfiguration<Auction>
    {
        public AuctionMap()
        {
            this.HasKey(t => t.Id);

            this.ToTable("Auctions");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Artwork.Id).HasColumnName("ArtworkId");
            this.Property(t => t.Bid.Id).HasColumnName("BidId");
            this.Property(t => t.Expires).HasColumnName("Expires");
            this.Property(t => t.Interval).HasColumnName("Date");
            this.Property(t => t.MinPrice).HasColumnName("MinPrice");
        }
    }
}
