using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class ContadorConfiguration : IEntityTypeConfiguration<Contador>
    {
        public void Configure(EntityTypeBuilder<Contador> builder)
        {
            builder.ToTable("Contador");

            builder.HasKey(o => o.ID);

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
