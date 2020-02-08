using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class EmpresaConfiguration : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.ToTable("Empresa");

            builder.HasKey(o => o.ID);

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