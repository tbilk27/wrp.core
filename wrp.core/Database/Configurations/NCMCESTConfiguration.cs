using Microsoft.EntityFrameworkCore.Metadata.Builders;
using wrp.core.Entity;

namespace wrp.core.Database.Configurations
{
    public class NCMCESTConfiguration : BaseConfiguration<NCMCEST>
    {
        public void Configure(EntityTypeBuilder<NCMCEST> builder)
        {
            builder.HasOne<NCM>()
                .WithMany(c => c.NCMCEST)
                .HasForeignKey(n => n.IDNCM)
                .IsRequired();

            builder.HasIndex(p => p.IDNCM)
                .IsUnique();

            builder.HasOne<CEST>()
                .WithMany(c => c.NCMCESTs)
                .HasForeignKey(c => c.IDCEST)
                .IsRequired();

            builder.HasIndex(p => p.IDCEST)
                .IsUnique();
        }
    }
}