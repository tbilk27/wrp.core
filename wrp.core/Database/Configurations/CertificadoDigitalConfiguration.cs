using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class CertificadoDigitalConfiguration : IEntityTypeConfiguration<CertificadoDigital>
    {
        public void Configure(EntityTypeBuilder<CertificadoDigital> builder)
        {
            builder.ToTable("CertificadoDigital");

            builder.HasKey(o => o.ID);
            builder.Property(o => o.Descricao).HasMaxLength(500);
            builder.Property(o => o.Caminho).HasMaxLength(300).IsRequired();
            builder.Property(o => o.Senha).HasMaxLength(100);
            builder.HasIndex(o => new { o.IDEmpresa, o.Descricao }).IsUnique();
        }
    }
}