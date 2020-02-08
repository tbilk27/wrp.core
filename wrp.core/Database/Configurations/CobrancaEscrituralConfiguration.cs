using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class CobrancaEscrituralConfiguration : BaseConfiguration<CobrancaEscritural>
    {
        public void Configure(EntityTypeBuilder<CobrancaEscritural> builder)
        {
            builder.Property(o => o.Carteira)
                .HasMaxLength(2);
        }
    }
}