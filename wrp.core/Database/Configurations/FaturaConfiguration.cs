using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class FaturaConfiguration : IEntityTypeConfiguration<Fatura>
    {
        public void Configure(EntityTypeBuilder<Fatura> builder)
        {
            builder.ToTable("Fatura");

            builder.HasKey(o => o.ID);

            builder.Property(p => p.Numero)
                .IsRequired();

            builder.Property(n => n.Serie)
                .HasMaxLength(3);

            builder.Property(m => m.Modelo)
                .HasMaxLength(2);
        }
    }
}