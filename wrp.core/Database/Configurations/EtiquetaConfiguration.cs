using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class EtiquetaConfiguration : IEntityTypeConfiguration<Etiqueta>
    {
        public void Configure(EntityTypeBuilder<Etiqueta> builder)
        {
            builder.ToTable("Etiqueta");

            builder.HasKey(o => o.ID);

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
