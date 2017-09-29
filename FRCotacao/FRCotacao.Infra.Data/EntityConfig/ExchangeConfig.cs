using FRCotacao.Model.Entities;
using System.Data.Entity.ModelConfiguration;

namespace FRCotacao.Infra.Data.EntityConfig
{
    public class ExchangeConfig :EntityTypeConfiguration<Exchange>
    {
        public ExchangeConfig()
        {
            HasKey(p => p.ExchangeId);

            Property(p => p.Hour)
                .IsRequired();

            Property(p => p.Buy)
                .IsRequired();

            Property(p => p.Sell)
                .IsRequired();

            Property(p => p.Min)
                .IsRequired();

            Property(p => p.Max)
                .IsRequired();
        }
    }
}
