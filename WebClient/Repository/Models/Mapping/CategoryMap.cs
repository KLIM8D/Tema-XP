using System.Data.Entity.ModelConfiguration;

namespace Repository.Models.Mapping
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            this.HasKey(t => t.Id);

            this.ToTable("Categories");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Active).HasColumnName("Active");

            this.HasMany(t => t.Artworks);
        }
    }
}