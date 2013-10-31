using System.Data.Entity.ModelConfiguration;

namespace Repository.Models.Mapping
{
    public class ArtistMap : EntityTypeConfiguration<Artist>
    {
        public ArtistMap()
        {
            this.HasKey(t => t.Id);

            this.ToTable("Artists");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.SurName).HasColumnName("SurName");
        }
    }
}