﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class AtributoConfiguration : BaseConfiguration<Atributo>
    {
        public void Configure(EntityTypeBuilder<Atributo> builder)
        {
            builder.Property(o => o.Descricao)
                .HasMaxLength(200)
                .IsRequired();
            builder.HasIndex(o => new { o.IDEmpresa, o.IDFilial, o.Descricao })
                .IsUnique();
            builder.HasMany<AtributoValor>(o => o.Valores)
                .WithOne(g => g.Atributo)
                .HasForeignKey(g => g.IDAtributo);
        }
    }
}