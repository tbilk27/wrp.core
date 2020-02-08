using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class CSTIPIFilialConfiguration : IEntityTypeConfiguration<CSTIPIFilial>
    {
        public void Configure(EntityTypeBuilder<CSTIPIFilial> builder)
        {
            builder.ToTable("CSTIPIFilial");

            builder.HasKey(o => o.ID);

            builder.HasOne(c => c.CSTIPI)
                .WithMany(c => c.Definicoes)
                .HasForeignKey(c => c.IDCSTIPI);

            builder.HasIndex(c => c.IDCSTIPI)
                .IsUnique();

        }
    }
}
