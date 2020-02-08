using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class CSOSNICMSFilialConfiguration : BaseConfiguration<CSOSNICMSFilial>
    {
        public void Configure(EntityTypeBuilder<CSOSNICMSFilial> builder)
        {
            builder.HasOne(c => c.CSOSNICMS)
                .WithMany(c => c.Definicoes)
                .HasForeignKey(c => c.IDCSOSNICMS);

            builder.HasIndex(p => p.IDCSOSNICMS)
                .IsUnique();
        }
    }
}