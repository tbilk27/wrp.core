using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class EtiquetaConfiguration : BaseConfiguration<Etiqueta>
    {
        public void Configure(EntityTypeBuilder<Etiqueta> builder)
        {
            builder.Property(p => p.DadoImpresso)
                .HasMaxLength(500);

            builder.HasOne(e => e.ProdutoItem)
                .WithMany(p => p.Etiquetas)
                .HasForeignKey(p => p.IDProdutoItem);

            builder.HasOne(e => e.ProdutoLote)
                .WithMany(l => l.Etiquetas)
                .HasForeignKey(e => e.IDProdutoLote);

            builder.HasOne(e => e.Local)
                .WithMany(l => l.Etiquetas)
                .HasForeignKey(e => e.IDLocal);
        }
    }
}