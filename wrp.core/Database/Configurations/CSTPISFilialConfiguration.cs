using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class CSTPISFilialConfiguration : IEntityTypeConfiguration<CSTPISFilial>
    {
        public void Configure(EntityTypeBuilder<CSTPISFilial> builder)
        {
            builder.ToTable("CSTPISFilial");

            builder.HasKey(o => o.ID);

            builder.HasOne(c => c.CSTPIS)
                .WithMany(c => c.Definicoes)
                .HasForeignKey(c => c.IDCSTPIS);

            builder.HasIndex(c => c.IDCSTPIS)
                .IsUnique();
        }
    }
}