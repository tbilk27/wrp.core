using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class CSTPISFilialConfiguration : BaseConfiguration<CSTPISFilial>
    {
        public void Configure(EntityTypeBuilder<CSTPISFilial> builder)
        {
            builder.HasOne(c => c.CSTPIS)
                .WithMany(c => c.Definicoes)
                .HasForeignKey(c => c.IDCSTPIS);

            builder.HasIndex(c => c.IDCSTPIS)
                .IsUnique();
        }
    }
}