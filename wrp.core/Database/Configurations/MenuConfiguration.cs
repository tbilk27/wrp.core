using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class MenuConfiguration : BaseConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.Property(p => p.Descricao)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(p => p.Caminho)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(p => p.CaminhoEstrutura)
                .HasMaxLength(80)
                .IsRequired();

            builder.HasIndex(p => p.CaminhoEstrutura)
                .IsUnique();

            builder.Property(p => p.Icone)
                .HasMaxLength(200);

            builder.HasOne<Acesso>()
                .WithMany(m => m.Menus)
                .HasForeignKey(m => m.IDAcesso);
        }
    }
}
