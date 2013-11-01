using System.Data.Entity.ModelConfiguration;

namespace Repository.Models.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            this.HasKey(t => t.Id);

            this.ToTable("Users");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.FirstName).HasColumnName("FistName");
            this.Property(t => t.SurName).HasColumnName("SurName");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.ZipCode).HasColumnName("ZipCode");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}