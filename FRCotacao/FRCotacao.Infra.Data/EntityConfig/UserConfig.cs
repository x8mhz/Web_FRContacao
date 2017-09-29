using FRCotacao.Model.Entities;
using System.Data.Entity.ModelConfiguration;

namespace FRCotacao.Infra.Data.EntityConfig
{
    public class UserConfig : EntityTypeConfiguration<User>
    {
        public UserConfig()
        {
            HasKey(p => p.UserId);
            Property(p => p.FirstName)
                .IsRequired()
                .HasMaxLength(150);

            Property(p => p.LastName)
                .IsRequired()
                .HasMaxLength(250);

            Property(p => p.Email)
                .IsRequired();

            Property(p => p.Password)
                .IsRequired()
                .HasMaxLength(15);
        }
    }
}
