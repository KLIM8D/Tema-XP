using System.Data.Entity.ModelConfiguration;

namespace Repository.Models.Mapping
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap() 
        {
            this.HasKey(t => t.Id);

            this.ToTable("Category");   
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Title).HasColumnName("Title");
        }
}