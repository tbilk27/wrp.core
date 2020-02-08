using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class ContadorConfiguration : BaseConfiguration<Contador>
    {
        public void Configure(EntityTypeBuilder<Contador> builder)
        {
            builder.Property(p => p.Nome)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(p => p.Valor)
                .IsRequired();

            builder.HasIndex(i => i.Nome)
                .IsUnique();
        }
    }
}