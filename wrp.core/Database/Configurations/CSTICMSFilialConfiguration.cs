using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class CSTICMSFilialConfiguration : IEntityTypeConfiguration<CSTICMSFilial>
    {
        public void Configure(EntityTypeBuilder<CSTICMSFilial> builder)
        {
            builder.ToTable("CSTICMSFilial");

            builder.HasKey(o => o.ID);

            builder.HasOne(c => c.CSTICMS)
                .WithMany(c => c.Definicoes)
                .HasForeignKey(c => c.IDCSTICMS);

            builder.HasIndex(c => c.IDCSTICMS)
                .IsUnique();

        }
    }
}
