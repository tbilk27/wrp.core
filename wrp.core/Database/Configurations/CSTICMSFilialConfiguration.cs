using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class CSTICMSFilialConfiguration : BaseConfiguration<CSTICMSFilial>
    {
        public void Configure(EntityTypeBuilder<CSTICMSFilial> builder)
        {
            builder.HasOne(c => c.CSTICMS)
                .WithMany(c => c.Definicoes)
                .HasForeignKey(c => c.IDCSTICMS);

            builder.HasIndex(c => c.IDCSTICMS)
                .IsUnique();
        }
    }
}