using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class CobrancaEscrituralConfiguration : IEntityTypeConfiguration<CobrancaEscritural>
    {
        public void Configure(EntityTypeBuilder<CobrancaEscritural> builder)
        {
            builder.ToTable("CobrancaEscritural");

            builder.HasKey(o => o.ID);
            builder.Property(o => o.Carteira).HasMaxLength(2);
        }
    }
}