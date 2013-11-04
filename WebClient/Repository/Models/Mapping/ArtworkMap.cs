using System.Data.Entity.ModelConfiguration;

namespace Repository.Models.Mapping
{
    public class ArtworkMap : EntityTypeConfiguration<Artwork>
    {
        public ArtworkMap()
        {
            this.HasKey(t => t.Id);

            this.ToTable("Artworks");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.SizeHeight).HasColumnName("SizeHeight");
            this.Property(t => t.SizeWidth).HasColumnName("SizeWidth");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.ImgFileName).HasColumnName("ImgFileName");
            this.Property(t => t.Active).HasColumnName("Active");

            this.HasRequired(t => t.Artist);
            this.HasRequired(t => t.Category);
        }
    }
}