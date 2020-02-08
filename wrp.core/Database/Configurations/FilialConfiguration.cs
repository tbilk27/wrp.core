using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class FilialConfiguration : BaseConfiguration<Filial>
    {
        public void Configure(EntityTypeBuilder<Filial> builder)
        {
            builder.HasOne(f => f.Pessoa)
                .WithMany(p => p.Filials)
                .HasForeignKey(f => f.IDPessoa);

            builder.Property(p => p.Nome)
                .HasMaxLength(200)
                .IsRequired(); 

        }
    }
}
