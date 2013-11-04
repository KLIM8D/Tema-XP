using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models.Mapping
{
    public class BidMap : EntityTypeConfiguration<Bid>
    {
        public BidMap()
        {
            this.HasKey(t => t.Id);

            this.ToTable("Bids");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.Date).HasColumnName("Date");

            this.HasRequired(t => t.User);
            this.HasRequired(t => t.Auction);
        }
    }
}
