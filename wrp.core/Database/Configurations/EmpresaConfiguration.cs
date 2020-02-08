using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class EmpresaConfiguration : BaseConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.Property(p => p.Nome)
                .HasMaxLength(200)
                .IsRequired();

            builder.HasIndex(c => c.Nome)
                .IsUnique();

            builder.Property(p => p.CodigoArroba)
                .HasMaxLength(200)
                .IsRequired();

            builder.HasIndex(c => c.CodigoArroba)
                .IsUnique();
        }
    }
}