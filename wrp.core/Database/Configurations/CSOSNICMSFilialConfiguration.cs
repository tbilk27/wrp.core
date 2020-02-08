using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class CSOSNICMSFilialConfiguration : IEntityTypeConfiguration<CSOSNICMSFilial>
    {
        public void Configure(EntityTypeBuilder<CSOSNICMSFilial> builder)
        {
            builder.ToTable("CSOSNICMSFilial");

            builder.HasKey(o => o.ID);

            builder.HasOne(c => c.CSOSNICMS)
                .WithMany(c => c.Definicoes)
                .HasForeignKey(c => c.IDCSOSNICMS);

            builder.HasIndex(p => p.IDCSOSNICMS)
                .IsUnique();
        }
    }
}
