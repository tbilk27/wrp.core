using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class ModeloDocumentoFiscalConfiguration : BaseConfiguration<ModeloDocumentoFiscal>
    {
        public void Configure(EntityTypeBuilder<ModeloDocumentoFiscal> builder)
        {
            builder.Property(c => c.Codigo)
                .HasMaxLength(2)
                .IsRequired();

            builder.HasIndex(m => m.Codigo)
                .IsUnique();

            builder.Property(c => c.Descricao)
                .HasMaxLength(60)
                .IsRequired();
        }
    }
}